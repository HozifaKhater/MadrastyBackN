using BusinessLogic.Abstractions;
using BusinessLogic.Contexts;
using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Implementations
{
    public class GroupMeetingService : IGroupMeetingService
    {
        private readonly IDatabaseContext _db;

        public GroupMeetingService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int GroupMeetingId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(GroupMeetingId), GroupMeetingId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteGroupMeeting", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetGroupMeeting");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int GroupMeetingId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(GroupMeetingId), GroupMeetingId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetGroupMeetingById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(GroupMeetingViewModel GroupMeeting)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveGroupMeeting",
              _db.CreateListOfSqlParams(GroupMeeting, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(GroupMeetingViewModel GroupMeeting)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateGroupMeeting",
               _db.CreateListOfSqlParams(GroupMeeting, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
