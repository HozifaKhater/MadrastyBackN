using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class UserPrivilegesViewModel
    {
      
        public int Id { get; set; }
       
        public string EmpName { get; set; } = string.Empty;
      
        public int EmpId { get; set; }

      
        public string MenuRoute { get; set; } = string.Empty;
      
        public int MenuId { get; set; }
     
        public int Read { get; set; }
      
        public int Write { get; set; }
     
        public int ReadAndWrite { get; set; }

      
        public string UserMenuName { get; set; } = string.Empty;

        public int UserId { get; set; }
      
        public string PrivName { get; set; } = string.Empty;
      
        public string PageName { get; set; } = string.Empty;
      
        public int InClassPriv { get; set; }
      
        public int DepWork { get; set; }
      
        public int JobId { get; set; }
    }
}
