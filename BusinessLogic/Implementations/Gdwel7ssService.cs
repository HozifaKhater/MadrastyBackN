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
    public class Gdwel7ssService : IGdwel7ssService
    {
        private readonly IDatabaseContext _db;

        public Gdwel7ssService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int Gdwel7ssId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Gdwel7ssId), Gdwel7ssId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteGdwel7ss", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetGdwel7ss");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int Gdwel7ssId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(Gdwel7ssId), Gdwel7ssId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetGdwel7ssById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(Gdwel7ssViewModel Gdwel7ss)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveGdwel7ss",
              _db.CreateListOfSqlParams(Gdwel7ss, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(Gdwel7ssViewModel Gdwel7ss)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateGdwel7ss",
               _db.CreateListOfSqlParams(Gdwel7ss, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
