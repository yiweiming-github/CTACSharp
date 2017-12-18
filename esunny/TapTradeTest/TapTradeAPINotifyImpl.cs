using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapTradeTest
{
    class TapTradeAPINotifyImpl : ITapTradeAPINotify
    {
        public uint SessionId;

        public bool ApiReady
        {
            get { return _apiReady; }
        }
        private bool _apiReady = false;

        public override void OnConnect()
        {
            Console.WriteLine("OnConnect");
        }

        public override void OnRspLogin(int errorCode, TapAPITradeLoginRspInfo loginRspInfo)
        {
            if (errorCode == 0)
            {
                Console.WriteLine("login successfully");
            }
            else
            {
                Console.WriteLine("login failed");
            }
        }

        public override void OnAPIReady()
        {
            Console.WriteLine("OnAPIReady");
            _apiReady = true;
        }

        public override void OnRtnOrder(TapAPIOrderInfoNotice info)
        {
            if (info != null)
            {
                if (info.ErrorCode != 0)
                {
                    Console.WriteLine("OnRtnOrder error!");
                }
                else
                {
                    if (info.SessionID == SessionId)
                    {
                        if (info.OrderInfo.ErrorCode != 0)
                        {
                            Console.WriteLine("InsertOrder failed. {0} {1}", info.OrderInfo.OrderState, info.OrderInfo.OrderNo);
                        }
                        else
                        {
                            Console.WriteLine("InsertOrder succeed. {0} {1}", info.OrderInfo.OrderState, info.OrderInfo.OrderNo);
                        }
                    }
                }
            }
        }

        public override void OnRspQryCommodity(uint sessionID, int errorCode, char isLast, TapAPICommodityInfo info)
        {
            Console.WriteLine("OnRspQryCommodity");
        }

        public override void OnDisconnect(int reasonCode)
        {
            Console.WriteLine("OnDisconnect");
        }

        public override void OnRspAccountRentInfo(uint sessionID, int errorCode, char isLast, TapAPIAccountRentInfo info)
        {
            Console.WriteLine("OnRspAccountRentInfo");
        }

        public override void OnRspChangePassword(uint sessionID, int errorCode)
        {
            Console.WriteLine("OnRspChangePassword");
        }

        public override void OnRspOrderAction(uint sessionID, uint errorCode, TapAPIOrderActionRsp info)
        {
            Console.WriteLine("OnRspOrderAction");
        }

        public override void OnRspQryAccount(uint sessionID, uint errorCode, char isLast, TapAPIAccountInfo info)
        {
            Console.WriteLine("OnRspQryAccount");
        }

        public override void OnRspQryClose(uint sessionID, int errorCode, char isLast, TapAPICloseInfo info)
        {
            Console.WriteLine("OnRspQryClose");
        }

        public override void OnRspQryContract(uint sessionID, int errorCode, char isLast, TapAPITradeContractInfo info)
        {
            Console.WriteLine("OnRspQryContract");
        }

        public override void OnRspQryDeepQuote(uint sessionID, int errorCode, char isLast, TapAPIDeepQuoteQryRsp info)
        {
            Console.WriteLine("OnRspQryDeepQuote");
        }

        public override void OnRspQryExchange(uint sessionID, int errorCode, char isLast, TapAPIExchangeInfo info)
        {
            Console.WriteLine("OnRspQryDeepQuote");
        }

        public override void OnRspQryExchangeStateInfo(uint sessionID, int errorCode, char isLast, TapAPIExchangeStateInfo info)
        {
            Console.WriteLine("OnRspQryExchangeStateInfo");
        }

        public override void OnRspQryFill(uint sessionID, int errorCode, char isLast, TapAPIFillInfo info)
        {
            Console.WriteLine("OnRspQryFill");
        }

        public override void OnRspQryFund(uint sessionID, int errorCode, char isLast, TapAPIFundData info)
        {
            Console.WriteLine("OnRspQryFund");
        }

        public override void OnRspQryOrder(uint sessionID, int errorCode, char isLast, TapAPIOrderInfo info)
        {
            Console.WriteLine("OnRspQryOrder");
        }

        public override void OnRspQryOrderProcess(uint sessionID, int errorCode, char isLast, TapAPIOrderInfo info)
        {
            Console.WriteLine("OnRspQryOrderProcess");
        }

        public override void OnRspQryPosition(uint sessionID, int errorCode, char isLast, TapAPIPositionInfo info)
        {
            Console.WriteLine("OnRspQryPosition");
        }

        public override void OnRspSetReservedInfo(uint sessionID, int errorCode, string info)
        {
            Console.WriteLine("OnRspSetReservedInfo");
        }

        public override void OnRspUpperChannelInfo(uint sessionID, int errorCode, char isLast, TapAPIUpperChannelInfo info)
        {
            Console.WriteLine("OnRspUpperChannelInfo");
        }

        public override void OnRtnClose(TapAPICloseInfo info)
        {
            Console.WriteLine("OnRtnClose");
        }

        public override void OnRtnContract(TapAPITradeContractInfo info)
        {
            Console.WriteLine("OnRtnContract");
        }

        public override void OnRtnExchangeStateInfo(TapAPIExchangeStateInfoNotice info)
        {
            Console.WriteLine("OnRtnExchangeStateInfo");
        }

        public override void OnRtnFill(TapAPIFillInfo info)
        {
            Console.WriteLine("OnRtnFill");
        }

        public override void OnRtnFund(TapAPIFundData info)
        {
            Console.WriteLine("OnRtnFund");
        }

        public override void OnRtnPosition(TapAPIPositionInfo info)
        {
            Console.WriteLine("OnRtnPosition");
        }

        public override void OnRtnPositionProfit(TapAPIPositionProfitNotice info)
        {
            Console.WriteLine("OnRtnPositionProfit");
        }

        public override void OnRtnReqQuoteNotice(TapAPIReqQuoteNotice info)
        {
            Console.WriteLine("OnRtnPositionProfit");
        }
    }
}
