using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTAWrapper.Structs
{
    public class DepthMarketDataField
    {
        public string TradingDay { get; set; }
        public string InstrumentID { get; set; }
        public string ExchangeID { get; set; }
        public string ExchangeInstID { get; set; }
        public double LastPrice { get; set; }
        public double PreSettlementPrice { get; set; }
        public double PreClosePrice { get; set; }
        public double PreOpenInterest { get; set; }
        public double OpenPrice { get; set; }
        public double HighestPrice { get; set; }
        public double LowestPrice { get; set; }
        public int Volume { get; set; }
        public double Turnover { get; set; }
        public double OpenInterest { get; set; }
        public double ClosePrice { get; set; }
        public double SettlementPrice { get; set; }
        public double UpperLimitPrice { get; set; }
        public double LowerLimitPrice { get; set; }
        public double PreDelta { get; set; }
        public double CurrDelta { get; set; }
        public string UpdateTime { get; set; }
        public int UpdateMillisec { get; set; }
        public double BidPrice1 { get; set; }
        public int BidVolume1 { get; set; }
        public double AskPrice1 { get; set; }
        public int AskVolume1 { get; set; }
        public double BidPrice2 { get; set; }
        public int BidVolume2 { get; set; }
        public double AskPrice2 { get; set; }
        public int AskVolume2 { get; set; }
        public double BidPrice3 { get; set; }
        public int BidVolume3 { get; set; }
        public double AskPrice3 { get; set; }
        public int AskVolume3 { get; set; }
        public double BidPrice4 { get; set; }
        public int BidVolume4 { get; set; }
        public double AskPrice4 { get; set; }
        public int AskVolume4 { get; set; }
        public double BidPrice5 { get; set; }
        public int BidVolume5 { get; set; }
        public double AskPrice5 { get; set; }
        public int AskVolume5 { get; set; }
        public double AveragePrice { get; set; }
        public string ActionDay { get; set; }
    }
}
