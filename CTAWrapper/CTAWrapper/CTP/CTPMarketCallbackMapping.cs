using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTAWrapper.Structs;

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
            if (pRspInfo != null)
            {
                var info = new RspInfoField()
                {
                    ErrorID = pRspInfo.ErrorID,
                    ErrorMsg = pRspInfo.ErrorMsg
                };
                _callbackApi.OnRspError(info, nRequestID, bIsLast);
            }
        }

        public override void OnRspUserLogin(CThostFtdcRspUserLoginField pRspUserLogin, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            if (pRspInfo != null && pRspUserLogin != null)
            {
                var userLoginField = new RspUserLoginField()
                {
                    CZCETime = pRspUserLogin.CZCETime,
                    DCETime = pRspUserLogin.DCETime,
                    SHFETime = pRspUserLogin.SHFETime,
                    MaxOrderRef = pRspUserLogin.MaxOrderRef,
                    SessionID = pRspUserLogin.SessionID,
                    FrontID = pRspUserLogin.FrontID,
                    SystemName = pRspUserLogin.SystemName,
                    UserID = pRspUserLogin.UserID,
                    BrokderID = pRspUserLogin.BrokerID,
                    LoginTime = pRspUserLogin.LoginTime,
                    TradingDay = pRspUserLogin.TradingDay,
                    FFEXTime = pRspUserLogin.FFEXTime,
                    INETime = pRspUserLogin.INETime
                };

                var info = new RspInfoField()
                {
                    ErrorID = pRspInfo.ErrorID,
                    ErrorMsg = pRspInfo.ErrorMsg
                };

                _callbackApi.OnRspUserLogin(userLoginField, info, nRequestID, bIsLast);
            }
        }

        public override void OnRspSubMarketData(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            if (pSpecificInstrument != null && pRspInfo != null)
            {
                var specificInstrumentField = new SpecificInstrumentField()
                {
                    InstrumentID = pSpecificInstrument.InstrumentID
                };

                var info = new RspInfoField()
                {
                    ErrorID = pRspInfo.ErrorID,
                    ErrorMsg = pRspInfo.ErrorMsg
                };
                _callbackApi.OnRspSubMarketData(specificInstrumentField, info, nRequestID, bIsLast);
            }
        }

        public override void OnRtnDepthMarketData(CThostFtdcDepthMarketDataField pDepthMarketData)
        {
            if (pDepthMarketData != null)
            {
                var depthMarketData = new DepthMarketDataField()
                {
                    BidVolume1 = pDepthMarketData.BidVolume1,
                    AskPrice1 = pDepthMarketData.AskPrice1,
                    AskVolume1 = pDepthMarketData.AskVolume1,
                    BidPrice2 = pDepthMarketData.BidPrice2,
                    BidVolume2 = pDepthMarketData.BidVolume2,
                    AskPrice2 = pDepthMarketData.AskPrice2,
                    AskVolume2 = pDepthMarketData.AskVolume2,
                    BidPrice3 = pDepthMarketData.BidPrice3,
                    BidVolume3 = pDepthMarketData.BidVolume3,
                    AskVolume3 = pDepthMarketData.AskVolume3,
                    BidPrice1 = pDepthMarketData.BidPrice1,
                    BidPrice4 = pDepthMarketData.BidPrice4,
                    BidVolume4 = pDepthMarketData.BidVolume4,
                    AskPrice4 = pDepthMarketData.AskPrice4,
                    AskVolume4 = pDepthMarketData.AskVolume4,
                    BidPrice5 = pDepthMarketData.BidPrice5,
                    BidVolume5 = pDepthMarketData.BidVolume5,
                    AskPrice5 = pDepthMarketData.AskPrice5,
                    AskVolume5 = pDepthMarketData.AskVolume5,
                    AskPrice3 = pDepthMarketData.AskPrice3,
                    UpdateMillisec = pDepthMarketData.UpdateMillisec,
                    CurrDelta = pDepthMarketData.CurrDelta,
                    AveragePrice = pDepthMarketData.AveragePrice,
                    TradingDay = pDepthMarketData.TradingDay,
                    InstrumentID = pDepthMarketData.InstrumentID,
                    ExchangeID = pDepthMarketData.ExchangeID,
                    ExchangeInstID = pDepthMarketData.ExchangeInstID,
                    LastPrice = pDepthMarketData.LastPrice,
                    PreSettlementPrice = pDepthMarketData.PreSettlementPrice,
                    PreClosePrice = pDepthMarketData.PreClosePrice,
                    PreOpenInterest = pDepthMarketData.PreOpenInterest,
                    UpdateTime = pDepthMarketData.UpdateTime,
                    OpenPrice = pDepthMarketData.OpenPrice,
                    LowestPrice = pDepthMarketData.LowestPrice,
                    Volume = pDepthMarketData.Volume,
                    Turnover = pDepthMarketData.Turnover,
                    OpenInterest = pDepthMarketData.OpenInterest,
                    ClosePrice = pDepthMarketData.ClosePrice,
                    SettlementPrice = pDepthMarketData.SettlementPrice,
                    UpperLimitPrice = pDepthMarketData.UpperLimitPrice,
                    LowerLimitPrice = pDepthMarketData.LowerLimitPrice,
                    PreDelta = pDepthMarketData.PreDelta,
                    HighestPrice = pDepthMarketData.HighestPrice,
                    ActionDay = pDepthMarketData.ActionDay
                };
                _callbackApi.OnRtnDepthMarketData(depthMarketData);
            }
        }

        public override void OnRspSubForQuoteRsp(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            if (pSpecificInstrument != null && pRspInfo != null)
            {
                var specificInstrumentField = new SpecificInstrumentField()
                {
                    InstrumentID = pSpecificInstrument.InstrumentID
                };

                var info = new RspInfoField()
                {
                    ErrorID = pRspInfo.ErrorID,
                    ErrorMsg = pRspInfo.ErrorMsg
                };

                _callbackApi.OnRspSubForQuoteRsp(specificInstrumentField, info, nRequestID, bIsLast);
            }
        }

        public override void OnRspUnSubForQuoteRsp(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            if (pSpecificInstrument != null && pRspInfo != null)
            {
                var specificInstrument = new SpecificInstrumentField()
                {
                    InstrumentID = pSpecificInstrument.InstrumentID
                };

                var info = new RspInfoField()
                {
                    ErrorID = pRspInfo.ErrorID,
                    ErrorMsg = pRspInfo.ErrorMsg
                };

                _callbackApi.OnRspUnSubForQuoteRsp(specificInstrument, info, nRequestID, bIsLast);
            }
        }

        public override void OnRspUnSubMarketData(CThostFtdcSpecificInstrumentField pSpecificInstrument, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            if (pSpecificInstrument != null && pRspInfo != null)
            {
                var specificInstrument = new SpecificInstrumentField()
                {
                    InstrumentID = pSpecificInstrument.InstrumentID
                };

                var info = new RspInfoField()
                {
                    ErrorID = pRspInfo.ErrorID,
                    ErrorMsg = pRspInfo.ErrorMsg
                };

                _callbackApi.OnRspUnSubMarketData(specificInstrument, info, nRequestID, bIsLast);
            }
        }

        public override void OnRspUserLogout(CThostFtdcUserLogoutField pUserLogout, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            if (pUserLogout != null && pRspInfo != null)
            {
                var userLogout = new UserLogoutField()
                {
                    BrokerID = pUserLogout.BrokerID,
                    UserID = pUserLogout.UserID
                };

                var info = new RspInfoField()
                {
                    ErrorID = pRspInfo.ErrorID,
                    ErrorMsg = pRspInfo.ErrorMsg
                };

                _callbackApi.OnRspUserLogout(userLogout, info, nRequestID, bIsLast);
            }
        }

        public override void OnRtnForQuoteRsp(CThostFtdcForQuoteRspField pForQuoteRsp)
        {
            if (pForQuoteRsp != null)
            {
                var quoteRsp = new ForQuoteRspField()
                {
                    TradingDay = pForQuoteRsp.TradingDay,
                    InstrumentID = pForQuoteRsp.InstrumentID,
                    ForQuoteSysID = pForQuoteRsp.ForQuoteSysID,
                    ForQuoteTime = pForQuoteRsp.ForQuoteTime,
                    ActionDay = pForQuoteRsp.ActionDay,
                    ExchangeID = pForQuoteRsp.ExchangeID
                };

                _callbackApi.OnRtnForQuoteRsp(quoteRsp);
            }
        }

        private IMarketCallbackApi _callbackApi;
    }
}
