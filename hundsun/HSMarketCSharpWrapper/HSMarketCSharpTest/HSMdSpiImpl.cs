using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTACSharp.HS.Market;

namespace HSMarketCSharpTest
{
    public class HSMdSpiImpl : CHSMdSpi
    {
        private CHSMdApi _api;

        public HSMdSpiImpl(CHSMdApi api)
        {
            _api = api;
        }

        public override void OnFrontConnected()
        {
            Console.WriteLine("OnFrontConnected");
            
        }

        public override void OnFrontDisconnected(int nResult)
        {
            Console.WriteLine("OnFrontDisconnected");
        }

        public override void OnRspDepthMarketDataSubscribe(CHSRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspDepthMarketDataSubscribe");
        }

        public override void OnRspDepthMarketDataCancel(CHSRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspDepthMarketDataCancel");
        }

        public override void OnRtnDepthMarketData(CHSDepthMarketDataField pDepthMarketData)
        {
            Console.WriteLine("OnRtnDepthMarketData");
        }
    }
}
