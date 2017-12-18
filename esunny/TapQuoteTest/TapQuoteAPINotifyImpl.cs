using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapQuoteTest
{
    class TapQuoteAPINotifyImpl : ITapQuoteAPINotify
    {
        public uint SessionId;

        public bool ApiReady
        {
            get { return _apiReady; }
        }
        private bool _apiReady = false;

        public override void OnAPIReady()
        {
            Console.WriteLine("API ready");
            _apiReady = true;
        }

        public override void OnRspLogin(int errorCode, TapAPIQuotLoginRspInfo info)
        {
            if (errorCode == 0)
            {
                Console.WriteLine("Login successfully.");
            }
            else
            {
                Console.WriteLine("Login failed. {0}", errorCode);
            }
        }

        public override void OnRspSubscribeQuote(uint sessionID, int errorCode, char isLast, TapAPIQuoteWhole info)
        {
            if (errorCode == 0)
            {
                Console.WriteLine("subscribe successfully.");
                Console.WriteLine("{0} {1} {2} {3} {4} {5}",
                    info.DateTimeStamp,
                    info.Contract.Commodity.ExchangeNo,
                    info.Contract.Commodity.CommodityType,
                    info.Contract.Commodity.CommodityNo,
                    info.Contract.ContractNo1,
                    info.QLastPrice);
            }
            else
            {
                Console.WriteLine("subscribe failed. {0}", errorCode);
            }
        }

        public override void OnRtnQuote(TapAPIQuoteWhole info)
        {
            if (info != null)
            {
                Console.WriteLine("new quote: {0} {1} {2} {3} {4} {5}",
                    info.DateTimeStamp,
                    info.Contract.Commodity.ExchangeNo,
                    info.Contract.Commodity.CommodityType,
                    info.Contract.Commodity.CommodityNo,
                    info.Contract.ContractNo1,
                    info.QLastPrice);
            }
        }
    }
}
