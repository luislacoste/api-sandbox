
namespace Conciliac.Common.APIResponse.Request
{
    public class ParametersInstallationInfo
    {
        public string Ip { get; set; }
        public string Culture { get; set; }
        public string NameOs { get; set; }
        public string VersionOs { get; set; }
        public string ArchitectureOs { get; set; }
        public string VersionConciliac { get; set; }
        public string Ram { get; set; }
        public string ProcessorName { get; set; }
        public string ConnectionString { get; set; }
        public string AzureAdEnabled { get; set; }
    }
}
