using System;
using System.IO;
using System.Net.Http;

//http://codesimplified.blogspot.co.uk/2013/11/asynchronous-file-download-from-web.html - thanks
namespace ConsoleApplication1
{
    class Program
    {

        static async void getImage(string Location)
        {
            string webAddress = string.Format("http://maps.googleapis.com/maps/api/staticmap?center={0}&zoom=17&size=1200x1200&sensor=false", Location);
        
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(webAddress);
            response.EnsureSuccessStatusCode();


            using (FileStream fileStream = new FileStream(string.Format("e:\\{0}.png",Location), FileMode.Create, FileAccess.Write, FileShare.None))
            {
                await response.Content.CopyToAsync(fileStream);
            }
        }

        static void Main(string[] args)
        {
            getImage("Bracknell");

            Console.WriteLine("Hit  enter to exit...");
            Console.ReadLine();
        }
    }
}
