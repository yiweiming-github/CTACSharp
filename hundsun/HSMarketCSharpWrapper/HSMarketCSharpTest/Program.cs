using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTACSharp.HS.Market;

namespace HSMarketCSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var lpMdApi = HSMarketCppWrapper.NewMdApi("./log/");

            var lpMdSpi = new HSMdSpiImpl();
            lpMdApi.RegisterSpi(lpMdSpi);
            lpMdApi.RegisterFront("tcp://101.71.12.155:9006");
            lpMdApi.Init("license_3rd.dat");
            lpMdApi.Join();
        }
    }
}
