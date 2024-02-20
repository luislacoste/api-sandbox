using System;

namespace Conciliac.Common.APIResponse.Response
{
    public class RecordLimitResponse
    {
        public int RecordsBySource { get; set; }
        public int RecordsConsumed { get; set; }
        public int AvailableRecords { get; set; }
        public int MonthlyRecords { get; set; }
        public DateTime CutoffDate { get; set; }
    }
}
