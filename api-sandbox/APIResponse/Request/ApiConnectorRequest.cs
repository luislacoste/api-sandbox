
using System.Collections.Generic;

namespace Conciliac.Common.APIResponse.Request
{
    public class ApiConnectorRequest
    {
        public int APIConnectorRequestID { get; set; }
        public string Name { get; set; }
        public string MethodRequest { get; set; }
        public string UrlRequest { get; set; }
        public string AuthType { get; set; }
        public string AuthToken { get; set; }
        public string AuthUser { get; set; }
        public string AuthPassword { get; set; }
        public string AuthKey { get; set; }
        public string AuthValue { get; set; }
        public string AuthAddTo { get; set; }
        public string BodyType { get; set; }
        public string BodyRawType { get; set; }
        public string BodyRawText { get; set; }
        public bool IsApiBind { get; set; }
        public int? ApiBind { get; set; }

        public ICollection<ApiConnectorParametersRequest> ApiConnectorsParametersRequest { get; set; }
    }
}
