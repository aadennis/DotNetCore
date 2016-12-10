namespace ClassLibrary {
    public class Thing {
       public int Get(int number) => 
            Newtonsoft.Json.JsonConvert.DeserializeObject<int>($"{number}");
    }
}
