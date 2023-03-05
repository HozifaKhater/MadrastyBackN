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
    public class RegimeCouncilStudentService : IRegimeCouncilStudentService
    {
        private readonly IDatabaseContext _db;

        public RegimeCouncilStudentService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int RegimeCouncilStudentId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(RegimeCouncilStudentId), RegimeCouncilStudentId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeleteRegimeCouncilStudent", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetRegimeCouncilStudent");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int RegimeCouncilStudentId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(RegimeCouncilStudentId), RegimeCouncilStudentId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetRegimeCouncilStudentById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(RegimeCouncilStudentViewModel RegimeCouncilStudent)
        {
            var dalResponse = await _db.ExecuteNonQuery("SaveRegimeCouncilStudent",
              _db.CreateListOfSqlParams(RegimeCouncilStudent, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(RegimeCouncilStudentViewModel RegimeCouncilStudent)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdateRegimeCouncilStudent",
               _db.CreateListOfSqlParams(RegimeCouncilStudent, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
