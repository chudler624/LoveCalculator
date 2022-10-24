namespace LoveCalc.Models
{
    public class LoveModelResults
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Root
        {
            public string fname { get; set; }
            public string sname { get; set; }
            public string percentage { get; set; }
            public string result { get; set; }
        }



    }
}
