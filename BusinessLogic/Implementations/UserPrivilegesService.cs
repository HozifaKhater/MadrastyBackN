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
    public class UserPrivilegesService : IUserPrivilegesService
    {
        private readonly IDatabaseContext _db;

        public UserPrivilegesService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int UserPrivilegesId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(UserPrivilegesId), UserPrivilegesId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteUserPrivileges", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> DeleteEmpUserPrivligesOnePriv(int UserPrivilegesId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(UserPrivilegesId), UserPrivilegesId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteEmpUserPrivligesOnePriv", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> DeleteUsersWithMenus(int UserPrivilegesId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(UserPrivilegesId), UserPrivilegesId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteUsersWithMenus", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetUserPrivileges");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetUsersWithMenus()
        {
            var dalResponse = await _db.ExecuteQuery("GetUsersWithMenus");
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetById(int UserPrivilegesId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(UserPrivilegesId), UserPrivilegesId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetUserPrivilegesById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetEmpUserPrivligesWithEmpId(int UserPrivilegesId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(UserPrivilegesId), UserPrivilegesId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetEmpUserPrivligesWithEmpId", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetUsersWithMenusWithId(int UserPrivilegesId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(UserPrivilegesId), UserPrivilegesId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetUsersWithMenusWithId", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> Save(UserPrivilegesViewModel UserPrivileges)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveUserPrivileges",
              _db.CreateListOfSqlParams(UserPrivileges, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> SaveUsersWithMenus(UserPrivilegesViewModel UserPrivileges)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveUsersWithMenus",
              _db.CreateListOfSqlParams(UserPrivileges, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> Update(UserPrivilegesViewModel UserPrivileges)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateUserPrivileges",
               _db.CreateListOfSqlParams(UserPrivileges, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> UpdateUsersWithMenus(UserPrivilegesViewModel UserPrivileges)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateUsersWithMenus",
               _db.CreateListOfSqlParams(UserPrivileges, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
