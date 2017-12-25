using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTACSharp.CTP.Trade;

namespace CTAWrapper.CTP
{
    public class CTPTradeApi : ITradeApi
    {
        public CTPTradeApi(CThostFtdcTraderApi traderApi)
        {
            _traderApi = traderApi;
        }

        public void RegisterCallback(ITradeCallbackApi callbackApi)
        {
            var mapping = new CTPTradeCallbackMapping();
            mapping.SetCallbackImpl(callbackApi);
            _traderApi.RegisterSpi(mapping);
        }

        public string GetApiVersion()
        {
            return CThostFtdcTraderApi.GetApiVersion();
        }

        public void Release()
        {
            _traderApi.Release();
        }

        public void Init()
        {
            _traderApi.Init();
        }

        public int Join()
        {
            return _traderApi.Join();
        }

        public string GetTradingDay()
        {
            return _traderApi.GetTradingDay();
        }

        public void RegisterFront(string pszFrontAddress)
        {
            _traderApi.RegisterFront(pszFrontAddress);
        }

        public void RegisterNameServer(string pszNsAddress)
        {
            _traderApi.RegisterNameServer(pszNsAddress);
        }

        public void RegisterFensUserInfo(CThostFtdcFensUserInfoField pFensUserInfo)
        {
            _traderApi.RegisterFensUserInfo(pFensUserInfo);
        }

        public void SubscribePrivateTopic(THOST_TE_RESUME_TYPE nResumeType)
        {
            _traderApi.SubscribePrivateTopic(nResumeType);
        }

        public void SubscribePublicTopic(THOST_TE_RESUME_TYPE nResumeType)
        {
            _traderApi.SubscribePublicTopic(nResumeType);
        }

        public int ReqAuthenticate(CThostFtdcReqAuthenticateField pReqAuthenticateField, int nRequestID)
        {
            return _traderApi.ReqAuthenticate(pReqAuthenticateField, nRequestID);
        }

        public int ReqUserLogin(CThostFtdcReqUserLoginField pReqUserLoginField, int nRequestID)
        {
            return _traderApi.ReqUserLogin(pReqUserLoginField, nRequestID);
        }

        public int ReqUserLogout(CThostFtdcUserLogoutField pUserLogout, int nRequestID)
        {
            return _traderApi.ReqUserLogout(pUserLogout, nRequestID);
        }

        public int ReqUserPasswordUpdate(CThostFtdcUserPasswordUpdateField pUserPasswordUpdate, int nRequestID)
        {
            return _traderApi.ReqUserPasswordUpdate(pUserPasswordUpdate, nRequestID);
        }

        public int ReqTradingAccountPasswordUpdate(
            CThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate,
            int nRequestID)
        {
            return _traderApi.ReqTradingAccountPasswordUpdate(pTradingAccountPasswordUpdate, nRequestID);
        }

        public int ReqOrderInsert(CThostFtdcInputOrderField pInputOrder, int nRequestID)
        {
            return _traderApi.ReqOrderInsert(pInputOrder, nRequestID);
        }

        public int ReqParkedOrderInsert(CThostFtdcParkedOrderField pParkedOrder, int nRequestID)
        {
            return _traderApi.ReqParkedOrderInsert(pParkedOrder, nRequestID);
        }

        public int ReqParkedOrderAction(CThostFtdcParkedOrderActionField pParkedOrderAction, int nRequestID)
        {
            return _traderApi.ReqParkedOrderAction(pParkedOrderAction, nRequestID);
        }

        public int ReqOrderAction(CThostFtdcInputOrderActionField pInputOrderAction, int nRequestID)
        {
            return _traderApi.ReqOrderAction(pInputOrderAction, nRequestID);
        }

        public int ReqQueryMaxOrderVolume(CThostFtdcQueryMaxOrderVolumeField pQueryMaxOrderVolume, int nRequestID)
        {
            return _traderApi.ReqQueryMaxOrderVolume(pQueryMaxOrderVolume, nRequestID);
        }

        public int ReqSettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm, int nRequestID)
        {
            return _traderApi.ReqSettlementInfoConfirm(pSettlementInfoConfirm, nRequestID);
        }

        public int ReqRemoveParkedOrder(CThostFtdcRemoveParkedOrderField pRemoveParkedOrder, int nRequestID)
        {
            return _traderApi.ReqRemoveParkedOrder(pRemoveParkedOrder, nRequestID);
        }

        public int ReqRemoveParkedOrderAction(CThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction,
            int nRequestID)
        {
            return _traderApi.ReqRemoveParkedOrderAction(pRemoveParkedOrderAction, nRequestID);
        }

        public int ReqExecOrderInsert(CThostFtdcInputExecOrderField pInputExecOrder, int nRequestID)
        {
            return _traderApi.ReqExecOrderInsert(pInputExecOrder, nRequestID);
        }

        public int ReqExecOrderAction(CThostFtdcInputExecOrderActionField pInputExecOrderAction, int nRequestID)
        {
            return _traderApi.ReqExecOrderAction(pInputExecOrderAction, nRequestID);
        }

        public int ReqForQuoteInsert(CThostFtdcInputForQuoteField pInputForQuote, int nRequestID)
        {
            return _traderApi.ReqForQuoteInsert(pInputForQuote, nRequestID);
        }

        public int ReqQuoteInsert(CThostFtdcInputQuoteField pInputQuote, int nRequestID)
        {
            return _traderApi.ReqQuoteInsert(pInputQuote, nRequestID);
        }

        public int ReqQuoteAction(CThostFtdcInputQuoteActionField pInputQuoteAction, int nRequestID)
        {
            return _traderApi.ReqQuoteAction(pInputQuoteAction, nRequestID);
        }

        public int ReqCombActionInsert(CThostFtdcInputCombActionField pInputCombAction, int nRequestID)
        {
            return _traderApi.ReqCombActionInsert(pInputCombAction, nRequestID);
        }

        public int ReqQryOrder(CThostFtdcQryOrderField pQryOrder, int nRequestID)
        {
            return _traderApi.ReqQryOrder(pQryOrder, nRequestID);
        }

        public int ReqQryTrade(CThostFtdcQryTradeField pQryTrade, int nRequestID)
        {
            return _traderApi.ReqQryTrade(pQryTrade, nRequestID);
        }

        public int ReqQryInvestorPosition(CThostFtdcQryInvestorPositionField pQryInvestorPosition, int nRequestID)
        {
            return _traderApi.ReqQryInvestorPosition(pQryInvestorPosition, nRequestID);
        }

        public int ReqQryTradingAccount(CThostFtdcQryTradingAccountField pQryTradingAccount, int nRequestID)
        {
            return _traderApi.ReqQryTradingAccount(pQryTradingAccount, nRequestID);
        }

        public int ReqQryInvestor(CThostFtdcQryInvestorField pQryInvestor, int nRequestID)
        {
            return _traderApi.ReqQryInvestor(pQryInvestor, nRequestID);
        }

        public int ReqQryTradingCode(CThostFtdcQryTradingCodeField pQryTradingCode, int nRequestID)
        {
            return _traderApi.ReqQryTradingCode(pQryTradingCode, nRequestID);
        }

        public int ReqQryInstrumentMarginRate(CThostFtdcQryInstrumentMarginRateField pQryInstrumentMarginRate,
            int nRequestID)
        {
            return _traderApi.ReqQryInstrumentMarginRate(pQryInstrumentMarginRate, nRequestID);
        }

        public int ReqQryInstrumentCommissionRate(
            CThostFtdcQryInstrumentCommissionRateField pQryInstrumentCommissionRate, int nRequestID)
        {
            return _traderApi.ReqQryInstrumentCommissionRate(pQryInstrumentCommissionRate, nRequestID);
        }

        public int ReqQryExchange(CThostFtdcQryExchangeField pQryExchange, int nRequestID)
        {
            return _traderApi.ReqQryExchange(pQryExchange, nRequestID);
        }

        public int ReqQryProduct(CThostFtdcQryProductField pQryProduct, int nRequestID)
        {
            return _traderApi.ReqQryProduct(pQryProduct, nRequestID);
        }

        public int ReqQryInstrument(CThostFtdcQryInstrumentField pQryInstrument, int nRequestID)
        {
            return _traderApi.ReqQryInstrument(pQryInstrument, nRequestID);
        }

        public int ReqQryDepthMarketData(CThostFtdcQryDepthMarketDataField pQryDepthMarketData, int nRequestID)
        {
            return _traderApi.ReqQryDepthMarketData(pQryDepthMarketData, nRequestID);
        }

        public int ReqQrySettlementInfo(CThostFtdcQrySettlementInfoField pQrySettlementInfo, int nRequestID)
        {
            return _traderApi.ReqQrySettlementInfo(pQrySettlementInfo, nRequestID);
        }

        public int ReqQryTransferBank(CThostFtdcQryTransferBankField pQryTransferBank, int nRequestID)
        {
            return _traderApi.ReqQryTransferBank(pQryTransferBank, nRequestID);
        }

        public int ReqQryInvestorPositionDetail(CThostFtdcQryInvestorPositionDetailField pQryInvestorPositionDetail,
            int nRequestID)
        {
            return _traderApi.ReqQryInvestorPositionDetail(pQryInvestorPositionDetail, nRequestID);
        }

        public int ReqQryNotice(CThostFtdcQryNoticeField pQryNotice, int nRequestID)
        {
            return _traderApi.ReqQryNotice(pQryNotice, nRequestID);
        }

        public int ReqQrySettlementInfoConfirm(CThostFtdcQrySettlementInfoConfirmField pQrySettlementInfoConfirm,
            int nRequestID)
        {
            return _traderApi.ReqQrySettlementInfoConfirm(pQrySettlementInfoConfirm, nRequestID);
        }

        public int ReqQryInvestorPositionCombineDetail(
            CThostFtdcQryInvestorPositionCombineDetailField pQryInvestorPositionCombineDetail, int nRequestID)
        {
            return _traderApi.ReqQryInvestorPositionCombineDetail(pQryInvestorPositionCombineDetail, nRequestID);
        }

        public int ReqQryCFMMCTradingAccountKey(CThostFtdcQryCFMMCTradingAccountKeyField pQryCFMMCTradingAccountKey,
            int nRequestID)
        {
            return _traderApi.ReqQryCFMMCTradingAccountKey(pQryCFMMCTradingAccountKey, nRequestID);
        }

        public int ReqQryEWarrantOffset(CThostFtdcQryEWarrantOffsetField pQryEWarrantOffset, int nRequestID)
        {
            return _traderApi.ReqQryEWarrantOffset(pQryEWarrantOffset, nRequestID);
        }

        public int ReqQryInvestorProductGroupMargin(
            CThostFtdcQryInvestorProductGroupMarginField pQryInvestorProductGroupMargin, int nRequestID)
        {
            return _traderApi.ReqQryInvestorProductGroupMargin(pQryInvestorProductGroupMargin, nRequestID);
        }

        public int ReqQryExchangeMarginRate(CThostFtdcQryExchangeMarginRateField pQryExchangeMarginRate, int nRequestID)
        {
            return _traderApi.ReqQryExchangeMarginRate(pQryExchangeMarginRate, nRequestID);
        }

        public int ReqQryExchangeMarginRateAdjust(
            CThostFtdcQryExchangeMarginRateAdjustField pQryExchangeMarginRateAdjust,
            int nRequestID)
        {
            return _traderApi.ReqQryExchangeMarginRateAdjust(pQryExchangeMarginRateAdjust, nRequestID);
        }

        public int ReqQryExchangeRate(CThostFtdcQryExchangeRateField pQryExchangeRate, int nRequestID)
        {
            return _traderApi.ReqQryExchangeRate(pQryExchangeRate, nRequestID);
        }

        public int ReqQrySecAgentACIDMap(CThostFtdcQrySecAgentACIDMapField pQrySecAgentACIDMap, int nRequestID)
        {
            return _traderApi.ReqQrySecAgentACIDMap(pQrySecAgentACIDMap, nRequestID);
        }

        public int ReqQryProductExchRate(CThostFtdcQryProductExchRateField pQryProductExchRate, int nRequestID)
        {
            return _traderApi.ReqQryProductExchRate(pQryProductExchRate, nRequestID);
        }

        public int ReqQryOptionInstrTradeCost(CThostFtdcQryOptionInstrTradeCostField pQryOptionInstrTradeCost,
            int nRequestID)
        {
            return _traderApi.ReqQryOptionInstrTradeCost(pQryOptionInstrTradeCost, nRequestID);
        }

        public int ReqQryOptionInstrCommRate(CThostFtdcQryOptionInstrCommRateField pQryOptionInstrCommRate,
            int nRequestID)
        {
            return _traderApi.ReqQryOptionInstrCommRate(pQryOptionInstrCommRate, nRequestID);
        }

        public int ReqQryExecOrder(CThostFtdcQryExecOrderField pQryExecOrder, int nRequestID)
        {
            return _traderApi.ReqQryExecOrder(pQryExecOrder, nRequestID);
        }

        public int ReqQryForQuote(CThostFtdcQryForQuoteField pQryForQuote, int nRequestID)
        {
            return _traderApi.ReqQryForQuote(pQryForQuote, nRequestID);
        }

        public int ReqQryQuote(CThostFtdcQryQuoteField pQryQuote, int nRequestID)
        {
            return _traderApi.ReqQryQuote(pQryQuote, nRequestID);
        }

        public int ReqQryCombInstrumentGuard(CThostFtdcQryCombInstrumentGuardField pQryCombInstrumentGuard,
            int nRequestID)
        {
            return _traderApi.ReqQryCombInstrumentGuard(pQryCombInstrumentGuard, nRequestID);
        }

        public int ReqQryCombAction(CThostFtdcQryCombActionField pQryCombAction, int nRequestID)
        {
            return _traderApi.ReqQryCombAction(pQryCombAction, nRequestID);
        }

        public int ReqQryTransferSerial(CThostFtdcQryTransferSerialField pQryTransferSerial, int nRequestID)
        {
            return _traderApi.ReqQryTransferSerial(pQryTransferSerial, nRequestID);
        }

        public int ReqQryAccountregister(CThostFtdcQryAccountregisterField pQryAccountregister, int nRequestID)
        {
            return _traderApi.ReqQryAccountregister(pQryAccountregister, nRequestID);
        }

        public int ReqQryContractBank(CThostFtdcQryContractBankField pQryContractBank, int nRequestID)
        {
            return _traderApi.ReqQryContractBank(pQryContractBank, nRequestID);
        }

        public int ReqQryParkedOrder(CThostFtdcQryParkedOrderField pQryParkedOrder, int nRequestID)
        {
            return _traderApi.ReqQryParkedOrder(pQryParkedOrder, nRequestID);
        }

        public int ReqQryParkedOrderAction(CThostFtdcQryParkedOrderActionField pQryParkedOrderAction, int nRequestID)
        {
            return _traderApi.ReqQryParkedOrderAction(pQryParkedOrderAction, nRequestID);
        }

        public int ReqQryTradingNotice(CThostFtdcQryTradingNoticeField pQryTradingNotice, int nRequestID)
        {
            return _traderApi.ReqQryTradingNotice(pQryTradingNotice, nRequestID);
        }

        public int ReqQryBrokerTradingParams(CThostFtdcQryBrokerTradingParamsField pQryBrokerTradingParams,
            int nRequestID)
        {
            return _traderApi.ReqQryBrokerTradingParams(pQryBrokerTradingParams, nRequestID);
        }

        public int ReqQryBrokerTradingAlgos(CThostFtdcQryBrokerTradingAlgosField pQryBrokerTradingAlgos, int nRequestID)
        {
            return _traderApi.ReqQryBrokerTradingAlgos(pQryBrokerTradingAlgos, nRequestID);
        }

        public int ReqQueryCFMMCTradingAccountToken(
            CThostFtdcQueryCFMMCTradingAccountTokenField pQueryCFMMCTradingAccountToken, int nRequestID)
        {
            return _traderApi.ReqQueryCFMMCTradingAccountToken(pQueryCFMMCTradingAccountToken, nRequestID);
        }

        public int ReqFromBankToFutureByFuture(CThostFtdcReqTransferField pReqTransfer, int nRequestID)
        {
            return _traderApi.ReqFromBankToFutureByFuture(pReqTransfer, nRequestID);
        }

        public int ReqFromFutureToBankByFuture(CThostFtdcReqTransferField pReqTransfer, int nRequestID)
        {
            return _traderApi.ReqFromFutureToBankByFuture(pReqTransfer, nRequestID);
        }

        public int ReqQueryBankAccountMoneyByFuture(CThostFtdcReqQueryAccountField pReqQueryAccount, int nRequestID)
        {
            return _traderApi.ReqQueryBankAccountMoneyByFuture(pReqQueryAccount, nRequestID);
        }

        private CThostFtdcTraderApi _traderApi;
        private ITradeCallbackMapping _callbackApi;
    }
}
