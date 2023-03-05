using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class SchoolPartyViewModel
    {
        public int SchPartyId { get; set; }
        [Required(ErrorMessage = "ادخل القسم المسؤول")]
        public int DepId { get; set; }

        public string DepName { get; set; } = string.Empty;

        [Required(ErrorMessage = "ادخل مناسبه الحفله")]
        public string PartyOcc { get; set; } = string.Empty;

        [Required(ErrorMessage = "ادخل تاريخ الحفله")]
        public string PartyDate { get; set; } = string.Empty;

        public int PartyDuration { get; set; }
        [Required(ErrorMessage = "ادخل مقر الحفله")]
        public string PartyLoc { get; set; } = string.Empty;

        public string PartySponsor { get; set; } = string.Empty;


        public string PartyInvitees { get; set; } = string.Empty;


        public string ExternalPart { get; set; } = string.Empty;

        public string PartyDesc { get; set; } = string.Empty;
    }
}
