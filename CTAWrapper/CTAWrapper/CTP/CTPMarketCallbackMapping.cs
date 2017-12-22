using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTAWrapper.CTP
{
    public class CTPMarketCallbackMapping : CThostFtdcMdSpi, IMarketCallbackMapping
    {
        public void SetCallbackImpl(IMarketCallbackApi callbackApi)
        {
            _callbackApi = callbackApi;
        }

        public override void OnFrontConnected()
        {
            _callbackApi.OnFrontConnected();
        }

        public override void OnFrontDisconnected(int nReason)
        {
            _callbackApi.OnFrontDisconnected(nReason);
        }

        public override void OnHeartBeatWarning(int nTimeLapse)
        {
            _callbackApi.OnHeartBeatWarning(nTimeLapse);
        }

        public override void OnRspError(CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspError(pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspUserLogin(CThostFtdcRspUserLoginField pRspUserLogin, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            _callbackApi.OnRspUserLogin(pRspUserLogin, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspSubMarketData(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspSubMarketData(pSpecificInstrument, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRtnDepthMarketData(CThostFtdcDepthMarketDataField pDepthMarketData)
        {
            _callbackApi.OnRtnDepthMarketData(pDepthMarketData);
        }

        public override void OnRspSubForQuoteRsp(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspSubForQuoteRsp(pSpecificInstrument, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspUnSubForQuoteRsp(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
           _callbackApi.OnRspUnSubForQuoteRsp(pSpecificInstrument, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspUnSubMarketData(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspUnSubMarketData(pSpecificInstrument, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspUserLogout(CThostFtdcUserLogoutField pUserLogout, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            _callbackApi.OnRspUserLogout(pUserLogout, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRtnForQuoteRsp(CThostFtdcForQuoteRspField pForQuoteRsp)
        {
            _callbackApi.OnRtnForQuoteRsp(pForQuoteRsp);
        }

        private IMarketCallbackApi _callbackApi;
    }
}
