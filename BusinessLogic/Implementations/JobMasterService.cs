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
    public class JobMasterService : IJobMasterService
    {
        private readonly IDatabaseContext _db;

        public JobMasterService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int jobId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(jobId), jobId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteJobMaster", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetJobMaster");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int jobId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(jobId), jobId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetJobMasterById", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> GetEmpWithJobId(int jobId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(jobId), jobId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetEmpWithJobId", pars);
            return new ServiceResponse(dalResponse);
        }
        public async Task<ServiceResponse> Save(JobMasterViewModel JobMaster)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveJobMaster",
              _db.CreateListOfSqlParams(JobMaster, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(JobMasterViewModel JobMaster)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateJobMaster",
               _db.CreateListOfSqlParams(JobMaster, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
