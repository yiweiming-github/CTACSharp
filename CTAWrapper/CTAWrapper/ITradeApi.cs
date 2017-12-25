using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTACSharp.CTP.Trade;

namespace CTAWrapper
{
    public interface ITradeApi
    {
        //相当于CTP的RegisterSpi
        void RegisterCallback(ITradeCallbackApi callbackApi);

        string GetApiVersion();
        void Release();
        void Init();
        int Join();
        string GetTradingDay();
        void RegisterFront(string pszFrontAddress);
        void RegisterNameServer(string pszNsAddress);
        void RegisterFensUserInfo(CThostFtdcFensUserInfoField pFensUserInfo);
        void SubscribePrivateTopic(THOST_TE_RESUME_TYPE nResumeType);
        void SubscribePublicTopic(THOST_TE_RESUME_TYPE nResumeType);
        int ReqAuthenticate(CThostFtdcReqAuthenticateField pReqAuthenticateField, int nRequestID);
        int ReqUserLogin(CThostFtdcReqUserLoginField pReqUserLoginField, int nRequestID);
        int ReqUserLogout(CThostFtdcUserLogoutField pUserLogout, int nRequestID);
        int ReqUserPasswordUpdate(CThostFtdcUserPasswordUpdateField pUserPasswordUpdate, int nRequestID);
        int ReqTradingAccountPasswordUpdate(CThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate,
            int nRequestID);
        int ReqOrderInsert(CThostFtdcInputOrderField pInputOrder, int nRequestID);
        int ReqParkedOrderInsert(CThostFtdcParkedOrderField pParkedOrder, int nRequestID);
        int ReqParkedOrderAction(CThostFtdcParkedOrderActionField pParkedOrderAction, int nRequestID);
        int ReqOrderAction(CThostFtdcInputOrderActionField pInputOrderAction, int nRequestID);
        int ReqQueryMaxOrderVolume(CThostFtdcQueryMaxOrderVolumeField pQueryMaxOrderVolume, int nRequestID);
        int ReqSettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm, int nRequestID);
        int ReqRemoveParkedOrder(CThostFtdcRemoveParkedOrderField pRemoveParkedOrder, int nRequestID);
        int ReqRemoveParkedOrderAction(CThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction, int nRequestID);
        int ReqExecOrderInsert(CThostFtdcInputExecOrderField pInputExecOrder, int nRequestID);
        int ReqExecOrderAction(CThostFtdcInputExecOrderActionField pInputExecOrderAction, int nRequestID);
        int ReqForQuoteInsert(CThostFtdcInputForQuoteField pInputForQuote, int nRequestID);
        int ReqQuoteInsert(CThostFtdcInputQuoteField pInputQuote, int nRequestID);
        int ReqQuoteAction(CThostFtdcInputQuoteActionField pInputQuoteAction, int nRequestID);
        int ReqCombActionInsert(CThostFtdcInputCombActionField pInputCombAction, int nRequestID);
        int ReqQryOrder(CThostFtdcQryOrderField pQryOrder, int nRequestID);
        int ReqQryTrade(CThostFtdcQryTradeField pQryTrade, int nRequestID);
        int ReqQryInvestorPosition(CThostFtdcQryInvestorPositionField pQryInvestorPosition, int nRequestID);
        int ReqQryTradingAccount(CThostFtdcQryTradingAccountField pQryTradingAccount, int nRequestID);
        int ReqQryInvestor(CThostFtdcQryInvestorField pQryInvestor, int nRequestID);
        int ReqQryTradingCode(CThostFtdcQryTradingCodeField pQryTradingCode, int nRequestID);
        int ReqQryInstrumentMarginRate(CThostFtdcQryInstrumentMarginRateField pQryInstrumentMarginRate, int nRequestID);
        int ReqQryInstrumentCommissionRate(CThostFtdcQryInstrumentCommissionRateField pQryInstrumentCommissionRate, int nRequestID);
        int ReqQryExchange(CThostFtdcQryExchangeField pQryExchange, int nRequestID);
        int ReqQryProduct(CThostFtdcQryProductField pQryProduct, int nRequestID);
        int ReqQryInstrument(CThostFtdcQryInstrumentField pQryInstrument, int nRequestID);
        int ReqQryDepthMarketData(CThostFtdcQryDepthMarketDataField pQryDepthMarketData, int nRequestID);
        int ReqQrySettlementInfo(CThostFtdcQrySettlementInfoField pQrySettlementInfo, int nRequestID);
        int ReqQryTransferBank(CThostFtdcQryTransferBankField pQryTransferBank, int nRequestID);
        int ReqQryInvestorPositionDetail(CThostFtdcQryInvestorPositionDetailField pQryInvestorPositionDetail,int nRequestID);
        int ReqQryNotice(CThostFtdcQryNoticeField pQryNotice, int nRequestID);
        int ReqQrySettlementInfoConfirm(CThostFtdcQrySettlementInfoConfirmField pQrySettlementInfoConfirm, int nRequestID);
        int ReqQryInvestorPositionCombineDetail(
            CThostFtdcQryInvestorPositionCombineDetailField pQryInvestorPositionCombineDetail, int nRequestID);
        int ReqQryCFMMCTradingAccountKey(CThostFtdcQryCFMMCTradingAccountKeyField pQryCFMMCTradingAccountKey,
            int nRequestID);
        int ReqQryEWarrantOffset(CThostFtdcQryEWarrantOffsetField pQryEWarrantOffset, int nRequestID);
        int ReqQryInvestorProductGroupMargin(
            CThostFtdcQryInvestorProductGroupMarginField pQryInvestorProductGroupMargin, int nRequestID);
        int ReqQryExchangeMarginRate(CThostFtdcQryExchangeMarginRateField pQryExchangeMarginRate, int nRequestID);
        int ReqQryExchangeMarginRateAdjust(CThostFtdcQryExchangeMarginRateAdjustField pQryExchangeMarginRateAdjust,
            int nRequestID);

        int ReqQryExchangeRate(CThostFtdcQryExchangeRateField pQryExchangeRate, int nRequestID);
        int ReqQrySecAgentACIDMap(CThostFtdcQrySecAgentACIDMapField pQrySecAgentACIDMap, int nRequestID);
        int ReqQryProductExchRate(CThostFtdcQryProductExchRateField pQryProductExchRate, int nRequestID);
        int ReqQryOptionInstrTradeCost(CThostFtdcQryOptionInstrTradeCostField pQryOptionInstrTradeCost, int nRequestID);
        int ReqQryOptionInstrCommRate(CThostFtdcQryOptionInstrCommRateField pQryOptionInstrCommRate, int nRequestID);
        int ReqQryExecOrder(CThostFtdcQryExecOrderField pQryExecOrder, int nRequestID);
        int ReqQryForQuote(CThostFtdcQryForQuoteField pQryForQuote, int nRequestID);
        int ReqQryQuote(CThostFtdcQryQuoteField pQryQuote, int nRequestID);
        int ReqQryCombInstrumentGuard(CThostFtdcQryCombInstrumentGuardField pQryCombInstrumentGuard, int nRequestID);
        int ReqQryCombAction(CThostFtdcQryCombActionField pQryCombAction, int nRequestID);
        int ReqQryTransferSerial(CThostFtdcQryTransferSerialField pQryTransferSerial, int nRequestID);
        int ReqQryAccountregister(CThostFtdcQryAccountregisterField pQryAccountregister, int nRequestID);
        int ReqQryContractBank(CThostFtdcQryContractBankField pQryContractBank, int nRequestID);
        int ReqQryParkedOrder(CThostFtdcQryParkedOrderField pQryParkedOrder, int nRequestID);
        int ReqQryParkedOrderAction(CThostFtdcQryParkedOrderActionField pQryParkedOrderAction, int nRequestID);
        int ReqQryTradingNotice(CThostFtdcQryTradingNoticeField pQryTradingNotice, int nRequestID);
        int ReqQryBrokerTradingParams(CThostFtdcQryBrokerTradingParamsField pQryBrokerTradingParams, int nRequestID);
        int ReqQryBrokerTradingAlgos(CThostFtdcQryBrokerTradingAlgosField pQryBrokerTradingAlgos, int nRequestID);

        int ReqQueryCFMMCTradingAccountToken(
            CThostFtdcQueryCFMMCTradingAccountTokenField pQueryCFMMCTradingAccountToken, int nRequestID);

        int ReqFromBankToFutureByFuture(CThostFtdcReqTransferField pReqTransfer, int nRequestID);
        int ReqFromFutureToBankByFuture(CThostFtdcReqTransferField pReqTransfer, int nRequestID);
        int ReqQueryBankAccountMoneyByFuture(CThostFtdcReqQueryAccountField pReqQueryAccount, int nRequestID);
    }
}
