using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTAWrapper;
using CTAWrapper.Structs;

namespace CTAWrapperTest
{
    public class MarketCallbackApiImpl : IMarketCallbackApi
    {
        public void OnFrontConnected()
        {
            Console.WriteLine("OnFrontConnected");
            _isConnected = true;
        }

        public void OnFrontDisconnected(int nReason)
        {
            Console.WriteLine("OnFrontDisconnected reason: {0}", nReason);
        }

        public void OnHeartBeatWarning(int nTimeLapse) { throw new NotImplementedException(); }

        public void OnRspUserLogin(RspUserLoginField pRspUserLogin, RspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            if (pRspInfo.ErrorID != 0)
            {
                Console.WriteLine("OnRspUserLogin Error: {0}", pRspInfo.ErrorMsg);
            }
            else
            {
                Console.WriteLine("OnRspUserLogin");
                _isReady = true;
            }
        }

        public void OnApiReady()
        {
            _isReady = true;
        }

        public void OnRspUserLogout(UserLogoutField pUserLogout, RspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspUserLogin");
        }

        public void OnRspError(RspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspError");
        }

        public void OnRspSubMarketData(SpecificInstrumentField pSpecificInstrument, RspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspSubMarketData");
        }

        public void OnRspUnSubMarketData(SpecificInstrumentField pSpecificInstrument, RspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspUnSubMarketData");
        }

        public void OnRspSubForQuoteRsp(SpecificInstrumentField pSpecificInstrument, RspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspSubForQuoteRsp");
        }

        public void OnRspUnSubForQuoteRsp(SpecificInstrumentField pSpecificInstrument, RspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspUnSubForQuoteRsp");
        }

        public void OnRtnDepthMarketData(DepthMarketDataField pDepthMarketData)
        {
            if (pDepthMarketData != null)
            {
                Console.WriteLine("OnRtnDepthMarketData {0} {1} {2}", pDepthMarketData.InstrumentID,
                    pDepthMarketData.UpdateTime, pDepthMarketData.LastPrice);
            }
            else
            {
                Console.WriteLine("Empty market data");
            }
        }

        public void OnRtnForQuoteRsp(ForQuoteRspField pForQuoteRsp)
        {
            Console.WriteLine("OnRtnForQuoteRsp");
        }

        public bool IsReady
        {
            get { return _isReady; }
        }

        private bool _isReady = false;

        public bool IsConnected
        {
            get { return _isConnected; }
        }

        private bool _isConnected = false;
    }
}
