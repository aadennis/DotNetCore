using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("starting out");
            var d = new DataCollector();

            DataCollector.GetDataAsync();

        }
    }

    public class DataCollector
    {
        static string webAddress = "http://maps.googleapis.com/maps/api/staticmap?center=Chicago,IL&zoom=14&size=1200x1200&sensor=false";
        HttpClient client;

                public int counter { get; set; }
        public DataCollector()
        {
            counter = 0;
            client = new HttpClient();
           
        }
        public static async Task GetDataAsync()
        {
           try {
               var client = new HttpClient();
               var response = await client.GetAsync(webAddress);
               response.EnsureSuccessStatusCode();

               using (FileStream fileStream = new FileStream("e:\\img.png", FileMode.Create, FileAccess.Write, FileShare.None)) {
                   await response.Content.CopyToAsync(fileStream);
               }

           }
           catch (HttpRequestException hex) {
               System.Console.WriteLine(hex.ToString());
           }
           catch (Exception ex) {
               System.Console.WriteLine(ex.ToString());
               throw;
           }
        
        }

       
    }
}
