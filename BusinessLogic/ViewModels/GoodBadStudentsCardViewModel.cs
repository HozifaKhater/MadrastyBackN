using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class GoodBadStudentsCardViewModel
    {
        public int StudentCardId { get; set; }
        public int GoodCardId { get; set; }
        public int BadCardId { get; set; }
        public int GradeId { get; set; }
        public string GardeName { get; set; } = string.Empty;
        public int class_id { get; set; }
        public string class_name { get; set; } = string.Empty;
        public int subject_id { get; set; }
        public string subject_name { get; set; } = string.Empty;
        public int student_id { get; set; }
        public string student_name { get; set; } = string.Empty;
        public string good_ebda3 { get; set; } = string.Empty;
        public string good_tahfeez { get; set; } = string.Empty;
        public string good_result { get; set; } = string.Empty;
        public string bad_da3f { get; set; } = string.Empty;
        public string bad_da3f_reasons { get; set; } = string.Empty;
        public string bad_cure_ways { get; set; } = string.Empty;
        public string bad_result { get; set; } = string.Empty;

        public int civil_id { get; set; }
    }
}
