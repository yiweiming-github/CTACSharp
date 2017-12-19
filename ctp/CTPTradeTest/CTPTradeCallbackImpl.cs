using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTPTradeTest
{
    class CTPTradeCallbackImpl : CThostFtdcTraderSpi
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

        public override void OnFrontConnected()
        {
            Console.WriteLine("OnFrontConnected");
            _isConnected = true;
        }

        public override void OnRspUserLogin(CThostFtdcRspUserLoginField pRspUserLogin, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            Console.WriteLine("OnRspUserLogin");
            _isReady = true;
        }

        public override void OnRspError(CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspError");
        }

        public override void OnFrontDisconnected(int nReason)
        {
            Console.WriteLine("OnFrontDisconnected reason: {0}", nReason);
        }

        public override void OnRspUserLogout(CThostFtdcUserLogoutField pUserLogout, CThostFtdcRspInfoField pRspInfo, int nRequestID,
            bool bIsLast)
        {
            Console.WriteLine("OnRspUserLogout");
        }

        public override void OnRtnOrder(CThostFtdcOrderField pOrder)
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

        public override void OnRspOrderInsert(CThostFtdcInputOrderField pInputOrder, CThostFtdcRspInfoField pRspInfo, int nRequestID,
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

        public override void OnRspSettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm,
            CThostFtdcRspInfoField pRspInfo, int nRequestID, bool bIsLast)
        {
            Console.WriteLine("OnRspSettlementInfoConfirm");
        }
    }
}
