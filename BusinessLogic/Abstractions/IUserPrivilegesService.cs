using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic.Abstractions
{
    public interface IUserPrivilegesService
    {
        Task<ServiceResponse> Delete(int id);
        Task<ServiceResponse> DeleteEmpUserPrivligesOnePriv(int id);
        Task<ServiceResponse> DeleteUsersWithMenus(int id);
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetEmpUserPrivligesWithEmpId(int id);
        Task<ServiceResponse> GetById(int id);
        Task<ServiceResponse> GetUsersWithMenus();
        Task<ServiceResponse> GetUsersWithMenusWithId(int id);
        Task<ServiceResponse> Save(UserPrivilegesViewModel userPrivileges);
        Task<ServiceResponse> SaveUsersWithMenus(UserPrivilegesViewModel userPrivileges);
        Task<ServiceResponse> Update(UserPrivilegesViewModel userPrivileges);
        Task<ServiceResponse> UpdateUsersWithMenus(UserPrivilegesViewModel userPrivileges);
    }
}
