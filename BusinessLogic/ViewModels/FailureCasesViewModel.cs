using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class FailureCasesViewModel
    {
        public int FailId { get; set; }
        public string FailLev { get; set; } = string.Empty;
        public string FailClass { get; set; } = string.Empty;
        public string FailStudent { get; set; } = string.Empty;
        public string FailNation { get; set; } = string.Empty;
        public string FailMob { get; set; } = string.Empty;
        public string FailBirth { get; set; } = string.Empty;
        public string FailDate { get; set; } = string.Empty;
        public string FailDesc { get; set; } = string.Empty;
        public string FailReason { get; set; } = string.Empty;
        public string FailSub { get; set; } = string.Empty;
        public string Fail1 { get; set; } = string.Empty;
        public string Fail2 { get; set; } = string.Empty;
        public string Fail3 { get; set; } = string.Empty;
        public string Fail4 { get; set; } = string.Empty;
        public int FailEndYear { get; set; }
        public string FailSit { get; set; } = string.Empty;
        public string FailEffDate { get; set; } = string.Empty;
        public string FailEffResults { get; set; } = string.Empty;
        public string FailRecomm { get; set; } = string.Empty;
        public string StudentName { get; set; } = string.Empty;
    }
}
