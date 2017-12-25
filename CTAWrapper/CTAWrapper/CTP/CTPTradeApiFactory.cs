using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTACSharp.CTP.Trade;

namespace CTAWrapper.CTP
{
    public class CTPTradeApiFactory : ITradeApiFactory
    {
        public ITradeApi CreateTradeApi()
        {
            _api = CThostFtdcTraderApi.CreateFtdcTraderApi();
            return new CTPTradeApi(_api);
        }

        public ITradeCallbackMapping CreateTradeCallbackMapping()
        {
            return new CTPTradeCallbackMapping();
        }


        private CThostFtdcTraderApi _api;
    }
}
