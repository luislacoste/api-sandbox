using System;

namespace Conciliac.Common.APIResponse.Response
{
    public class ConciliacVersionResponse
    {
        public Version version { get; set; }
        public bool required { get; set; }
        public string Path { get; set; }
        public string Link { get; set; }
        public bool System32bits { get; set; }
    }
}
