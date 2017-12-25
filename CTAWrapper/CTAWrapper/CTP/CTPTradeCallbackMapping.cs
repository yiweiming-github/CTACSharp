using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTACSharp.CTP.Trade;

namespace CTAWrapper.CTP
{
    public class CTPTradeCallbackMapping : CThostFtdcTraderSpi, ITradeCallbackMapping
    {
        public void SetCallbackImpl(ITradeCallbackApi callbackApi)
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
            _callbackApi.OnRspError(pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspUserLogin(CThostFtdcRspUserLoginField pRspUserLogin, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            _callbackApi.OnRspUserLogin(pRspUserLogin, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspAuthenticate(CThostFtdcRspAuthenticateField pRspAuthenticateField, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspAuthenticate(pRspAuthenticateField, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnErrRtnBankToFutureByFuture(CThostFtdcReqTransferField pReqTransfer, CThostFtdcRspInfoField pRspInfo)
        {
            _callbackApi.OnErrRtnBankToFutureByFuture(pReqTransfer, pRspInfo);
        }

        public override void OnErrRtnCombActionInsert(CThostFtdcInputCombActionField pInputCombAction, CThostFtdcRspInfoField pRspInfo)
        {
            _callbackApi.OnErrRtnCombActionInsert(pInputCombAction, pRspInfo);
        }

        public override void OnErrRtnExecOrderAction(CThostFtdcExecOrderActionField pExecOrderAction, CThostFtdcRspInfoField pRspInfo)
        {
            _callbackApi.OnErrRtnExecOrderAction(pExecOrderAction, pRspInfo);
        }

        public override void OnErrRtnExecOrderInsert(CThostFtdcInputExecOrderField pInputExecOrder, CThostFtdcRspInfoField pRspInfo)
        {
            _callbackApi.OnErrRtnExecOrderInsert(pInputExecOrder, pRspInfo);
        }

        public override void OnErrRtnForQuoteInsert(CThostFtdcInputForQuoteField pInputForQuote, CThostFtdcRspInfoField pRspInfo)
        {
            _callbackApi.OnErrRtnForQuoteInsert(pInputForQuote, pRspInfo);
        }

        public override void OnErrRtnFutureToBankByFuture(CThostFtdcReqTransferField pReqTransfer, CThostFtdcRspInfoField pRspInfo)
        {
            _callbackApi.OnErrRtnFutureToBankByFuture(pReqTransfer, pRspInfo);
        }

        public override void OnErrRtnOrderAction(CThostFtdcOrderActionField pOrderAction, CThostFtdcRspInfoField pRspInfo)
        {
            _callbackApi.OnErrRtnOrderAction(pOrderAction, pRspInfo);
        }

        public override void OnErrRtnOrderInsert(CThostFtdcInputOrderField pInputOrder, CThostFtdcRspInfoField pRspInfo)
        {
            _callbackApi.OnErrRtnOrderInsert(pInputOrder, pRspInfo);
        }

        public override void OnErrRtnQueryBankBalanceByFuture(CThostFtdcReqQueryAccountField pReqQueryAccount, CThostFtdcRspInfoField pRspInfo)
        {
            _callbackApi.OnErrRtnQueryBankBalanceByFuture(pReqQueryAccount, pRspInfo);
        }

        public override void OnErrRtnQuoteAction(CThostFtdcQuoteActionField pQuoteAction, CThostFtdcRspInfoField pRspInfo)
        {
            _callbackApi.OnErrRtnQuoteAction(pQuoteAction, pRspInfo);
        }

        public override void OnErrRtnQuoteInsert(CThostFtdcInputQuoteField pInputQuote, CThostFtdcRspInfoField pRspInfo)
        {
            _callbackApi.OnErrRtnQuoteInsert(pInputQuote, pRspInfo);
        }

        public override void OnErrRtnRepealBankToFutureByFutureManual(CThostFtdcReqRepealField pReqRepeal, CThostFtdcRspInfoField pRspInfo)
        {
            _callbackApi.OnErrRtnRepealBankToFutureByFutureManual(pReqRepeal, pRspInfo);
        }

        public override void OnErrRtnRepealFutureToBankByFutureManual(CThostFtdcReqRepealField pReqRepeal, CThostFtdcRspInfoField pRspInfo)
        {
            _callbackApi.OnErrRtnRepealFutureToBankByFutureManual(pReqRepeal, pRspInfo);
        }

        public override void OnRspCombActionInsert(CThostFtdcInputCombActionField pInputCombAction, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspCombActionInsert(pInputCombAction, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspExecOrderAction(CThostFtdcInputExecOrderActionField pInputExecOrderAction, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspExecOrderAction(pInputExecOrderAction, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspExecOrderInsert(CThostFtdcInputExecOrderField pInputExecOrder, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspExecOrderInsert(pInputExecOrder, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspForQuoteInsert(CThostFtdcInputForQuoteField pInputForQuote, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            _callbackApi.OnRspForQuoteInsert(pInputForQuote, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspFromBankToFutureByFuture(CThostFtdcReqTransferField pReqTransfer, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspFromBankToFutureByFuture(pReqTransfer, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspFromFutureToBankByFuture(CThostFtdcReqTransferField pReqTransfer, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspFromFutureToBankByFuture(pReqTransfer, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspOrderAction(CThostFtdcInputOrderActionField pInputOrderAction, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspOrderAction(pInputOrderAction, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspOrderInsert(CThostFtdcInputOrderField pInputOrder, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            _callbackApi.OnRspOrderInsert(pInputOrder, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspParkedOrderAction(CThostFtdcParkedOrderActionField pParkedOrderAction, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspParkedOrderAction(pParkedOrderAction, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspParkedOrderInsert(CThostFtdcParkedOrderField pParkedOrder, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            _callbackApi.OnRspParkedOrderInsert(pParkedOrder, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryAccountregister(CThostFtdcAccountregisterField pAccountregister, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryAccountregister(pAccountregister, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryBrokerTradingAlgos(CThostFtdcBrokerTradingAlgosField pBrokerTradingAlgos, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryBrokerTradingAlgos(pBrokerTradingAlgos, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryBrokerTradingParams(CThostFtdcBrokerTradingParamsField pBrokerTradingParams,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryBrokerTradingParams(pBrokerTradingParams, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryCFMMCTradingAccountKey(CThostFtdcCFMMCTradingAccountKeyField pCFMMCTradingAccountKey,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryCFMMCTradingAccountKey(pCFMMCTradingAccountKey, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryCombAction(CThostFtdcCombActionField pCombAction, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            _callbackApi.OnRspQryCombAction(pCombAction, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryCombInstrumentGuard(CThostFtdcCombInstrumentGuardField pCombInstrumentGuard,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryCombInstrumentGuard(pCombInstrumentGuard, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryContractBank(CThostFtdcContractBankField pContractBank, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            _callbackApi.OnRspQryContractBank(pContractBank, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryDepthMarketData(CThostFtdcDepthMarketDataField pDepthMarketData, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryDepthMarketData(pDepthMarketData, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryEWarrantOffset(CThostFtdcEWarrantOffsetField pEWarrantOffset, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryEWarrantOffset(pEWarrantOffset, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryExchange(CThostFtdcExchangeField pExchange, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryExchange(pExchange, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryExchangeMarginRate(CThostFtdcExchangeMarginRateField pExchangeMarginRate, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryExchangeMarginRate(pExchangeMarginRate, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryExchangeMarginRateAdjust(CThostFtdcExchangeMarginRateAdjustField pExchangeMarginRateAdjust,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryExchangeMarginRateAdjust(pExchangeMarginRateAdjust, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryExchangeRate(CThostFtdcExchangeRateField pExchangeRate, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            _callbackApi.OnRspQryExchangeRate(pExchangeRate, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryExecOrder(CThostFtdcExecOrderField pExecOrder, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            _callbackApi.OnRspQryExecOrder(pExecOrder, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryForQuote(CThostFtdcForQuoteField pForQuote, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryForQuote(pForQuote, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryInstrument(CThostFtdcInstrumentField pInstrument, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            _callbackApi.OnRspQryInstrument(pInstrument, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryInstrumentCommissionRate(CThostFtdcInstrumentCommissionRateField pInstrumentCommissionRate,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryInstrumentCommissionRate(pInstrumentCommissionRate, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryInstrumentMarginRate(CThostFtdcInstrumentMarginRateField pInstrumentMarginRate,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryInstrumentMarginRate(pInstrumentMarginRate, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryInvestor(CThostFtdcInvestorField pInvestor, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryInvestor(pInvestor, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryInvestorPosition(CThostFtdcInvestorPositionField pInvestorPosition, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryInvestorPosition(pInvestorPosition, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryInvestorPositionCombineDetail(CThostFtdcInvestorPositionCombineDetailField pInvestorPositionCombineDetail,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryInvestorPositionCombineDetail(pInvestorPositionCombineDetail, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryInvestorPositionDetail(CThostFtdcInvestorPositionDetailField pInvestorPositionDetail,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryInvestorPositionDetail(pInvestorPositionDetail, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryInvestorProductGroupMargin(CThostFtdcInvestorProductGroupMarginField pInvestorProductGroupMargin,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryInvestorProductGroupMargin(pInvestorProductGroupMargin, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryNotice(CThostFtdcNoticeField pNotice, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryNotice(pNotice, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryOptionInstrCommRate(CThostFtdcOptionInstrCommRateField pOptionInstrCommRate,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryOptionInstrCommRate(pOptionInstrCommRate, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryOptionInstrTradeCost(CThostFtdcOptionInstrTradeCostField pOptionInstrTradeCost,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryOptionInstrTradeCost(pOptionInstrTradeCost, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryOrder(CThostFtdcOrderField pOrder, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryOrder(pOrder, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryParkedOrder(CThostFtdcParkedOrderField pParkedOrder, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            _callbackApi.OnRspQryParkedOrder(pParkedOrder, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryParkedOrderAction(CThostFtdcParkedOrderActionField pParkedOrderAction, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryParkedOrderAction(pParkedOrderAction, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryProduct(CThostFtdcProductField pProduct, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryProduct(pProduct, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryProductExchRate(CThostFtdcProductExchRateField pProductExchRate, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryProductExchRate(pProductExchRate, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryQuote(CThostFtdcQuoteField pQuote, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryQuote(pQuote, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQrySecAgentACIDMap(CThostFtdcSecAgentACIDMapField pSecAgentACIDMap, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQrySecAgentACIDMap(pSecAgentACIDMap, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQrySettlementInfo(CThostFtdcSettlementInfoField pSettlementInfo, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQrySettlementInfo(pSettlementInfo, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQrySettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQrySettlementInfoConfirm(pSettlementInfoConfirm, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryTrade(CThostFtdcTradeField pTrade, CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryTrade(pTrade, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryTradingAccount(CThostFtdcTradingAccountField pTradingAccount, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryTradingAccount(pTradingAccount, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryTradingCode(CThostFtdcTradingCodeField pTradingCode, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            _callbackApi.OnRspQryTradingCode(pTradingCode, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryTradingNotice(CThostFtdcTradingNoticeField pTradingNotice, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            _callbackApi.OnRspQryTradingNotice(pTradingNotice, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryTransferBank(CThostFtdcTransferBankField pTransferBank, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            _callbackApi.OnRspQryTransferBank(pTransferBank, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQryTransferSerial(CThostFtdcTransferSerialField pTransferSerial, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQryTransferSerial(pTransferSerial, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQueryBankAccountMoneyByFuture(CThostFtdcReqQueryAccountField pReqQueryAccount,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQueryBankAccountMoneyByFuture(pReqQueryAccount, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQueryCFMMCTradingAccountToken(CThostFtdcQueryCFMMCTradingAccountTokenField pQueryCFMMCTradingAccountToken,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQueryCFMMCTradingAccountToken(pQueryCFMMCTradingAccountToken, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQueryMaxOrderVolume(CThostFtdcQueryMaxOrderVolumeField pQueryMaxOrderVolume, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQueryMaxOrderVolume(pQueryMaxOrderVolume, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQuoteAction(CThostFtdcInputQuoteActionField pInputQuoteAction, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspQuoteAction(pInputQuoteAction, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspQuoteInsert(CThostFtdcInputQuoteField pInputQuote, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            _callbackApi.OnRspQuoteInsert(pInputQuote, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspRemoveParkedOrder(CThostFtdcRemoveParkedOrderField pRemoveParkedOrder, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspRemoveParkedOrder(pRemoveParkedOrder, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspRemoveParkedOrderAction(CThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspRemoveParkedOrderAction(pRemoveParkedOrderAction, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspSettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspSettlementInfoConfirm(pSettlementInfoConfirm, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspTradingAccountPasswordUpdate(CThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspTradingAccountPasswordUpdate(pTradingAccountPasswordUpdate, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspUserLogout(CThostFtdcUserLogoutField pUserLogout, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            _callbackApi.OnRspUserLogout(pUserLogout, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRspUserPasswordUpdate(CThostFtdcUserPasswordUpdateField pUserPasswordUpdate, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            _callbackApi.OnRspUserPasswordUpdate(pUserPasswordUpdate, pRspInfo, nRequestID, bIsLast);
        }

        public override void OnRtnCFMMCTradingAccountToken(CThostFtdcCFMMCTradingAccountTokenField pCFMMCTradingAccountToken)
        {
            _callbackApi.OnRtnCFMMCTradingAccountToken(pCFMMCTradingAccountToken);
        }

        public override void OnRtnCancelAccountByBank(CThostFtdcCancelAccountField pCancelAccount)
        {
            _callbackApi.OnRtnCancelAccountByBank(pCancelAccount);
        }

        public override void OnRtnChangeAccountByBank(CThostFtdcChangeAccountField pChangeAccount)
        {
            _callbackApi.OnRtnChangeAccountByBank(pChangeAccount);
        }

        public override void OnRtnCombAction(CThostFtdcCombActionField pCombAction)
        {
            _callbackApi.OnRtnCombAction(pCombAction);
        }

        public override void OnRtnErrorConditionalOrder(CThostFtdcErrorConditionalOrderField pErrorConditionalOrder)
        {
            _callbackApi.OnRtnErrorConditionalOrder(pErrorConditionalOrder);
        }

        public override void OnRtnExecOrder(CThostFtdcExecOrderField pExecOrder)
        {
            _callbackApi.OnRtnExecOrder(pExecOrder);
        }

        public override void OnRtnForQuoteRsp(CThostFtdcForQuoteRspField pForQuoteRsp)
        {
            _callbackApi.OnRtnForQuoteRsp(pForQuoteRsp);
        }

        public override void OnRtnFromBankToFutureByBank(CThostFtdcRspTransferField pRspTransfer)
        {
            _callbackApi.OnRtnFromBankToFutureByBank(pRspTransfer);
        }

        public override void OnRtnFromBankToFutureByFuture(CThostFtdcRspTransferField pRspTransfer)
        {
            _callbackApi.OnRtnFromBankToFutureByFuture(pRspTransfer);
        }

        public override void OnRtnFromFutureToBankByBank(CThostFtdcRspTransferField pRspTransfer)
        {
            _callbackApi.OnRtnFromFutureToBankByBank(pRspTransfer);
        }

        public override void OnRtnFromFutureToBankByFuture(CThostFtdcRspTransferField pRspTransfer)
        {
            _callbackApi.OnRtnFromFutureToBankByFuture(pRspTransfer);
        }

        public override void OnRtnInstrumentStatus(CThostFtdcInstrumentStatusField pInstrumentStatus)
        {
            _callbackApi.OnRtnInstrumentStatus(pInstrumentStatus);
        }

        public override void OnRtnOpenAccountByBank(CThostFtdcOpenAccountField pOpenAccount)
        {
            _callbackApi.OnRtnOpenAccountByBank(pOpenAccount);
        }

        public override void OnRtnOrder(CThostFtdcOrderField pOrder)
        {
            _callbackApi.OnRtnOrder(pOrder);
        }

        public override void OnRtnQueryBankBalanceByFuture(CThostFtdcNotifyQueryAccountField pNotifyQueryAccount)
        {
            _callbackApi.OnRtnQueryBankBalanceByFuture(pNotifyQueryAccount);
        }

        public override void OnRtnQuote(CThostFtdcQuoteField pQuote)
        {
            _callbackApi.OnRtnQuote(pQuote);
        }

        public override void OnRtnRepealFromBankToFutureByBank(CThostFtdcRspRepealField pRspRepeal)
        {
            _callbackApi.OnRtnRepealFromBankToFutureByBank(pRspRepeal);
        }

        public override void OnRtnRepealFromBankToFutureByFuture(CThostFtdcRspRepealField pRspRepeal)
        {
            _callbackApi.OnRtnRepealFromBankToFutureByFuture(pRspRepeal);
        }

        public override void OnRtnRepealFromBankToFutureByFutureManual(CThostFtdcRspRepealField pRspRepeal)
        {
            _callbackApi.OnRtnRepealFromBankToFutureByFutureManual(pRspRepeal);
        }

        public override void OnRtnRepealFromFutureToBankByBank(CThostFtdcRspRepealField pRspRepeal)
        {
            _callbackApi.OnRtnRepealFromFutureToBankByBank(pRspRepeal);
        }

        public override void OnRtnRepealFromFutureToBankByFuture(CThostFtdcRspRepealField pRspRepeal)
        {
            _callbackApi.OnRtnRepealFromFutureToBankByFuture(pRspRepeal);
        }

        public override void OnRtnRepealFromFutureToBankByFutureManual(CThostFtdcRspRepealField pRspRepeal)
        {
            _callbackApi.OnRtnRepealFromFutureToBankByFutureManual(pRspRepeal);
        }

        public override void OnRtnTrade(CThostFtdcTradeField pTrade)
        {
            _callbackApi.OnRtnTrade(pTrade);
        }

        public override void OnRtnTradingNotice(CThostFtdcTradingNoticeInfoField pTradingNoticeInfo)
        {
            _callbackApi.OnRtnTradingNotice(pTradingNoticeInfo);
        }

        private ITradeCallbackApi _callbackApi;
    }
}
