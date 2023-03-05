using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IJobDetailsService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int jobId);
        Task<ServiceResponse> GetByJobId(int id);
        Task<ServiceResponse> GetJobDetails(int id);
        Task<ServiceResponse> Delete(int jobId);
        Task<ServiceResponse> Save(JobDetailsViewModel JobDetails);
        Task<ServiceResponse> Update(JobDetailsViewModel JobDetails);
    }
}
