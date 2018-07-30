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
        public override void OnFrontConnected()
        {
            Console.WriteLine("OnFrontConnected");
            
        }

        public override void OnFrontDisconnected(int nResult)
        {
            base.OnFrontDisconnected(nResult);
        }

        public override void OnRspDepthMarketDataSubscribe(CHSRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            base.OnRspDepthMarketDataSubscribe(pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspDepthMarketDataCancel(CHSRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            base.OnRspDepthMarketDataCancel(pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRtnDepthMarketData(CHSDepthMarketDataField pDepthMarketData)
        {
            base.OnRtnDepthMarketData(pDepthMarketData);
        }
    }
}
