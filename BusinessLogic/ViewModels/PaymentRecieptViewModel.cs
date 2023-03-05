using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class PaymentRecieptViewModel
    {
        public int Id { get; set; }
        public int SerialNumber { get; set; }
        public string Title { get; set; } = string.Empty;
        public string DateOfReciept { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string SchoolName { get; set; } = string.Empty;
        public int CenterNumber { get; set; }
        public int DinarValue { get; set; }
        public int FelsValue { get; set; }
        public string ClientName { get; set; } = string.Empty;
        public string TotalInArabic { get; set; } = string.Empty;
        public string CashOrCheck { get; set; } = string.Empty;
        public string BankName { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public string IdentityNumber { get; set; } = string.Empty;
        public int EmpId { get; set; }
    }
}
