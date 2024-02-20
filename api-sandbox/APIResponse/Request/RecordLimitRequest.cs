using Conciliac.Common.Constants;
using System;

namespace Conciliac.Common.APIResponse.Request
{
    public class RecordLimitRequest
    {
        public int Count { get; set; }
        public DateTime When { get; set; }
        public int CompanyId { get; set; }
        public string LicenseId { get; set; }
        public string Process { get; set; }
        public int ExecutionId { get; set; }
        public ActionRecordControl Action { get; set; }
    }
}
