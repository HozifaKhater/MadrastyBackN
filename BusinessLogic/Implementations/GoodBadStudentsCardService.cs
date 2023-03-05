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
    public class GoodBadStudentsCardService : IGoodBadStudentsCardService
    {
        private readonly IDatabaseContext _db;

        public GoodBadStudentsCardService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int GoodBadStudentsCardId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(GoodBadStudentsCardId), GoodBadStudentsCardId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteGoodBadStudentsCard", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetGoodBadStudentsCard");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int GoodBadStudentsCardId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(GoodBadStudentsCardId), GoodBadStudentsCardId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetGoodBadStudentsCardById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(GoodBadStudentsCardViewModel GoodBadStudentsCard)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveGoodBadStudentsCard",
              _db.CreateListOfSqlParams(GoodBadStudentsCard, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(GoodBadStudentsCardViewModel GoodBadStudentsCard)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateGoodBadStudentsCard",
               _db.CreateListOfSqlParams(GoodBadStudentsCard, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
