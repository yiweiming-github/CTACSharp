using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTAWrapper.Structs;

namespace CTAWrapper
{
    public interface IMarketCallbackApi
    {
        void OnFrontConnected();
        void OnFrontDisconnected(int nReason);
        void OnHeartBeatWarning(int nTimeLapse);
        void OnRspUserLogin(RspUserLoginField pRspUserLogin, RspInfoField pRspInfo, int nRequestID, bool bIsLast);
        void OnRspUserLogout(UserLogoutField pUserLogout, RspInfoField pRspInfo, int nRequestID, bool bIsLast);
        void OnRspError(RspInfoField pRspInfo, int nRequestID, bool bIsLast);
        void OnRspSubMarketData(SpecificInstrumentField pSpecificInstrument, RspInfoField pRspInfo, int nRequestID, bool bIsLast);
        void OnRspUnSubMarketData(SpecificInstrumentField pSpecificInstrument, RspInfoField pRspInfo, int nRequestID, bool bIsLast);
        void OnRspSubForQuoteRsp(SpecificInstrumentField pSpecificInstrument, RspInfoField pRspInfo, int nRequestID, bool bIsLast);
        void OnRspUnSubForQuoteRsp(SpecificInstrumentField pSpecificInstrument, RspInfoField pRspInfo, int nRequestID, bool bIsLast);
        void OnRtnDepthMarketData(DepthMarketDataField pDepthMarketData);
        void OnRtnForQuoteRsp(ForQuoteRspField pForQuoteRsp);

        //易盛独有
        void OnApiReady();
    }
}
