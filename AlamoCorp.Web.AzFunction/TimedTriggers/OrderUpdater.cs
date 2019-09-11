using AlamoCorp.Web.AzFunction.Models.Core;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace AlamoCorp.Web.AzFunction.TimedTriggers
{
    public static class OrderUpdater
    {
        [FunctionName("OrderUpdater")]
        public static async void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"Order ID\tCustomer Name\tOrder Date\tOld Order Status\tNew Order Status");
            using (HttpClient httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.GetStringAsync($"{ServiceConstants.BaseServiceURI}/orders/getorders");
                var Orders = JsonConvert.DeserializeObject<List<Order>>(httpResponse);
                foreach (Order order in Orders)
                {
                    var uri = new Uri($"{ServiceConstants.BaseServiceURI}/orders/updateorderstatus/{order.OrderID}");
                    string jsonTransport = JsonConvert.SerializeObject(order);
                    var jsonPayload = new StringContent(jsonTransport, Encoding.UTF8, "application/json");
                    var HttpResponse = await httpClient.PutAsync(uri, jsonPayload);
                    var UpdatedOrder = JsonConvert.DeserializeObject<Order>(await HttpResponse.Content.ReadAsStringAsync());
                    log.LogInformation($"{order.OrderID}\t{order.Customer.FullName}\t{order.CreatedDate.ToShortDateString()}\t{order.DeliveryStatus.ToString()}\t{UpdatedOrder.DeliveryStatus.ToString()}");
                }
            }
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
