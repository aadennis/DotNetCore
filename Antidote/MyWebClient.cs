using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Examplesx.System.Net {

    public class MyWebClient {
       public async void GetData()
       {
            var sx = await DoWork();
            Console.WriteLine(sx);
              // no WebClient in DotNetCore...
           /* using (var client = new HttpClient()) {

                var baseUri = "http://news.bbc.co.uk";
                client.BaseAddress = new Uri(baseUri);
                client.DefaultRequestHeaders.Accept.Clear();
                var response = await client.GetAsync(baseUri);
                if (response.IsSuccessStatusCode) {
                    var responseJson = await response.Content.ReadAsStringAsync();
                    return responseJson;
                }
                Console.WriteLine("please");
                throw new Exception("Failed to get response");
            }
            */
       }

       private Task<string> DoWork() {
           return Task.Run(() => {
               Thread.Sleep(2000);
               return "Done Working";
           });
       } 
    }

}