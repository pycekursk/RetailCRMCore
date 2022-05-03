using System;
using System.Collections.Generic;


namespace RetailCRMCore.Versions.V5
{
    public partial class Client
    {
        /// <summary>
        /// Combine orders
        /// </summary>
        /// <param name="order"></param>
        /// <param name="resultOrder"></param>
        /// <param name="technique"></param>
        /// <returns></returns>
        public Response OrdersCombine(Dictionary<string, object> order, Dictionary<string, object> resultOrder, string technique = "ours")
        {
            if (order.Count <= 0)
            {
                throw new ArgumentException("Parameter `order` must contains a data");
            }

            if (!order.ContainsKey("id"))
            {
                throw new ArgumentException("Parameter `order` must contains `id` key");
            }

            if (resultOrder.Count <= 0)
            {
                throw new ArgumentException("Parameter `resultOrder` must contains a data");
            }

            if (!resultOrder.ContainsKey("id"))
            {
                throw new ArgumentException("Parameter `resultOrder` must contains `id` key");
            }

            return Request.MakeRequest(
                "/orders/combine",
                Request.MethodPost,
                new Dictionary<string, object>
                {
                    { "technique", technique },
                    { "order", Newtonsoft.Json.JsonConvert.SerializeObject(order) },
                    { "resultOrder", Newtonsoft.Json.JsonConvert.SerializeObject(resultOrder) }
                }
            );
        }
    }
}
