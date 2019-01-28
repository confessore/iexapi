using IEXAPI;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stocks = new IEX().RetrieveBatchStocks("aapl", "googl", "fb", "intc", "msft", "wdc").Result;
            Console.WriteLine($"Number of stocks in list: {stocks.Count}");
            foreach (var stock in stocks)
                Console.WriteLine($"{stock.Quote.CompanyName}    Close: {stock.Quote.Close}");
            Console.Read();
        }
    }
}
