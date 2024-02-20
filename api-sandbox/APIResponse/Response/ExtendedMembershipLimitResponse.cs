using System;

namespace Conciliac.Common.APIResponse.Response
{
    public class ExtendedMembershipLimitResponse
    {
        public int ExtendedMembershipLimitId { get; set; }
        public string UserId { get; set; }
        public int ExtensionQuantity { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool Active { get; set; }
    }
}
