using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTACSharp.CTP.Market;

namespace CTPMarketTest
{
    class CTPMarketCallbackImpl : CThostFtdcMdSpi
    {
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

        public override void OnFrontConnected()
        {
            Console.WriteLine("OnFrontConnected");
            _isConnected = true;
        }

        public override void OnRspUserLogin(CThostFtdcRspUserLoginField pRspUserLogin, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            Console.WriteLine("OnRspUserLogin");
            _isReady = true;
        }

        public override void OnRspError(CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspError");
        }

        public override void OnRspSubMarketData(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            if (pRspInfo.ErrorID != 0)
            {
                Console.WriteLine("OnRspSubMarketData Error: {0}", pRspInfo.ErrorMsg);
            }
            else
            {
                Console.WriteLine("OnRspSubMarketData");
            }
        }

        public override void OnRtnDepthMarketData(CThostFtdcDepthMarketDataField pDepthMarketData)
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

        public override void OnFrontDisconnected(int nReason)
        {
            Console.WriteLine("OnFrontDisconnected reason: {0}", nReason);
        }

        public override void OnRspUserLogout(CThostFtdcUserLogoutField pUserLogout, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            Console.WriteLine("OnRspUserLogout");
        }
    }
}
