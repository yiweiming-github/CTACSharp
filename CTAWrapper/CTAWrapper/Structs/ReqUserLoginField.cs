using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTAWrapper.Structs
{
    public class ReqUserLoginField
    {
        public string TradingDay { get; set; }
        public string BrokerID { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public string UserProductInfo { get; set; }
        public string InterfaceProductInfo { get; set; }
        public string ProtocolInfo { get; set; }
        public string MacAddress { get; set; }
        public string OneTimePassword { get; set; }
        public string ClientIPAddress { get; set; }
    }
}
