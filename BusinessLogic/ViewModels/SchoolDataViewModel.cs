using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class SchoolDataViewModel
    {
        public int SchoolId { get; set; }
        public string SchoolMan { get; set; } = string.Empty;
        public string SchoolAssis1 { get; set; } = string.Empty;
        public string SchoolAssis2 { get; set; } = string.Empty;
        public string SchoolAssis3 { get; set; } = string.Empty;
        public string SchoolAssis4 { get; set; } = string.Empty;
        public string SchoolBdala { get; set; } = string.Empty;
        public string SchoolFaks { get; set; } = string.Empty;
        public string SchoolAddr { get; set; } = string.Empty;
        public string SchoolDir { get; set; } = string.Empty;
        public string SchoolLogo { get; set; } = string.Empty;
        public string SchoolName { get; set; } = string.Empty;
        public int SchoolAssis1Id { get; set; }
        public int SchoolAssis2Id { get; set; }
        public int SchoolAssis3Id { get; set; }
        public int SchoolAssis4Id { get; set; }
        public int SchoolManId { get; set; }
    }
}
