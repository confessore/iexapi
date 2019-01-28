namespace IEXAPI.Models
{
    public class Quote
    {
        public string Symbol { get; set; }
        public string CompanyName { get; set; }
        public string PrimaryExchange { get; set; }
        public string Sector { get; set; }
        public string CalculationPrice { get; set; }
        public double Open { get; set; }
        public long OpenTime { get; set; }
        public double Close { get; set; }
        public long CloseTime { get; set; }
        public double High { get; set; }
        public double Low { get; set; }
        public double LatestPrice { get; set; }
        public string LatestSource { get; set; }
        public string LatestTime { get; set; }
        public long LatestUpdate { get; set; }
        public long LatestVolume { get; set; }
        public double? IEXRealtimePrice { get; set; }
        public long? IEXRealtimeSize { get; set; }
        public long? IEXLastUpdated { get; set; }
        public double DelayedPrice { get; set; }
        public long DelayedPriceTime { get; set; }
        public double ExtendedPrice { get; set; }
        public double ExtendedChange { get; set; }
        public float ExtendedChangePercent { get; set; }
        public long ExtendedPriceTime { get; set; }
        public double PreviousClose { get; set; }
        public double Change { get; set; }
        public float ChangePercent { get; set; }
        public float? IEXMarketPercent { get; set; }
        public long? IEXVolume { get; set; }
        public long AvgTotalVolume { get; set; }
        public double? IEXBidPrice { get; set; }
        public long? IEXBidSize { get; set; }
        public double? IEXAskPrice { get; set; }
        public long? IEXAskSize { get; set; }
        public long MarketCap { get; set; }
        public double PERatio { get; set; }
        public double Week52High { get; set; }
        public double Week52Low { get; set; }
        public float YTDChange { get; set; }
        public string[] Bids { get; set; }
        public string[] Asks { get; set; }
        public string SystemEvent { get; set; }
    }
}
