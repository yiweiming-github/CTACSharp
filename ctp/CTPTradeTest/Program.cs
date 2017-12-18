using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CTPTradeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start testing CTP Trade API");
            const string ctpServerAddress = "tcp://ctpfz1-front1.citicsf.com:51205";
            var api = CThostFtdcTraderApi.CreateFtdcTraderApi();
            var spi = new CTPTradeCallbackImpl();
            api.RegisterSpi(spi);

            api.SubscribePrivateTopic(THOST_TE_RESUME_TYPE.THOST_TERT_QUICK);
            api.SubscribePublicTopic(THOST_TE_RESUME_TYPE.THOST_TERT_QUICK);
            api.RegisterFront(ctpServerAddress);
            api.Init();

            while (!spi.IsConnected)
            {
                Thread.Sleep(100);
                Console.WriteLine("is not connected...");
            }

            var userLogin = new CThostFtdcReqUserLoginField();
            userLogin.BrokerID = "66666";
            userLogin.UserID = "11782";
            userLogin.Password = "358492";

            int requestId = 0;

            api.ReqUserLogin(userLogin, requestId++);

            while (!spi.IsReady)
            {
                Thread.Sleep(100);
                Console.WriteLine("is not ready...");
            }

            var order = new CThostFtdcInputOrderField();
            order.BrokerID = userLogin.BrokerID;
            order.InvestorID = userLogin.UserID;
            order.InstrumentID = "IF1803";
            order.OrderRef = spi.GetNextOrderRef();
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

            api.ReqOrderInsert(order, order.RequestID);

            while (true)
            {
                Thread.Sleep(100);
            }
        }
    }
}
