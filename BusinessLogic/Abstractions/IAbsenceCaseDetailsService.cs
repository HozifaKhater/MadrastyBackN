using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IAbsenceCaseDetailsService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int absenceCaseDetailsId);
        Task<ServiceResponse> GetByAbsenceCaseId(int absenceCaseId);
        Task<ServiceResponse> Delete(int absenceCaseDetailsId);
        Task<ServiceResponse> DeleteByAbsenceCaseId(int absenceCaseId);
        Task<ServiceResponse> Save(AbsenceCaseDetailsViewModel absenceCaseDetails);
        Task<ServiceResponse> Update(AbsenceCaseDetailsViewModel absenceCaseDetails);
    }
}
