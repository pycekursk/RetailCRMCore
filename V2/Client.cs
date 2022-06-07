using RetailCRMCore.V2.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace RetailCRMCore.V2
{
    public class Client
    {
        string _apiKey;
        string _url;
        HttpClient _client;

        public Client(string apiKey, string url)
        {
            if (string.IsNullOrEmpty(apiKey) || string.IsNullOrEmpty(url))
                throw string.IsNullOrEmpty(apiKey) ? new ArgumentNullException(nameof(apiKey)) : new ArgumentNullException(nameof(url));

            _apiKey = apiKey;
            _url = $"{url}/api/v5/";

            _client = new HttpClient();
            _client.DefaultRequestHeaders.TryAddWithoutValidation("X-API-KEY", _apiKey);
        }

        public async Task CalculateDelivery(string[] deliveryTypes, RetailCRMCore.Models.Order order)
        {
            Order _order = new Order
            {
                Weight = 0.8,
                Length = 30,
                Width = 30,
                Height = 10,
                Delivery = new Delivery
                {
                    Address = new Address
                    {
                        Region = "Курская область",
                        City = "Курск",
                        CityId = 3255,
                        RegionId = 27,
                        StreetId = 1403926,
                        Flat = "206",
                        Building = "9",
                        Block = 5,
                        Index = "305018"
                    }
                }
            };

            var queryDeliveryTypeCodes = $"{QueryBuilder.BuildQueryString(deliveryTypes)}";
            var orderQuery = $"order={_order.ToJson()}";
            var query = $"deliveryTypeCodes={Newtonsoft.Json.JsonConvert.SerializeObject(deliveryTypes)}&{orderQuery}";

            _url = _url + "delivery/calculate?";

            var response = await _client.PostAsync(_url, new StringContent(query, Encoding.UTF8, "application/x-www-form-urlencoded"));
            var data = await response.Content.ReadAsStringAsync();
        }

        public static async Task<Address> ParseAddress(Address address)
        {
            var url = $"https://yakutsa.retailcrm.ru/dictionary/geo/address-parse?country=RU&address={address.ToString()}&apiKey=h0NsTuUjjscl7JG5SEk6NZPJPuw4dryy";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders
            .Accept
            .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = await client.GetAsync(url);
            var json = await response.Content.ReadAsStringAsync();

            return address;
        }
    }
}