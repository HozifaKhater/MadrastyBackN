using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ViewModels
{
    public class GroupMeetingViewModel
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; } = string.Empty;
        public int MeetingNo { get; set; }
        public string MeetingDate { get; set; } = string.Empty;
        public int MeetingMemNo { get; set; }
        public string MeetingLoc { get; set; } = string.Empty;
        public string ImporRecomm { get; set; } = string.Empty;
        public string BusTable { get; set; } = string.Empty;

        public int MeetingTypeId { get; set; }
        public string MeetingTypeName { get; set; } = string.Empty;
        public int DepId { get; set; }
        public string DepName { get; set; } = string.Empty;
        public int SubjectId { get; set; }
        public string SubjectName { get; set; } = string.Empty;
        public string Course { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Route { get; set; } = string.Empty;
    }
}
