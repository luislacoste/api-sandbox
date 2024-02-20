using System;
using System.Collections.Generic;

namespace Conciliac.Common.APIResponse.Response
{
    public class UserResponse
    {
        public string UserID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Language { get; set; }
        public string Password { get; set; }
        public int LicenseTypeId { get; set; }
        public int ValidDays { get; set; }
        public string PC { get; set; }
        public bool Active { get; set; }
        public DateTime? LastConnection { get; set; }
        public DateTime? LastConnectionWeb { get; set; }
        public LicenseTypeResponse LicenseType { get; set; }
        public bool HasWorkflow { get; set; }
        public bool HasRPA { get; set; }
        public bool HasDbConnector { get; set; }
        public bool OnlyDatamatchForAmex { get; set; }
        public bool OnlyDatamatch { get; set; }
        public string RecordLimit { get; set; }
        public List<ExtendedMembershipLimitResponse> ExtendendLimit { get; set; }
        public bool AdEnabled { get; set; }
    }
}
