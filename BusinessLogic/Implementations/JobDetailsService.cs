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
    public class JobDetailsService : IJobDetailsService
    {
        private readonly IDatabaseContext _db;

        public JobDetailsService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int JobDetailsId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(JobDetailsId), JobDetailsId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteJobDetails", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetJobDetails");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int JobDetailsId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(JobDetailsId), JobDetailsId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetJobDetailsById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(JobDetailsViewModel JobDetails)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveJobDetails",
              _db.CreateListOfSqlParams(JobDetails, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(JobDetailsViewModel JobDetails)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateJobDetails",
               _db.CreateListOfSqlParams(JobDetails, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
