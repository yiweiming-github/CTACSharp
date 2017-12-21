using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTAWrapper.Structs;

namespace CTAWrapper.Esunny
{
    public class EsunnyMarketCallbackMapping : ITapQuoteAPINotify, IMarketCallbackMapping
    {
        public void SetCallbackImpl(IMarketCallbackApi callbackApi)
        {
            _callbackApi = callbackApi;
        }

        public override void OnRspLogin(int errorCode, TapAPIQuotLoginRspInfo info)
        {
            var rspLoginField = new RspUserLoginField()
            {
                TradingDay = info.TradeDate,
                LoginTime = info.StartTime,
                BrokderID = "",
                UserID = info.UserNo,
                SystemName = "esunny",
                FrontID = 0,
                SessionID = 0
            };

            var rspInfoField = new RspInfoField()
            {
                ErrorID = errorCode
            };

            _callbackApi.OnRspUserLogin(rspLoginField, rspInfoField, 0, true);
        }

        public override void OnAPIReady()
        {
            _callbackApi.OnApiReady();
        }

        public override void OnDisconnect(int reasonCode)
        {
            _callbackApi.OnFrontDisconnected(reasonCode);
        }

        public override void OnRspSubscribeQuote(uint sessionID, int errorCode, char isLast, TapAPIQuoteWhole info)
        {
            var field = new SpecificInstrumentField()
            {
                InstrumentID = info.Contract.Commodity.CommodityNo + info.Contract.ContractNo1
            };

            var rspInfoField = new RspInfoField()
            {
                ErrorID = errorCode
            };
            _callbackApi.OnRspSubMarketData(field, rspInfoField, 0, true);
        }

        public override void OnRspUnSubscribeQuote(uint sessionID, int errorCode, char isLast, TapAPIContract info)
        {
            var field = new SpecificInstrumentField()
            {
                InstrumentID = info.Commodity.CommodityNo + info.ContractNo1
            };

            var rspInfoField = new RspInfoField()
            {
                ErrorID = errorCode
            };

            _callbackApi.OnRspUnSubMarketData(field, rspInfoField, 0, true);
        }

        public override void OnRtnQuote(TapAPIQuoteWhole info)
        {
            if (info != null)
            {
                var field = new DepthMarketDataField()
                {
                    TradingDay = "",
                    InstrumentID = info.Contract.Commodity.CommodityNo + info.Contract.ContractNo1,
                    ExchangeID = info.Contract.Commodity.ExchangeNo,
                    ExchangeInstID = "",
                    LastPrice = info.QLastPrice,
                    Volume = (int)info.QLastQty
                };
                _callbackApi.OnRtnDepthMarketData(field);
            }
        }

        public override void OnRspQryCommodity(uint sessionID, int errorCode, char isLast, TapAPIQuoteCommodityInfo info)
        {
            
        }

        public override void OnRspQryContract(uint sessionID, int errorCode, char isLast, TapAPIQuoteContractInfo info)
        {
            
        }

        private IMarketCallbackApi _callbackApi;
    }
}
