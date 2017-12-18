using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace CTPMarketTest
{
    class Program
    {
        static void Main(string[] args)
        {
            const string ctpServerAddress = "tcp://ctp1-md1.citicsf.com:41213";

            var api = CThostFtdcMdApi.CreateFtdcMdApi();
            var spi = new CTPMarketCallbackImpl();
            api.RegisterSpi(spi);
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

            var codes = new string[]
            {
                "IF1801",
                "IF1803",
                "IF1806",
                "TF1803",
                "TF1806",
                "TF1809",
                "T1803",
                "T1806",
                "T1809",
                "rb1801",
                "rb1802",
                "rb1803",
                "rb1804",
                "rb1805",
                "rb1806",
                "RM805",
                "c1805"
            }; 
            api.SubscribeMarketData(codes, codes.Length);

            while (true)
            {
                Thread.Sleep(100);
            }
        }
    }
}
