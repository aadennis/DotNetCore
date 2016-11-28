using System;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
         DoIt();
         //Console.Read();
         System.Console.WriteLine("Pretty much done here");
        }

        public async static void DoIt() {
            RunTask().GetAwaiter().GetResult();
            //RunTask().Wait();
            
        }

         public static async Task RunTask() {
            Console.WriteLine("Hello World!");
            await Task.Delay(5000);
            System.Console.WriteLine("Hello Planet");

        }
    }
}
