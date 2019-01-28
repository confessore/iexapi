using IEXAPI.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace IEXAPI
{
    public class IEX
    {
        readonly Uri api = new Uri("https://api.iextrading.com/1.0/");
        readonly string stock = "stock/";
        readonly string market = "market/";
        readonly string book = "book";
        readonly string batch = "batch?";
        readonly string symbols = "symbols=";
        readonly string types = "&types=";
        readonly string quote = "quote,";

        public async Task<Stock> RetrieveSingleStock(string name)
        {
            return JsonConvert.DeserializeObject<Stock>(
                await new WebClient()
                .DownloadStringTaskAsync(api + stock + $"{name}/" + book));
        }

        public async Task<List<Stock>> RetrieveBatchStocks(params string[] names)
        {
            var symbols = this.symbols;
            foreach (var name in names)
                symbols += name + ",";
            var json = await new WebClient()
                .DownloadStringTaskAsync(api + stock + market + batch + symbols + types + quote);
            var list = new List<Stock>();
            foreach (var val in JObject.Parse(json).Values())
                list.Add(JsonConvert.DeserializeObject<Stock>(val.ToString()));
            return list;
        }

        public async Task<string> Test()
        {
            return 
                await new WebClient()
                .DownloadStringTaskAsync(api+stock+"fb/"+book);
        }
    }
}
