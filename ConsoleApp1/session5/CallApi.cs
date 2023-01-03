using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace ConsoleApp1.session5
{
    public class CallApi
    {
        public async Task<Product> FetchData()
        {
            string url = "https://dummyjson.com/products/1";

            HttpClient client= new HttpClient();
            var rs = await client.GetAsync(url);
            if (rs.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string responseText = await rs.Content.ReadAsStringAsync();
                Product p = JsonConvert.DeserializeObject<Product>(responseText);

                return p;
            }
            return null;
        }
    }

}
