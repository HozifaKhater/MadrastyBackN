using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class AbsenceViewModel
    {
        public int AbsenceId { get; set; }
        public string AbsenceLevel { get; set; } = string.Empty;
        public string AbsenceClass { get; set; } = string.Empty;
        public string AbsenceDate { get; set; } = string.Empty;
        public int AbsenceStudentId { get; set; }
        public string AbsenceStudentName { get; set; } = string.Empty;
    }
}
