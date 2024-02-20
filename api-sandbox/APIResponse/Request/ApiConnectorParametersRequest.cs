
namespace Conciliac.Common.APIResponse.Request
{
    public class ApiConnectorParametersRequest
    {
        public int APIConnectorParameterRequestID { get; set; }
        public string ApiKey { get; set; }
        public string ApiValue { get; set; }
        public string ApiDescription { get; set; }
        public bool ApiDynamic { get; set; }
        public string ApiPage { get; set; }
    }
}
