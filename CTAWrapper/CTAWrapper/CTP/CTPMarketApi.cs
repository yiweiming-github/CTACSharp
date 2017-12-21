using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTAWrapper.Esunny;
using CTAWrapper.Structs;

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
            return "Not Implemented";
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
        
        public void RegisterFensUserInfo(FensUserInfoField pFensUserInfo)
        {
            var fensUserInfo = new CThostFtdcFensUserInfoField()
            {
                BrokerID = pFensUserInfo.BrokerID,
                UserID = pFensUserInfo.UserID,
                LoginMode = pFensUserInfo.LoginMode
            };
            _mdApi.RegisterFensUserInfo(fensUserInfo);
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

        public int ReqUserLogin(ReqUserLoginField pReqUserLoginField, int nRequestID = 0)
        {
            var userLoginField = new CThostFtdcReqUserLoginField()
            {
                TradingDay = pReqUserLoginField.TradingDay,
                BrokerID = pReqUserLoginField.BrokerID,
                UserID = pReqUserLoginField.UserID,
                Password = pReqUserLoginField.Password,
                UserProductInfo = pReqUserLoginField.UserProductInfo,
                InterfaceProductInfo = pReqUserLoginField.InterfaceProductInfo,
                ProtocolInfo = pReqUserLoginField.ProtocolInfo,
                MacAddress = pReqUserLoginField.MacAddress,
                OneTimePassword = pReqUserLoginField.OneTimePassword,
                ClientIPAddress = pReqUserLoginField.ClientIPAddress
            };
            return _mdApi.ReqUserLogin(userLoginField, nRequestID);
        }

        
        public int ReqUserLogout(UserLogoutField pUserLogout, int nRequestID = 0)
        {
            var userLogoutField = new CThostFtdcUserLogoutField()
            {
                BrokerID = pUserLogout.BrokerID,
                UserID = pUserLogout.UserID
            };
            return _mdApi.ReqUserLogout(userLogoutField, nRequestID);
        }
        
        private CThostFtdcMdApi _mdApi;
        private uint _sessionID;
    }
}
