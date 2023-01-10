
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace CurrencyConverterv1
{
    internal class CurrencyConverter
    {
        Dictionary<string, string> symbols;
        public Dictionary<string, string> GetSymbols()
        {
            if (symbols == null)
            {
                symbols = new Dictionary<string, string>();
                string response = getResponseString("exchangerates_data/symbols");

                Dictionary<string, object> responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(response);
                if ((bool)responseData["success"])
                {
                    var currencySymbols = (JObject)responseData["symbols"];
                    symbols = currencySymbols.ToObject<Dictionary<string, string>>();
                }
            }
            return symbols;
        }

        internal double Convert(string fromCurr, string toCurr, double amount)
        {
            string response = getResponseString($"/exchangerates_data/convert?to={toCurr}&from={fromCurr}&amount={amount}");

            Dictionary<string, object> responseData = JsonConvert.DeserializeObject<Dictionary<string, object>>(response);
            if ((bool)responseData["success"])
            {
                return (double)responseData["result"];

            }
            else
            {
                return -1;
            }
        }

        private string getResponseString(string relativeURI)
        {
            var client = new RestClient("https://api.apilayer.com/");

            var request = new RestRequest(relativeURI ,Method.Get);
            request.AddHeader("apikey", "lHeAdkzRK2HNsFBPwY4dSHGavFLyqyOC");

            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return response.Content;
        }
    }
}
