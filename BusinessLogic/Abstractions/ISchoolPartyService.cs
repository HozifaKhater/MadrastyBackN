using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ISchoolPartyService
    {
        Task<ServiceResponse> Delete(int schPartyId);
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int schPartyId);
        Task<ServiceResponse> Save(SchoolPartyViewModel SchoolParty);
        Task<ServiceResponse> Update(SchoolPartyViewModel SchoolParty);
    }
}
