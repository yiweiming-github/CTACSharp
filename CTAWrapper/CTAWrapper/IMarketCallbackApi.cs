using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTACSharp.CTP.Market;

namespace CTAWrapper
{
    public interface IMarketCallbackApi
    {
        void OnFrontConnected();
        void OnFrontDisconnected(int nReason);
        void OnHeartBeatWarning(int nTimeLapse);
        void OnRspUserLogin(CThostFtdcRspUserLoginField pRspUserLogin, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        void OnRspUserLogout(CThostFtdcUserLogoutField pUserLogout, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        void OnRspError(CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        void OnRspSubMarketData(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        void OnRspUnSubMarketData(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        void OnRspSubForQuoteRsp(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        void OnRspUnSubForQuoteRsp(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast);
        void OnRtnDepthMarketData(CThostFtdcDepthMarketDataField pDepthMarketData);
        void OnRtnForQuoteRsp(CThostFtdcForQuoteRspField pForQuoteRsp);

        //易盛独有
        void OnApiReady();
    }
}
