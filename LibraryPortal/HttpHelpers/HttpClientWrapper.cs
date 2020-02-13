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
        private string BaseUrl = "http://localhost:44327//";
        private HttpClient httpClient = new HttpClient();

        public List<T> items = new List<T>();

        //GET: api/items
        public async Task<List<T>> GetItems()
        {
            httpClient.BaseAddress = new Uri(BaseUrl);
            httpClient.DefaultRequestHeaders.Clear();

            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("api/items");
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var response = httpResponseMessage.Content.ReadAsStringAsync().Result;
                items = JsonConvert.DeserializeObject<List<T>>(response);
            }
            return items;
        }

        //GET: api/items/id
        public async Task<T> GetItem(int id)
        {
            // List<Item> items = new List<Item>();
            T item = default(T);

            httpClient.BaseAddress = new Uri(BaseUrl);
            httpClient.DefaultRequestHeaders.Clear();

            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage httpResponseMessage = await httpClient.GetAsync("api/items/" + id);
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var response = httpResponseMessage.Content.ReadAsStringAsync().Result;
                item = JsonConvert.DeserializeObject<T>(response);
            }
            return item;
        }

        //POST: api/items
        public async Task<List<T>> Create(object model)
        {
            httpClient.BaseAddress = new Uri(BaseUrl);
            httpClient.DefaultRequestHeaders.Clear();

            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage httpResponseMessage = await httpClient.PostAsJsonAsync("api/items", model);
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var response = httpResponseMessage.Content.ReadAsStringAsync().Result;
                items = JsonConvert.DeserializeObject<List<T>>(response);
            }
            return items;
        }

        //PUT: api/items/id

        public async Task<T> Update(int id, object model)
        {
            var item = default(T);
            httpClient.BaseAddress = new Uri(BaseUrl);
            httpClient.DefaultRequestHeaders.Clear();

            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage httpResponseMessage = await httpClient.PutAsJsonAsync("api/items/" + id.ToString(), model);
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var response = httpResponseMessage.Content.ReadAsStringAsync().Result;
                item = JsonConvert.DeserializeObject<T>(response);
            }
            return item;
        }

        // DELETE: api/items/id

        public async Task<T> Delete(int id)
        {
            var item = default(T);

            httpClient.BaseAddress = new Uri(BaseUrl);
            httpClient.DefaultRequestHeaders.Clear();

            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage httpResponseMessage = await httpClient.DeleteAsync("api/items/" + id.ToString());
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var response = httpResponseMessage.Content.ReadAsStringAsync().Result;
                item = JsonConvert.DeserializeObject<T>(response);
            }
            return item;
        }
    }
}