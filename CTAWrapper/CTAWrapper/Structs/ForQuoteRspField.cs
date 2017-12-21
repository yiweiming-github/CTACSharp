using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTAWrapper.Structs
{
    public class ForQuoteRspField
    {
        public string TradingDay { get; set; }
        public string InstrumentID { get; set; }
        public string ForQuoteSysID { get; set; }
        public string ForQuoteTime { get; set; }
        public string ActionDay { get; set; }
        public string ExchangeID { get; set; }
    }
}
