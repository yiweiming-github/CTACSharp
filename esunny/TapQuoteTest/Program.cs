using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TapQuoteTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start...");

            var appInfo = new TapAPIApplicationInfo();
            appInfo.AuthCode =
                "B112F916FE7D27BCE7B97EB620206457946CED32E26C1EAC946CED32E26C1EAC946CED32E26C1EAC946CED32E26C1EAC5211AF9FEE541DDE9D6F622F72E25D5DEF7F47AA93A738EF5A51B81D8526AB6A9D19E65B41F59D6A946CED32E26C1EACCAF8D4C61E28E2B1ABD9B8F170E14F8847D3EA0BF4E191F5DCB1B791E63DC196D1576DEAF5EC563CA3E560313C0C3411B45076795F550EB050A62C4F74D5892D2D14892E812723FAC858DEBD8D4AF9410729FB849D5D8D6EA48A1B8DC67E037381A279CE9426070929D5DA085659772E24A6F5EA52CF92A4D403F9E46083F27B19A88AD99812DADA44100324759F9FD1964EBD4F2F0FB50B51CD31C0B02BB437";
            appInfo.KeyOperationLogPath = "\\log";

            int result = 0;
            var api = TapQuoteCppWrapper.CreateTapQuoteAPI(appInfo, ref result);

            var quote = new TapQuoteAPINotifyImpl();
            api.SetAPINotify(quote);

            api.SetHostAddress("222.88.40.170", 6161);
            var loginAuth = new TapAPIQuoteLoginAuth();
            loginAuth.UserNo = "";
            loginAuth.Password = "";
            loginAuth.ISModifyPassword = 'N';
            loginAuth.ISDDA = 'N';
            var err = api.Login(loginAuth);

            while (!quote.ApiReady)
            {
                Thread.Sleep(1000);
                Console.WriteLine("api not ready...");
            }

            var contracts = GetTestContracts();

            foreach (var contract in contracts)
            {
                api.SubscribeQuote(ref quote.SessionId, contract);
            }

            while (true)
            {
                Thread.Sleep(100);
            }

            Console.ReadKey();
        }

        private static List<TapAPIContract> GetTestContracts()
        {
            var contracts = new List<TapAPIContract>();

            contracts.Add(
                new TapAPIContract()
                {
                    Commodity =
                    {
                        ExchangeNo = "CFFEX",
                        CommodityType = 'F',
                        CommodityNo = "IF"
                    },
                    ContractNo1 = "1801",
                    CallOrPutFlag1 = 'N',
                    CallOrPutFlag2 = 'N'
                });

            contracts.Add(
                new TapAPIContract()
                {
                    Commodity =
                    {
                        ExchangeNo = "CFFEX",
                        CommodityType = 'F',
                        CommodityNo = "IF"
                    },
                    ContractNo1 = "1803",
                    CallOrPutFlag1 = 'N',
                    CallOrPutFlag2 = 'N'
                });

            contracts.Add(
                new TapAPIContract()
                {
                    Commodity =
                    {
                        ExchangeNo = "CFFEX",
                        CommodityType = 'F',
                        CommodityNo = "IF"
                    },
                    ContractNo1 = "1806",
                    CallOrPutFlag1 = 'N',
                    CallOrPutFlag2 = 'N'
                });

            contracts.Add(
                new TapAPIContract()
                {
                    Commodity =
                    {
                        ExchangeNo = "CFFEX",
                        CommodityType = 'F',
                        CommodityNo = "TF"
                    },
                    ContractNo1 = "1803",
                    CallOrPutFlag1 = 'N',
                    CallOrPutFlag2 = 'N'
                });

            contracts.Add(
                new TapAPIContract()
                {
                    Commodity =
                    {
                        ExchangeNo = "CFFEX",
                        CommodityType = 'F',
                        CommodityNo = "TF"
                    },
                    ContractNo1 = "1806",
                    CallOrPutFlag1 = 'N',
                    CallOrPutFlag2 = 'N'
                });

            contracts.Add(
                new TapAPIContract()
                {
                    Commodity =
                    {
                        ExchangeNo = "CFFEX",
                        CommodityType = 'F',
                        CommodityNo = "TF"
                    },
                    ContractNo1 = "1809",
                    CallOrPutFlag1 = 'N',
                    CallOrPutFlag2 = 'N'
                });

            contracts.Add(
                new TapAPIContract()
                {
                    Commodity =
                    {
                        ExchangeNo = "CFFEX",
                        CommodityType = 'F',
                        CommodityNo = "T"
                    },
                    ContractNo1 = "1803",
                    CallOrPutFlag1 = 'N',
                    CallOrPutFlag2 = 'N'
                });

            contracts.Add(
                new TapAPIContract()
                {
                    Commodity =
                    {
                        ExchangeNo = "CFFEX",
                        CommodityType = 'F',
                        CommodityNo = "T"
                    },
                    ContractNo1 = "1806",
                    CallOrPutFlag1 = 'N',
                    CallOrPutFlag2 = 'N'
                });

            contracts.Add(
                new TapAPIContract()
                {
                    Commodity =
                    {
                        ExchangeNo = "CFFEX",
                        CommodityType = 'F',
                        CommodityNo = "T"
                    },
                    ContractNo1 = "1809",
                    CallOrPutFlag1 = 'N',
                    CallOrPutFlag2 = 'N'
                });

            contracts.Add(
                new TapAPIContract()
                {
                    Commodity =
                    {
                        ExchangeNo = "CFFEX",
                        CommodityType = 'F',
                        CommodityNo = "IF"
                    },
                    ContractNo1 = "1806",
                    CallOrPutFlag1 = 'N',
                    CallOrPutFlag2 = 'N'
                });


            contracts.Add(
                new TapAPIContract()
                {
                    Commodity =
                    {
                        ExchangeNo = "SHFE",
                        CommodityType = 'F',
                        CommodityNo = "RB"
                    },
                    ContractNo1 = "1801",
                    CallOrPutFlag1 = 'N',
                    CallOrPutFlag2 = 'N'
                });

            contracts.Add(
                new TapAPIContract()
                {
                    Commodity =
                    {
                        ExchangeNo = "SHFE",
                        CommodityType = 'F',
                        CommodityNo = "RB"
                    },
                    ContractNo1 = "1802",
                    CallOrPutFlag1 = 'N',
                    CallOrPutFlag2 = 'N'
                });

            contracts.Add(
                new TapAPIContract()
                {
                    Commodity =
                    {
                        ExchangeNo = "SHFE",
                        CommodityType = 'F',
                        CommodityNo = "RB"
                    },
                    ContractNo1 = "1803",
                    CallOrPutFlag1 = 'N',
                    CallOrPutFlag2 = 'N'
                });

            contracts.Add(
                new TapAPIContract()
                {
                    Commodity =
                    {
                        ExchangeNo = "SHFE",
                        CommodityType = 'F',
                        CommodityNo = "RB"
                    },
                    ContractNo1 = "1804",
                    CallOrPutFlag1 = 'N',
                    CallOrPutFlag2 = 'N'
                });

            contracts.Add(
                new TapAPIContract()
                {
                    Commodity =
                    {
                        ExchangeNo = "SHFE",
                        CommodityType = 'F',
                        CommodityNo = "RB"
                    },
                    ContractNo1 = "1805",
                    CallOrPutFlag1 = 'N',
                    CallOrPutFlag2 = 'N'
                });

            contracts.Add(
                new TapAPIContract()
                {
                    Commodity =
                    {
                        ExchangeNo = "SHFE",
                        CommodityType = 'F',
                        CommodityNo = "RB"
                    },
                    ContractNo1 = "1806",
                    CallOrPutFlag1 = 'N',
                    CallOrPutFlag2 = 'N'
                });

            return contracts;
        }
    }
}
