using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTACSharp.CTP.Market;

namespace CTAWrapper.Esunny
{
    public class EsunnyMarketApi : IMarketApi
    {
        public EsunnyMarketApi(ITapQuoteAPI tapApi)
        {
            _tapApi = tapApi;
        }

        public void RegisterCallback(IMarketCallbackApi callbackApi)
        {
            _callbackApi = callbackApi;
            var mapping = new EsunnyMarketCallbackMapping();
            mapping.SetCallbackImpl(callbackApi);
            _tapApi.SetAPINotify(mapping);
        }

        public string GetApiVersion()
        {
            return "Not Implemented";
        }

        public void Release()
        {
            _tapApi.Disconnect();
        }

        //易盛没有Init函数，直接回调连接成功事件
        public void Init()
        {
            _callbackApi.OnFrontConnected();
        }

        //ESunny not supported
        public int Join()
        {
            return 0;
        }

        //ESunny not supported
        public string GetTradingDay()
        {
            return null;
        }

        public void RegisterFront(string pszFrontAddress)
        {
            var ipAndPort = SplitIpAndPort(pszFrontAddress);
            _tapApi.SetHostAddress(ipAndPort.Item1, ipAndPort.Item2);
        }

        //ESunny not supported
        public void RegisterNameServer(string pszNsAddress)
        {
        }

        //ESunny not supported
        public void RegisterFensUserInfo(CThostFtdcFensUserInfoField pFensUserInfo)
        {
        }

        public void SubscribeMarketData(string[] instrumentIds, int count)
        {
            foreach (var instrumentId in instrumentIds)
            {
                var contractInfo = createContractInfo(instrumentId);
                if (contractInfo != null)
                {
                    _tapApi.SubscribeQuote(ref _sessionID, contractInfo);
                }
            }
        }

        public void UnSubscribeMarketData(string[] instrumentIds, int count)
        {
            foreach (var instrumentId in instrumentIds)
            {
                var contractInfo = createContractInfo(instrumentId);
                if (contractInfo != null)
                {
                    _tapApi.UnSubscribeQuote(ref _sessionID, contractInfo);
                }
            }
        }

        //ESunny not supported
        public int SubscribeForQuoteRsp(string[] instrumentIds, int nCount)
        {
            return 0;
        }

        //ESunny not supported
        public int UnSubscribeForQuoteRsp(string[] instrumentIds, int nCount)
        {
            return 0;
        }

        public int ReqUserLogin(CThostFtdcReqUserLoginField pReqUserLoginField, int nRequestID = 0)
        {
            var loginAuth = new TapAPIQuoteLoginAuth()
            {
                UserNo = pReqUserLoginField.UserID,
                Password = pReqUserLoginField.Password,
                ISModifyPassword = 'N',
                ISDDA = 'N'
            };
            return _tapApi.Login(loginAuth);
        }

        //ESunny not supported
        public int ReqUserLogout(CThostFtdcUserLogoutField pUserLogout, int nRequestID = 0)
        {
            return 0;
        }

        private Tuple<string, ushort> SplitIpAndPort(string address)
        {
            //var parts = address.Split(new string[] {"://"}, StringSplitOptions.RemoveEmptyEntries);
            //var addressWithOutProtocol = parts.Length > 0 ? parts[1] : parts[0];
            //parts = addressWithOutProtocol.Split(new char[] {':'}, StringSplitOptions.RemoveEmptyEntries);
            //if 
            return new Tuple<string, ushort>("222.88.40.170", 6161);
        }

        private TapAPIContract createContractInfo(string code)
        {
            return new TapAPIContract()
            {
                Commodity =
                {
                    ExchangeNo = "CFFEX",
                    CommodityType = 'F',
                    CommodityNo = "IF"
                },
                ContractNo1 = "1801",
                CallOrPutFlag1 = 'N',
                CallOrPutFlag2 = 'N'
            };
        }

        private IMarketCallbackApi _callbackApi;
        private ITapQuoteAPI _tapApi;
        private uint _sessionID;
    }
}
