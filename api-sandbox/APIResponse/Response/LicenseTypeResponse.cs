
namespace Conciliac.Common.APIResponse.Response
{
    public class LicenseTypeResponse
    {
        public int LicenseTypeId { get; set; }
        public string Name { get; set; }
        public WorkflowRole WorkflowRole { get; set; }
    }

    public enum WorkflowRole
    {
        Administrator = 1,
        Editor = 2,
        Reconciliator = 3,
        Approver = 4,
        Analyst = 5,
        Reviewer = 6,
        Editor360 = 7
    }
}
