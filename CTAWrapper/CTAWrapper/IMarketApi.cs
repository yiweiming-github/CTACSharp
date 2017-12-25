using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTACSharp.CTP.Market;

namespace CTAWrapper
{
    public interface IMarketApi
    {
        //相当于CTP的RegisterSpi
        void RegisterCallback(IMarketCallbackApi callbackApi);

        string GetApiVersion();
        void Release();
        void Init();
        int Join();
        string GetTradingDay();
        void RegisterFront(string pszFrontAddress);
        void RegisterNameServer(string pszNsAddress);
        void RegisterFensUserInfo(CThostFtdcFensUserInfoField pFensUserInfo);
        void SubscribeMarketData(string[] instrumentIds, int count);
        void UnSubscribeMarketData(string[] instrumentIds, int count);
        int SubscribeForQuoteRsp(string[] instrumentIds, int nCount);
        int UnSubscribeForQuoteRsp(string[] instrumentIds, int nCount);
        int ReqUserLogin(CThostFtdcReqUserLoginField pReqUserLoginField, int nRequestID = 0);
        int ReqUserLogout(CThostFtdcUserLogoutField pUserLogout, int nRequestID = 0);
    }
}
