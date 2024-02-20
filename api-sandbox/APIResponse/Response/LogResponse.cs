using System;

namespace Conciliac.Common.APIResponse.Response
{
    public class LogResponse
    {
        public int LogID { get; set; }

        public string UserID { get; set; }

        public string Message { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int LogTypeID { get; set; }
        public LogType LogType { get; set; }

        public int InternalRecords { get; set; }

        public int ExternalRecords { get; set; }

        public int ReconciliedInternalRecords { get; set; }

        public int ReconciliedExternalRecords { get; set; }

        public decimal AmountInternalSource { get; set; }

        public decimal AmountExternalSource { get; set; }

        public int RuleID { get; set; }
        public int RuleStepID { get; set; }
        public int ExecutionID { get; set; }
        public int TaskExecutionID { get; set; }
        public int Order { get; set; }
        public string Description { get; set; }
        public int SentWeb { get; set; }
    }

    public enum LogType
    {
        Error = 1,
        Login = 2,
        Logout = 3,
        ReconciliationStep = 4,
        PDFProcessing = 5,
        ExportInformation = 6,
        ManualReconciliation = 7,
        OpenRuleSet = 8,
        ConversionSEL = 9,
        Duda = 10,
        ModificacionPermisos = 13,
        EditRuleSet = 14,
        GrabacionResultadosConciliacion = 15,
        GuardoUnCNC = 16,
        AbrioUnCNC = 17,
        ImportaInformacionERP = 19,
        ExportaInformacionERP = 20,
        AperturaSEL = 21,
        NoConversionSEL = 22,
        LoginWeb = 23,
        LogoutWeb = 34,
        BalanceReport = 35,
        GetDataFromDBConnector = 36,
        SaveDataToDBConnector = 37,
        Zendesk = 38,
    }
}
