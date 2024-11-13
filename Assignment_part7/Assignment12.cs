using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Assignment_part7
{
    public class Download
    {
        public static async Task Call(string url)
        {
            using HttpClient client = new HttpClient();

            try
            {
                // Asynchronously send a GET request to the specified URL
                HttpResponseMessage response = await client.GetAsync(url);

                // Ensure the request was successful
                response.EnsureSuccessStatusCode();

                // Read the content of the response as a string asynchronously
                string content = await response.Content.ReadAsStringAsync();

                // Print the length of the content
                Console.WriteLine($"Content Length: {content.Length}");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Request error: {ex.Message}");
            }
        }
    }
}
