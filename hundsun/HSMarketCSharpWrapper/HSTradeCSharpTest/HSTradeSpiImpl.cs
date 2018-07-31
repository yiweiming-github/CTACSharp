using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTACSharp.HS.Trade;

namespace HSTradeCSharpTest
{
    class HSTradeSpiImpl : CHSTradeSpi
    {
        private CHSTradeApi _api;
        private int _requestId;


        public HSTradeSpiImpl(CHSTradeApi api)
        {
            _api = api;
            _requestId = 0;
        }

        public override void OnFrontConnected()
        {
            Console.WriteLine("OnFrontConnected");

            var loginData = new CHSReqUserLoginField()
            {
                AccountID = "10130259101",
                Password = "1",
                UserApplicationType = (char)7,
                UserApplicationInfo = "192.168.155.89"
            };
            _api.ReqUserLogin(loginData, _requestId++);
        }

        public override void OnRspUserLogin(CHSRspUserLoginField pRspUserLogin, CHSRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspUserLogin");

            var marketReq = new CHSReqQryDepthMarketDataField()
            {
                ExchangeID = "F1",
                InstrumentID = "AP811"
            };
            _api.ReqQryDepthMarketData(marketReq, _requestId++);
        }

        public override void OnRspQryDepthMarketData(CHSDepthMarketDataField pRspQryDepthMarketData, CHSRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryDepthMarketData");

            if (pRspInfo.ErrorID != 0)
            {
                Console.WriteLine($"ErrorID: {pRspInfo.ErrorID}, ErrorMsg: {pRspInfo.ErrorMsg}");
            }
            else if (pRspQryDepthMarketData != null)
            {
                Console.WriteLine($"TradingDay: {pRspQryDepthMarketData.TradingDay}");
                Console.WriteLine($"ExchangeID: {pRspQryDepthMarketData.ExchangeID}");
                Console.WriteLine($"InstrumentID: {pRspQryDepthMarketData.InstrumentID}");
                Console.WriteLine($"LastPrice: {pRspQryDepthMarketData.LastPrice}");
                Console.WriteLine($"PreClosePrice: {pRspQryDepthMarketData.PreClosePrice}");
            }
        }
    }
}
