using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IFailureCasesService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int failId);
        Task<ServiceResponse> Delete(int failId);
        Task<ServiceResponse> Save(FailureCasesViewModel FailureCases);
        Task<ServiceResponse> Update(FailureCasesViewModel FailureCases);
    }
}
