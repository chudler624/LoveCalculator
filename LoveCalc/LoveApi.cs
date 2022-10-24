using LoveCalc.Models;
using Newtonsoft.Json.Linq;
using RestSharp;


namespace LoveCalc
{
    public class LoveApi
    {
        public LoveApi() { }

        public LoveModel GetMatchPercentage(string name1, string name2)
        {
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri($"https://love-calculator.p.rapidapi.com/getPercentage?sname={name1}&fname={name2}"),
				Headers =
	{
		{ "X-RapidAPI-Key", "fe96c29976msh7164fa7f072bef1p19efc6jsn0ad83cbe2bb2" },
		{ "X-RapidAPI-Host", "love-calculator.p.rapidapi.com" },
	},
			};
			using (var response = client.SendAsync(request).Result)
			{
				response.EnsureSuccessStatusCode();
				var body = response.Content.ReadAsStringAsync().Result;
				var compatibility = JObject.Parse(body);
				

				var LoveModel = new LoveModel();
				LoveModel.Percent = (string)JObject.Parse(body)["percentage"];
				LoveModel.Result = (string)JObject.Parse(body)["results"];
				LoveModel.Name1 = (string)JObject.Parse(body)["fname"];
				LoveModel.Name2 = (string)JObject.Parse(body)["sname"];

                
               

				return LoveModel;
				
			}

		}
      
    }
}
