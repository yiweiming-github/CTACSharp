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
            //api.Join();

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
            api.RegisterNameServer(ctpServerAddress);
            api.Init();
            api.ReqUserLogin(userLogin, requestId++);

            while (!spi.IsReady)
            {
                Thread.Sleep(100);
                Console.WriteLine("is not ready...");
            }

            var codes = new string[]
            {
                "RB1801",
                "IF1803",
                "TF1803"
            };
            api.SubscribeMarketData(codes, codes.Length);

            while (true)
            {
                Thread.Sleep(100);
            }
        }
    }
}
