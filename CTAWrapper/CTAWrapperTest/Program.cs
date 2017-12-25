using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CTACSharp.CTP.Market;
using CTAWrapper;
using CTAWrapper.CTP;
using CTAWrapper.Esunny;

namespace CTAWrapperTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MarketApiTestEsunny();
        }

        static void MarketApiTestEsunny()
        {
            var marketApiFactory = GetMarketApiFactory("esunny");

            var marketApi = marketApiFactory.CreateMarketApi();
            var callbackImpl = new MarketCallbackApiImpl();
            marketApi.RegisterCallback(callbackImpl);

            marketApi.RegisterFront("");

            marketApi.Init();

            while (!callbackImpl.IsConnected)
            {
                Thread.Sleep(100);
                Console.WriteLine("is not connected...");
            }

            var loginInfo = new CThostFtdcReqUserLoginField()
            {
                BrokerID = "",
                UserID = "",
                Password = ""
            };

            marketApi.ReqUserLogin(loginInfo);

            while (!callbackImpl.IsReady)
            {
                Thread.Sleep(100);
                Console.WriteLine("is not ready...");
            }

            var codes = new string[]
            {
                "IF1801"
            };
            marketApi.SubscribeMarketData(codes, codes.Length);

            while (true)
            {
                Thread.Sleep(100);
            }
        }

        static void MarketApiTestCTP()
        {
            var marketApiFactory = GetMarketApiFactory("ctp");

            var marketApi = marketApiFactory.CreateMarketApi();
            var callbackImpl = new MarketCallbackApiImpl();
            marketApi.RegisterCallback(callbackImpl);

            marketApi.RegisterFront("tcp://ctp1-md1.citicsf.com:41213");

            marketApi.Init();

            while (!callbackImpl.IsConnected)
            {
                Thread.Sleep(100);
                Console.WriteLine("is not connected...");
            }

            var loginInfo = new CThostFtdcReqUserLoginField()
            {
                BrokerID = "66666",
                UserID = "11782",
                Password = "358492"
            };

            marketApi.ReqUserLogin(loginInfo);

            while (!callbackImpl.IsReady)
            {
                Thread.Sleep(100);
                Console.WriteLine("is not ready...");
            }

            var codes = new string[]
            {
                "IF1801"
            };
            marketApi.SubscribeMarketData(codes, codes.Length);

            while (true)
            {
                Thread.Sleep(100);
            }
        }

        static IMarketApiFactory GetMarketApiFactory(string provider)
        {
            var name = provider.ToUpper();
            if (name == "CTP")
            {
                return new CTPMarketApiFactory();
            }
            else if (name == "ESUNNY")
            {
                var authCode =
                    "B112F916FE7D27BCE7B97EB620206457946CED32E26C1EAC946CED32E26C1EAC946CED32E26C1EAC946CED32E26C1EAC5211AF9FEE541DDE9D6F622F72E25D5DEF7F47AA93A738EF5A51B81D8526AB6A9D19E65B41F59D6A946CED32E26C1EACCAF8D4C61E28E2B1ABD9B8F170E14F8847D3EA0BF4E191F5DCB1B791E63DC196D1576DEAF5EC563CA3E560313C0C3411B45076795F550EB050A62C4F74D5892D2D14892E812723FAC858DEBD8D4AF9410729FB849D5D8D6EA48A1B8DC67E037381A279CE9426070929D5DA085659772E24A6F5EA52CF92A4D403F9E46083F27B19A88AD99812DADA44100324759F9FD1964EBD4F2F0FB50B51CD31C0B02BB437";
                var keyOperationLogPath = "\\log";
                return new EsunnyMarketApiFactory(authCode, keyOperationLogPath);
            }
            else
            {
                return null;
            }
        }
    }
}
