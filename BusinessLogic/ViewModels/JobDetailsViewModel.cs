using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class JobDetailsViewModel
    {
        public int EmpId { get; set; }
        public string EmpNme { get; set; } = string.Empty;
        public int PrivId { get; set; }
        public int JobId { get; set; }
        public int MenuId { get; set; }
        public string UserMenuName { get; set; } = string.Empty;
        public string PageName { get; set; } = string.Empty;
        public string PrivName { get; set; } = string.Empty;
        public int PrivDefId { get; set; }
        public int InClassPriv { get; set; }
        public int DepWork { get; set; }
    }
}
