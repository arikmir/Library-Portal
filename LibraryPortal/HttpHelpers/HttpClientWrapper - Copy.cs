using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace LibraryPortal.HttpHelpers
{
    public class HttpClientWrapper<T> where T : class
    {
        private string BaseUrl = "http://localhost:44327/";
        private HttpClient httpClient = new HttpClient();
        public List<Item> items = new List<Item>();

        //GET: api/items
        public async Task<List<Item>> GetItems()
        {
            httpClient.BaseAddress = new Uri(BaseUrl);
            httpClient.DefaultRequestHeaders.Clear();

            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("api/items");
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var response = httpResponseMessage.Content.ReadAsStringAsync().Result;
                items = JsonConvert.DeserializeObject<List<Item>>(response);
            }
            return items;
        }


        //GET: api/items/id
        public async Task<Item> GetItem()
        {
            // List<Item> items = new List<Item>();
            var item = new Item();

            httpClient.BaseAddress = new Uri(BaseUrl);
            httpClient.DefaultRequestHeaders.Clear();

            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("api/items/id");
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var response = httpResponseMessage.Content.ReadAsStringAsync().Result;
                item = JsonConvert.DeserializeObject<Item>(response);
            }
            return item;
        }

        //POST: api/items
        public async Task<List<Item>> Create()
        {
            // List<Item> items = new List<Item>();


            httpClient.BaseAddress = new Uri(BaseUrl);
            httpClient.DefaultRequestHeaders.Clear();

            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage httpResponseMessage = await httpClient.PostAsJsonAsync("api/items", items);
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var response = httpResponseMessage.Content.ReadAsStringAsync().Result;
                items = JsonConvert.DeserializeObject<List<Item>>(response);

            }
            return items;
        }
        
        //PUT: api/items
        public async Task<Item> Update()
        {
            var item = new Item();

            httpClient.BaseAddress = new Uri(BaseUrl);
            httpClient.DefaultRequestHeaders.Clear();

            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage httpResponseMessage = await httpClient.PostAsJsonAsync("api/items/id", item);
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var response = httpResponseMessage.Content.ReadAsStringAsync().Result;
                item = JsonConvert.DeserializeObject<Item>(response);
            }
            return item;
        }
        //DELETE: api/items
        public async Task<Item> Delete()
        {
            var item = new Item();

            httpClient.BaseAddress = new Uri(BaseUrl);
            httpClient.DefaultRequestHeaders.Clear();

            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage httpResponseMessage = await httpClient.DeleteAsync("api/items/id");
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var response = httpResponseMessage.Content.ReadAsStringAsync().Result;
                item = JsonConvert.DeserializeObject<Item>(response);
            }
            return item;
        }

    }
}