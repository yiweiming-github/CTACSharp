using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTAWrapper.Esunny
{
    public class EsunnyMarketApiFactory : IMarketApiFactory
    {
        public EsunnyMarketApiFactory(string authCode, string keyOperationLogPath)
        {
            _authCode = authCode;
            _keyOperationLogPath = keyOperationLogPath;
        }

        public IMarketApi CreateMarketApi()
        {
            var appInfo = new TapAPIApplicationInfo()
            {
                AuthCode = _authCode,
                KeyOperationLogPath = _keyOperationLogPath
            };
            int result = 0;
            _api = TapQuoteCppWrapper.CreateTapQuoteAPI(appInfo, ref result);
            return new EsunnyMarketApi(_api);
        }

        public IMarketCallbackMapping CreateMarketCallbackMapping()
        {
            return new EsunnyMarketCallbackMapping();
        }

        private string _authCode;
        private string _keyOperationLogPath;
        private ITapQuoteAPI _api;
    }
}
