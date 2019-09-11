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
        [FunctionName("ProductLogUpdater")]
        public static async void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var httpResponse = await httpClient.GetStringAsync($"{ServiceConstants.BaseServiceURI}/products/getproducts");
                var Products = JsonConvert.DeserializeObject<List<Product>>(httpResponse);
                foreach (Product product in Products)
                {

                    log.LogInformation($"{product.ProductID}\t{product.Name}\t{product.DateCreated.ToShortDateString()}\t{product.Description}");
                }
            }
            log.LogInformation($"Products Updated at {DateTime.Now}");
        }
    }
}
