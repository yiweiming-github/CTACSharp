using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTACSharp.HS.Trade;

namespace HSTradeCSharpTest
{
    class Program
    {
        public static int RequestId = 0;
        static void Main(string[] args)
        {
            var lpTradeApi = HSTradeCppWrapper.NewTradeApi("./log/");
            var lpTradeSpi = new HSTradeSpiImpl(lpTradeApi);
            lpTradeApi.RegisterSpi(lpTradeSpi);
            lpTradeApi.RegisterFront("tcp://101.71.12.155:9006");
            lpTradeApi.Init("./license_3rd.dat");

            

            lpTradeApi.Join();
        }
    }
}
