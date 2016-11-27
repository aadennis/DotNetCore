

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var d = new DataCollector();
            d.GetData();
        }
    }

    public class DataCollector
    {
        public void GetData()
        {
            var x = new Examplesx.System.Net.MyWebClient();
            string x2 = string.Empty;
            //x2 = await x.GetData();
            x.GetData();
            //var x2 = "adsfasdf";
            System.Console.WriteLine(x2);
            System.Console.WriteLine("here I am");
        }
    }
}
