using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CTACSharp.CTP.Trade;
using CTAWrapper;
using CTAWrapper.CTP;
using CTAWrapper.Esunny;

namespace CTAWrapperTradeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CTAWrapperTradeTestCTP();
        }

        static void CTAWrapperTradeTestCTP()
        {
            var tradeApiFactory = GetTradeApiFactory("ctp");

            var tradeApi = tradeApiFactory.CreateTradeApi();
            var callbackImpl = new TradeCallbackApiImpl();
            tradeApi.RegisterCallback(callbackImpl);

            const string ctpServerAddress = "tcp://ctpfz1-front1.citicsf.com:51205";

            tradeApi.SubscribePrivateTopic(THOST_TE_RESUME_TYPE.THOST_TERT_QUICK);
            tradeApi.SubscribePublicTopic(THOST_TE_RESUME_TYPE.THOST_TERT_QUICK);
            tradeApi.RegisterFront(ctpServerAddress);
            tradeApi.Init();

            while (!callbackImpl.IsConnected)
            {
                Thread.Sleep(100);
                Console.WriteLine("is not connected...");
            }

            var userLogin = new CThostFtdcReqUserLoginField();
            userLogin.BrokerID = "66666";
            userLogin.UserID = "11782";
            userLogin.Password = "358492";

            int requestId = 0;

            tradeApi.ReqUserLogin(userLogin, requestId++);

            while (!callbackImpl.IsReady)
            {
                Thread.Sleep(100);
                Console.WriteLine("is not ready...");
            }

            Thread.Sleep(1100);

            var settlementConfirm = new CThostFtdcSettlementInfoConfirmField()
            {
                BrokerID = userLogin.BrokerID,
                InvestorID = userLogin.UserID
            };
            tradeApi.ReqSettlementInfoConfirm(settlementConfirm, requestId++);

            Thread.Sleep(3000);

            var order = new CThostFtdcInputOrderField();
            order.BrokerID = userLogin.BrokerID;
            order.InvestorID = userLogin.UserID;
            order.InstrumentID = "IF1803";
            order.OrderRef = callbackImpl.GetNextOrderRef();
            order.UserID = userLogin.UserID;
            order.Direction = '0';
            order.CombOffsetFlag = "0";
            order.CombHedgeFlag = "1";
            order.LimitPrice = 4000.0;
            order.VolumeTotalOriginal = 1;
            order.VolumeCondition = '1';
            order.MinVolume = 1;
            order.ForceCloseReason = '0';
            order.IsAutoSuspend = 0;
            order.UserForceClose = 0;
            order.GTDDate = "";
            order.ContingentCondition = '1';
            order.OrderPriceType = '2';
            order.TimeCondition = '3';
            order.StopPrice = 0;
            order.RequestID = requestId++;

            tradeApi.ReqOrderInsert(order, order.RequestID);

            while (true)
            {
                Thread.Sleep(100);
            }
        }

        static ITradeApiFactory GetTradeApiFactory(string provider)
        {
            var name = provider.ToUpper();
            if (name == "CTP")
            {
                return new CTPTradeApiFactory();
            }
            //else if (name == "ESUNNY")
            //{
            //    var authCode =
            //        "B112F916FE7D27BCE7B97EB620206457946CED32E26C1EAC946CED32E26C1EAC946CED32E26C1EAC946CED32E26C1EAC5211AF9FEE541DDE9D6F622F72E25D5DEF7F47AA93A738EF5A51B81D8526AB6A9D19E65B41F59D6A946CED32E26C1EACCAF8D4C61E28E2B1ABD9B8F170E14F8847D3EA0BF4E191F5DCB1B791E63DC196D1576DEAF5EC563CA3E560313C0C3411B45076795F550EB050A62C4F74D5892D2D14892E812723FAC858DEBD8D4AF9410729FB849D5D8D6EA48A1B8DC67E037381A279CE9426070929D5DA085659772E24A6F5EA52CF92A4D403F9E46083F27B19A88AD99812DADA44100324759F9FD1964EBD4F2F0FB50B51CD31C0B02BB437";
            //    var keyOperationLogPath = "\\log";
            //    return new EsunnyMarketApiFactory(authCode, keyOperationLogPath);
            //}
            else
            {
                return null;
            }
        }
    }
}
