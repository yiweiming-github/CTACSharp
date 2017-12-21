using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTAWrapper.CTP
{
    public class CTPMarketApiFactory : IMarketApiFactory
    {
        public IMarketApi CreateMarketApi()
        {
            _api = CThostFtdcMdApi.CreateFtdcMdApi();
            return new CTPMarketApi(_api);
        }

        public IMarketCallbackMapping CreateMarketCallbackMapping()
        {
            return new CTPMarketCallbackMapping();
        }

        private string _authCode;
        private string _keyOperationLogPath;
        private CThostFtdcMdApi _api;
    }
}
