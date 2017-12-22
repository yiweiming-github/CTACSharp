using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTAWrapper.Esunny;

namespace CTAWrapper.CTP
{
    public class CTPMarketApi : IMarketApi
    {
        public CTPMarketApi(CThostFtdcMdApi mdApi)
        {
            _mdApi = mdApi;
        }

        public void RegisterCallbackMapping(IMarketCallbackApi callbackApi)
        {
            var mapping = new CTPMarketCallbackMapping();
            mapping.SetCallbackImpl(callbackApi);
            _mdApi.RegisterSpi(mapping);
        }

        public string GetApiVersion()
        {
            return CThostFtdcMdApi.GetApiVersion();
        }

        public void Release()
        {
            _mdApi.Release();
        }

        public void Init()
        {
            _mdApi.Init();
        }

        public int Join()
        {
            return _mdApi.Join();
        }
        
        public string GetTradingDay()
        {
            return _mdApi.GetTradingDay();
        }

        public void RegisterFront(string pszFrontAddress)
        {
            _mdApi.RegisterFront(pszFrontAddress);
        }
        
        public void RegisterNameServer(string pszNsAddress)
        {
            _mdApi.RegisterNameServer(pszNsAddress);
        }
        
        public void RegisterFensUserInfo(CThostFtdcFensUserInfoField pFensUserInfo)
        {
            _mdApi.RegisterFensUserInfo(pFensUserInfo);
        }

        public void SubscribeMarketData(string[] instrumentIds, int count)
        {
            _mdApi.SubscribeMarketData(instrumentIds, count);
        }

        public void UnSubscribeMarketData(string[] instrumentIds, int count)
        {
            _mdApi.UnSubscribeMarketData(instrumentIds, count);
        }
        
        public int SubscribeForQuoteRsp(string[] instrumentIds, int nCount)
        {
            return _mdApi.SubscribeForQuoteRsp(instrumentIds, nCount);
        }
        
        public int UnSubscribeForQuoteRsp(string[] instrumentIds, int nCount)
        {
            return _mdApi.UnSubscribeForQuoteRsp(instrumentIds, nCount);
        }

        public int ReqUserLogin(CThostFtdcReqUserLoginField pReqUserLoginField, int nRequestID = 0)
        {
            return _mdApi.ReqUserLogin(pReqUserLoginField, nRequestID);
        }

        
        public int ReqUserLogout(CThostFtdcUserLogoutField pUserLogout, int nRequestID = 0)
        {
            return _mdApi.ReqUserLogout(pUserLogout, nRequestID);
        }
        
        private CThostFtdcMdApi _mdApi;
        private uint _sessionID;
    }
}
