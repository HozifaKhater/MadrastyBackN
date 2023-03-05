using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class JobMasterViewModel
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; } = string.Empty;
        public int JobId { get; set; }

        [Required(ErrorMessage = "ادخل اسم الوظيفه")]
        public string JobName { get; set; } = string.Empty;
        public string JobDesc { get; set; } = string.Empty;
        public int InClassPriv { get; set; }
        public int DepWork { get; set; }
    }
}
