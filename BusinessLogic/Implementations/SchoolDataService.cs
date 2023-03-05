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
    public class SchoolDataService : ISchoolDataService
    {
        private readonly IDatabaseContext _db;

        public SchoolDataService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int SchoolDataId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(SchoolDataId), SchoolDataId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteSchoolData", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetSchoolData");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int SchoolDataId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(SchoolDataId), SchoolDataId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetSchoolDataById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(SchoolDataViewModel SchoolData)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveSchoolData",
              _db.CreateListOfSqlParams(SchoolData, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(SchoolDataViewModel SchoolData)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateSchoolData",
               _db.CreateListOfSqlParams(SchoolData, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
