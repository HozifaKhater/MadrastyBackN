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
    public class SchoolPartyService : ISchoolPartyService
    {
        private readonly IDatabaseContext _db;

        public SchoolPartyService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int SchoolPartyId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(SchoolPartyId), SchoolPartyId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteSchoolParty", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetSchoolParty");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int SchoolPartyId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(SchoolPartyId), SchoolPartyId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetSchoolPartyById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(SchoolPartyViewModel SchoolParty)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveSchoolParty",
              _db.CreateListOfSqlParams(SchoolParty, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(SchoolPartyViewModel SchoolParty)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateSchoolParty",
               _db.CreateListOfSqlParams(SchoolParty, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
