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
    public class SocialWorkerService : ISocialWorkerService
    {
        private readonly IDatabaseContext _db;

        public SocialWorkerService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteSocialWorker", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetSocialWorker");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int id)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(id), id.ToString());

            var dalResponse = await _db.ExecuteQuery("GetSocialWorkerById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(SocialWorkerViewModel socialWorker)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveSocialWorker",
               _db.CreateListOfSqlParams(socialWorker, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(SocialWorkerViewModel socialWorker)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateSocialWorker",
               _db.CreateListOfSqlParams(socialWorker, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
