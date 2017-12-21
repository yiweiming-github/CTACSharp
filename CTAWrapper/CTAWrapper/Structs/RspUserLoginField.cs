using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace CTAWrapper.Structs
{
    public class RspUserLoginField
    {
        public string TradingDay { get; set; }
        public string LoginTime { get; set; }
        public string BrokderID { get; set; }
        public string UserID { get; set; }
        public string SystemName { get; set; }
        public int FrontID { get; set; }
        public int SessionID { get; set; }
        public string MaxOrderRef { get; set; }
        public string SHFETime { get; set; }
        public string DCETime { get; set; }
        public string CZCETime { get; set; }
        public string FFEXTime { get; set; }
        public string INETime { get; set; }
    }
}
