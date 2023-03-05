using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IJobMasterService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int jobId);
        Task<ServiceResponse> GetEmpWithJobId(int jobId);
        Task<ServiceResponse> Delete(int jobId);
        Task<ServiceResponse> Save(JobMasterViewModel JobMaster);
        Task<ServiceResponse> Update(JobMasterViewModel JobMaster);
    }
}
