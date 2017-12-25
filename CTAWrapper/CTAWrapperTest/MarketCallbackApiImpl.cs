using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTACSharp.CTP.Market;
using CTAWrapper;

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

        public void OnRspUserLogin(CThostFtdcRspUserLoginField pRspUserLogin, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            if (pRspInfo.ErrorID != 0)
            {
                Console.WriteLine("OnRspUserLogin Error: {0}", pRspInfo.ErrorMsg);
            }
            else
            {
                Console.WriteLine("OnRspUserLogin");
                _isReady = _isConnected;
            }
        }

        //易盛有这个callback
        public void OnApiReady()
        {
            _isReady = true;
        }

        public void OnRspUserLogout(CThostFtdcUserLogoutField pUserLogout, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspUserLogin");
        }

        public void OnRspError(CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspError");
        }

        public void OnRspSubMarketData(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspSubMarketData");
        }

        public void OnRspUnSubMarketData(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspUnSubMarketData");
        }

        public void OnRspSubForQuoteRsp(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspSubForQuoteRsp");
        }

        public void OnRspUnSubForQuoteRsp(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspUnSubForQuoteRsp");
        }

        public void OnRtnDepthMarketData(CThostFtdcDepthMarketDataField pDepthMarketData)
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

        public void OnRtnForQuoteRsp(CThostFtdcForQuoteRspField pForQuoteRsp)
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
