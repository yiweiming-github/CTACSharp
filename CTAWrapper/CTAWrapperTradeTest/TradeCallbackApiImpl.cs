using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTACSharp.CTP.Trade;
using CTAWrapper;

namespace CTAWrapperTradeTest
{
    public class TradeCallbackApiImpl : ITradeCallbackApi
    {
        public bool IsReady
        {
            get { return _isReady; }
        }

        private bool _isReady = false;

        public bool IsConnected
        {
            get { return _isConnected; }
        }

        private bool _isConnected = false;
        private long _orderRef = 0;

        public string GetNextOrderRef()
        {
            return (++_orderRef).ToString("000000000000");
        }

        public void OnFrontConnected()
        {
            Console.WriteLine("OnFrontConnected");
            _isConnected = true;
        }

        public void OnRspUserLogin(CThostFtdcRspUserLoginField pRspUserLogin, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            Console.WriteLine("OnRspUserLogin");
            _isReady = true;
        }

        public void OnRspError(CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspError");
        }

        public void OnFrontDisconnected(int nReason)
        {
            Console.WriteLine("OnFrontDisconnected reason: {0}", nReason);
        }

        public void OnRspUserLogout(CThostFtdcUserLogoutField pUserLogout, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            Console.WriteLine("OnRspUserLogout");
        }

        public void OnRtnOrder(CThostFtdcOrderField pOrder)
        {
            Console.WriteLine("OnRtnOrder");
            if (pOrder.OrderStatus == '1')
            {
                Console.WriteLine("PartTradedQueueing");
            }
            else if (pOrder.OrderStatus == '2')
            {
                Console.WriteLine("PartTradedNotQueueing");
            }
            else if (pOrder.OrderStatus == '5')
            {
                Console.WriteLine("Canceled");
            }
            else
            {
                Console.WriteLine("Placed");
            }
        }

        public void OnRspOrderInsert(CThostFtdcInputOrderField pInputOrder, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            if (pRspInfo.ErrorID != 0)
            {
                Console.WriteLine("OnRspOrderInsert Error: {0}", pRspInfo.ErrorMsg);
            }
            else
            {
                Console.WriteLine("OnRspOrderInsert");
            }
        }

        public void OnRspSettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspSettlementInfoConfirm");
        }

        ///心跳超时警告。当长时间未收到报文时，该方法被调用。
        ///@param nTimeLapse 距离上次接收报文的时间
        public void OnHeartBeatWarning(int nTimeLapse)
        {
            Console.WriteLine("OnHeartBeatWarning");
        }

        ///客户端认证响应
        public void OnRspAuthenticate(CThostFtdcRspAuthenticateField pRspAuthenticateField,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspAuthenticate");
        }

        ///用户口令更新请求响应
        public void OnRspUserPasswordUpdate(CThostFtdcUserPasswordUpdateField pUserPasswordUpdate,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspUserPasswordUpdate");
        }

        ///资金账户口令更新请求响应
        public void OnRspTradingAccountPasswordUpdate(
            CThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspTradingAccountPasswordUpdate");
        }

        ///预埋单录入请求响应
        public void OnRspParkedOrderInsert(CThostFtdcParkedOrderField pParkedOrder, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspParkedOrderInsert");
        }

        ///预埋撤单录入请求响应
        public void OnRspParkedOrderAction(CThostFtdcParkedOrderActionField pParkedOrderAction,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspParkedOrderAction");
        }

        ///报单操作请求响应
        public void OnRspOrderAction(CThostFtdcInputOrderActionField pInputOrderAction, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspOrderAction");
        }

        ///查询最大报单数量响应
        public void OnRspQueryMaxOrderVolume(CThostFtdcQueryMaxOrderVolumeField pQueryMaxOrderVolume,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQueryMaxOrderVolume");
        }

        ///删除预埋单响应
        public void OnRspRemoveParkedOrder(CThostFtdcRemoveParkedOrderField pRemoveParkedOrder,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspRemoveParkedOrder");
        }

        ///删除预埋撤单响应
        public void OnRspRemoveParkedOrderAction(CThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspRemoveParkedOrderAction");
        }

        ///执行宣告录入请求响应
        public void OnRspExecOrderInsert(CThostFtdcInputExecOrderField pInputExecOrder, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspExecOrderInsert");
        }

        ///执行宣告操作请求响应
        public void OnRspExecOrderAction(CThostFtdcInputExecOrderActionField pInputExecOrderAction,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspExecOrderAction");
        }

        ///询价录入请求响应
        public void OnRspForQuoteInsert(CThostFtdcInputForQuoteField pInputForQuote, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspForQuoteInsert");
        }

        ///报价录入请求响应
        public void OnRspQuoteInsert(CThostFtdcInputQuoteField pInputQuote, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQuoteInsert");
        }

        ///报价操作请求响应
        public void OnRspQuoteAction(CThostFtdcInputQuoteActionField pInputQuoteAction, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQuoteAction");
        }

        ///申请组合录入请求响应
        public void OnRspCombActionInsert(CThostFtdcInputCombActionField pInputCombAction,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspCombActionInsert");
        }

        ///请求查询报单响应
        public void OnRspQryOrder(CThostFtdcOrderField pOrder, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            Console.WriteLine("OnRspQryOrder");
        }

        ///请求查询成交响应
        public void OnRspQryTrade(CThostFtdcTradeField pTrade, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            Console.WriteLine("OnRspQryTrade");
        }

        ///请求查询投资者持仓响应
        public void OnRspQryInvestorPosition(CThostFtdcInvestorPositionField pInvestorPosition,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryInvestorPosition");
        }

        ///请求查询资金账户响应
        public void OnRspQryTradingAccount(CThostFtdcTradingAccountField pTradingAccount,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryTradingAccount");
        }

        ///请求查询投资者响应
        public void OnRspQryInvestor(CThostFtdcInvestorField pInvestor, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            Console.WriteLine("OnRspQryInvestor");
        }

        ///请求查询交易编码响应
        public void OnRspQryTradingCode(CThostFtdcTradingCodeField pTradingCode, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryTradingCode");
        }

        ///请求查询合约保证金率响应
        public void OnRspQryInstrumentMarginRate(CThostFtdcInstrumentMarginRateField pInstrumentMarginRate,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryInstrumentMarginRate");
        }

        ///请求查询合约手续费率响应
        public void OnRspQryInstrumentCommissionRate(CThostFtdcInstrumentCommissionRateField pInstrumentCommissionRate,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryInstrumentCommissionRate");
        }

        ///请求查询交易所响应
        public void OnRspQryExchange(CThostFtdcExchangeField pExchange, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            Console.WriteLine("OnRspQryExchange");
        }

        ///请求查询产品响应
        public void OnRspQryProduct(CThostFtdcProductField pProduct, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            Console.WriteLine("OnRspQryProduct");
        }

        ///请求查询合约响应
        public void OnRspQryInstrument(CThostFtdcInstrumentField pInstrument, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryInstrument");
        }

        ///请求查询行情响应
        public void OnRspQryDepthMarketData(CThostFtdcDepthMarketDataField pDepthMarketData,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryDepthMarketData");
        }

        ///请求查询投资者结算结果响应
        public void OnRspQrySettlementInfo(CThostFtdcSettlementInfoField pSettlementInfo,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQrySettlementInfo");
        }

        ///请求查询转帐银行响应
        public void OnRspQryTransferBank(CThostFtdcTransferBankField pTransferBank, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryTransferBank");
        }

        ///请求查询投资者持仓明细响
        public void OnRspQryInvestorPositionDetail(CThostFtdcInvestorPositionDetailField pInvestorPositionDetail,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryInvestorPositionDetail");
        }

        ///请求查询客户通知响应
        public void OnRspQryNotice(CThostFtdcNoticeField pNotice, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            Console.WriteLine("OnRspQryNotice");
        }

        ///请求查询结算信息确认响应
        public void OnRspQrySettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQrySettlementInfoConfirm");
        }

        ///请求查询投资者持仓明细响应
        public void OnRspQryInvestorPositionCombineDetail(
            CThostFtdcInvestorPositionCombineDetailField pInvestorPositionCombineDetail,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryInvestorPositionCombineDetail");
        }

        ///查询保证金监管系统经纪公司资金账户密钥响应
        public void OnRspQryCFMMCTradingAccountKey(CThostFtdcCFMMCTradingAccountKeyField pCFMMCTradingAccountKey,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryCFMMCTradingAccountKey");
        }

        ///请求查询仓单折抵信息响应
        public void OnRspQryEWarrantOffset(CThostFtdcEWarrantOffsetField pEWarrantOffset,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryEWarrantOffset");
        }

        ///请求查询投资者品种/跨品种保证金响应
        public void OnRspQryInvestorProductGroupMargin(
            CThostFtdcInvestorProductGroupMarginField pInvestorProductGroupMargin, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryInvestorProductGroupMargin");
        }

        ///请求查询交易所保证金率响应
        public void OnRspQryExchangeMarginRate(CThostFtdcExchangeMarginRateField pExchangeMarginRate,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryExchangeMarginRate");
        }

        ///请求查询交易所调整保证金率响应
        public void OnRspQryExchangeMarginRateAdjust(CThostFtdcExchangeMarginRateAdjustField pExchangeMarginRateAdjust,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryExchangeMarginRateAdjust");
        }

        ///请求查询汇率响应
        public void OnRspQryExchangeRate(CThostFtdcExchangeRateField pExchangeRate, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryExchangeRate");
        }

        ///请求查询二级代理操作员银期权限响应
        public void OnRspQrySecAgentACIDMap(CThostFtdcSecAgentACIDMapField pSecAgentACIDMap,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQrySecAgentACIDMap");
        }

        ///请求查询产品报价汇率
        public void OnRspQryProductExchRate(CThostFtdcProductExchRateField pProductExchRate,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryProductExchRate");
        }

        ///请求查询期权交易成本响应
        public void OnRspQryOptionInstrTradeCost(CThostFtdcOptionInstrTradeCostField pOptionInstrTradeCost,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryOptionInstrTradeCost");
        }

        ///请求查询期权合约手续费响应
        public void OnRspQryOptionInstrCommRate(CThostFtdcOptionInstrCommRateField pOptionInstrCommRate,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryOptionInstrCommRate");
        }

        ///请求查询执行宣告响应
        public void OnRspQryExecOrder(CThostFtdcExecOrderField pExecOrder, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryExecOrder");
        }

        ///请求查询询价响应
        public void OnRspQryForQuote(CThostFtdcForQuoteField pForQuote, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            Console.WriteLine("OnRspQryForQuote");
        }

        ///请求查询报价响
        public void OnRspQryQuote(CThostFtdcQuoteField pQuote, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            Console.WriteLine("OnRspQryQuote");
        }

        ///请求查询组合合约安全系数响应
        public void OnRspQryCombInstrumentGuard(CThostFtdcCombInstrumentGuardField pCombInstrumentGuard,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryCombInstrumentGuard");
        }

        ///请求查询申请组合响应
        public void OnRspQryCombAction(CThostFtdcCombActionField pCombAction, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryCombAction");
        }

        ///请求查询转帐流水响应
        public void OnRspQryTransferSerial(CThostFtdcTransferSerialField pTransferSerial,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryTransferSerial");
        }

        ///请求查询银期签约关系响应
        public void OnRspQryAccountregister(CThostFtdcAccountregisterField pAccountregister,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryAccountregister");
        }

        ///成交通知
        public void OnRtnTrade(CThostFtdcTradeField pTrade)
        {
            Console.WriteLine("OnRtnTrade");
        }

        ///报单录入错误回报
        public void OnErrRtnOrderInsert(CThostFtdcInputOrderField pInputOrder, CThostFtdcRspInfoField pRspInfo)
        {
            Console.WriteLine("OnErrRtnOrderInsert");
        }

        ///报单操作错误回报
        public void OnErrRtnOrderAction(CThostFtdcOrderActionField pOrderAction, CThostFtdcRspInfoField pRspInfo)
        {
            Console.WriteLine("OnErrRtnOrderAction");
        }

        ///合约交易状态通知
        public void OnRtnInstrumentStatus(CThostFtdcInstrumentStatusField pInstrumentStatus)
        {
            Console.WriteLine("OnRtnInstrumentStatus");
        }

        ///交易通知
        public void OnRtnTradingNotice(CThostFtdcTradingNoticeInfoField pTradingNoticeInfo)
        {
            Console.WriteLine("OnRtnTradingNotice");
        }

        ///提示条件单校验错误
        public void OnRtnErrorConditionalOrder(CThostFtdcErrorConditionalOrderField pErrorConditionalOrder)
        {
            Console.WriteLine("OnRtnErrorConditionalOrder");
        }

        ///执行宣告通知
        public void OnRtnExecOrder(CThostFtdcExecOrderField pExecOrder)
        {
            Console.WriteLine("OnRtnExecOrder");
        }

        ///执行宣告录入错误回报
        public void OnErrRtnExecOrderInsert(CThostFtdcInputExecOrderField pInputExecOrder,
            CThostFtdcRspInfoField pRspInfo)
        {
            Console.WriteLine("OnErrRtnExecOrderInsert");
        }

        ///执行宣告操作错误回报
        public void OnErrRtnExecOrderAction(CThostFtdcExecOrderActionField pExecOrderAction,
            CThostFtdcRspInfoField pRspInfo)
        {
            Console.WriteLine("OnErrRtnExecOrderAction");
        }

        ///询价录入错误回报
        public void OnErrRtnForQuoteInsert(CThostFtdcInputForQuoteField pInputForQuote, CThostFtdcRspInfoField pRspInfo)
        {
            Console.WriteLine("OnErrRtnForQuoteInsert");
        }

        ///报价通知
        public void OnRtnQuote(CThostFtdcQuoteField pQuote)
        {
            Console.WriteLine("OnRtnQuote");
        }

        ///报价录入错误回报
        public void OnErrRtnQuoteInsert(CThostFtdcInputQuoteField pInputQuote, CThostFtdcRspInfoField pRspInfo)
        {
            Console.WriteLine("OnErrRtnQuoteInsert");
        }

        ///报价操作错误回报
        public void OnErrRtnQuoteAction(CThostFtdcQuoteActionField pQuoteAction, CThostFtdcRspInfoField pRspInfo)
        {
            Console.WriteLine("OnErrRtnQuoteAction");
        }

        ///询价通知
        public void OnRtnForQuoteRsp(CThostFtdcForQuoteRspField pForQuoteRsp)
        {
            Console.WriteLine("OnRtnForQuoteRsp");
        }

        ///保证金监控中心用户令牌
        public void OnRtnCFMMCTradingAccountToken(CThostFtdcCFMMCTradingAccountTokenField pCFMMCTradingAccountToken)
        {
            Console.WriteLine("OnRtnCFMMCTradingAccountToken");
        }

        ///申请组合通知
        public void OnRtnCombAction(CThostFtdcCombActionField pCombAction)
        {
            Console.WriteLine("OnRtnCombAction");
        }

        ///申请组合录入错误回报
        public void OnErrRtnCombActionInsert(CThostFtdcInputCombActionField pInputCombAction,
            CThostFtdcRspInfoField pRspInfo)
        {
            Console.WriteLine("OnErrRtnCombActionInsert");
        }

        ///请求查询签约银行响应
        public void OnRspQryContractBank(CThostFtdcContractBankField pContractBank, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryContractBank");
        }

        ///请求查询预埋单响应
        public void OnRspQryParkedOrder(CThostFtdcParkedOrderField pParkedOrder, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryParkedOrder");
        }

        ///请求查询预埋撤单响应
        public void OnRspQryParkedOrderAction(CThostFtdcParkedOrderActionField pParkedOrderAction,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryParkedOrderAction");
        }

        ///请求查询交易通知响应
        public void OnRspQryTradingNotice(CThostFtdcTradingNoticeField pTradingNotice, CThostFtdcRspInfoField pRspInfo,
            int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryTradingNotice");
        }

        ///请求查询经纪公司交易参数响应
        public void OnRspQryBrokerTradingParams(CThostFtdcBrokerTradingParamsField pBrokerTradingParams,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryBrokerTradingParams");
        }

        ///请求查询经纪公司交易算法响应
        public void OnRspQryBrokerTradingAlgos(CThostFtdcBrokerTradingAlgosField pBrokerTradingAlgos,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQryBrokerTradingAlgos");
        }

        ///请求查询监控中心用户令牌
        public void OnRspQueryCFMMCTradingAccountToken(
            CThostFtdcQueryCFMMCTradingAccountTokenField pQueryCFMMCTradingAccountToken,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQueryCFMMCTradingAccountToken");
        }

        ///银行发起银行资金转期货通知
        public void OnRtnFromBankToFutureByBank(CThostFtdcRspTransferField pRspTransfer)
        {
            Console.WriteLine("OnRtnFromBankToFutureByBank");
        }

        ///银行发起期货资金转银行通知
        public void OnRtnFromFutureToBankByBank(CThostFtdcRspTransferField pRspTransfer)
        {
            Console.WriteLine("OnRtnFromFutureToBankByBank");
        }

        ///银行发起冲正银行转期货通知
        public void OnRtnRepealFromBankToFutureByBank(CThostFtdcRspRepealField pRspRepeal)
        {
            Console.WriteLine("OnRtnRepealFromBankToFutureByBank");
        }

        ///银行发起冲正期货转银行通知
        public void OnRtnRepealFromFutureToBankByBank(CThostFtdcRspRepealField pRspRepeal)
        {
            Console.WriteLine("OnRtnRepealFromFutureToBankByBank");
        }

        ///期货发起银行资金转期货通知
        public void OnRtnFromBankToFutureByFuture(CThostFtdcRspTransferField pRspTransfer)
        {
            Console.WriteLine("OnRtnFromBankToFutureByFuture");
        }

        ///期货发起期货资金转银行通知
        public void OnRtnFromFutureToBankByFuture(CThostFtdcRspTransferField pRspTransfer)
        {
            Console.WriteLine("OnRtnFromFutureToBankByFuture");
        }

        ///系统运行时期货端手工发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
        public void OnRtnRepealFromBankToFutureByFutureManual(CThostFtdcRspRepealField pRspRepeal)
        {
            Console.WriteLine("OnRtnRepealFromBankToFutureByFutureManual");
        }

        ///系统运行时期货端手工发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
        public void OnRtnRepealFromFutureToBankByFutureManual(CThostFtdcRspRepealField pRspRepeal)
        {
            Console.WriteLine("OnRtnRepealFromFutureToBankByFutureManual");
        }

        ///期货发起查询银行余额通知
        public void OnRtnQueryBankBalanceByFuture(CThostFtdcNotifyQueryAccountField pNotifyQueryAccount)
        {
            Console.WriteLine("OnRtnQueryBankBalanceByFuture");
        }

        ///期货发起银行资金转期货错误回报
        public void OnErrRtnBankToFutureByFuture(CThostFtdcReqTransferField pReqTransfer,
            CThostFtdcRspInfoField pRspInfo)
        {
            Console.WriteLine("OnErrRtnBankToFutureByFuture");
        }

        ///期货发起期货资金转银行错误回报
        public void OnErrRtnFutureToBankByFuture(CThostFtdcReqTransferField pReqTransfer,
            CThostFtdcRspInfoField pRspInfo)
        {
            Console.WriteLine("OnErrRtnFutureToBankByFuture");
        }

        ///系统运行时期货端手工发起冲正银行转期货错误回报
        public void OnErrRtnRepealBankToFutureByFutureManual(CThostFtdcReqRepealField pReqRepeal,
            CThostFtdcRspInfoField pRspInfo)
        {
            Console.WriteLine("OnErrRtnRepealBankToFutureByFutureManual");
        }

        ///系统运行时期货端手工发起冲正期货转银行错误回报
        public void OnErrRtnRepealFutureToBankByFutureManual(CThostFtdcReqRepealField pReqRepeal,
            CThostFtdcRspInfoField pRspInfo)
        {
            Console.WriteLine("OnErrRtnRepealFutureToBankByFutureManual");
        }

        ///期货发起查询银行余额错误回报
        public void OnErrRtnQueryBankBalanceByFuture(CThostFtdcReqQueryAccountField pReqQueryAccount,
            CThostFtdcRspInfoField pRspInfo)
        {
            Console.WriteLine("OnErrRtnQueryBankBalanceByFuture");
        }

        ///期货发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
        public void OnRtnRepealFromBankToFutureByFuture(CThostFtdcRspRepealField pRspRepeal)
        {
            Console.WriteLine("OnRtnRepealFromBankToFutureByFuture");
        }

        ///期货发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
        public void OnRtnRepealFromFutureToBankByFuture(CThostFtdcRspRepealField pRspRepeal)
        {
            Console.WriteLine("OnRtnRepealFromFutureToBankByFuture"); 
            
        }

        ///期货发起银行资金转期货应答
        public void OnRspFromBankToFutureByFuture(CThostFtdcReqTransferField pReqTransfer,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspFromBankToFutureByFuture");
        }

        ///期货发起期货资金转银行应答
        public void OnRspFromFutureToBankByFuture(CThostFtdcReqTransferField pReqTransfer,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspFromFutureToBankByFuture");
        }

        ///期货发起查询银行余额应答
        public void OnRspQueryBankAccountMoneyByFuture(CThostFtdcReqQueryAccountField pReqQueryAccount,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspQueryBankAccountMoneyByFuture");
        }

        ///银行发起银期开户通知
        public void OnRtnOpenAccountByBank(CThostFtdcOpenAccountField pOpenAccount)
        {
            Console.WriteLine("OnRtnOpenAccountByBank");
        }

        ///银行发起银期销户通知
        public void OnRtnCancelAccountByBank(CThostFtdcCancelAccountField pCancelAccount)
        {
            Console.WriteLine("OnRtnCancelAccountByBank");
        }

        ///银行发起变更银行账号通知
        public void OnRtnChangeAccountByBank(CThostFtdcChangeAccountField pChangeAccount)
        {
            Console.WriteLine("OnRtnChangeAccountByBank");
        }
    }
}
