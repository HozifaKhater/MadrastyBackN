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
    public class FailureCasesService : IFailureCasesService
    {
        private readonly IDatabaseContext _db;

        public FailureCasesService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int FailureCasesId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(FailureCasesId), FailureCasesId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteFailureCases", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetFailureCases");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int FailureCasesId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(FailureCasesId), FailureCasesId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetFailureCasesById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(FailureCasesViewModel FailureCases)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveFailureCases",
              _db.CreateListOfSqlParams(FailureCases, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(FailureCasesViewModel FailureCases)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateFailureCases",
               _db.CreateListOfSqlParams(FailureCases, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
