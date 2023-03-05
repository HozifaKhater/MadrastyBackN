using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IGroupMeetingService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int groupMeeting);
        Task<ServiceResponse> Delete(int groupMeeting);
        Task<ServiceResponse> Save(GroupMeetingViewModel GroupMeeting);
        Task<ServiceResponse> Update(GroupMeetingViewModel GroupMeeting);
    }
}
