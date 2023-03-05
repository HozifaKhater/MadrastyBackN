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
    public class PaymentRecieptService : IPaymentRecieptService
    {
        private readonly IDatabaseContext _db;

        public PaymentRecieptService(IDatabaseContext db)
        {
            _db = db;
        }

        public async Task<ServiceResponse> Delete(int PaymentRecieptId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(PaymentRecieptId), PaymentRecieptId.ToString());

            var dalResponse = await _db.ExecuteQuery("DeletePaymentReciept", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Get()
        {
            var dalResponse = await _db.ExecuteQuery("GetPaymentReciept");
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> GetById(int PaymentRecieptId)
        {
            var pars = new Dictionary<string, string>();
            pars.Add(nameof(PaymentRecieptId), PaymentRecieptId.ToString());

            var dalResponse = await _db.ExecuteQuery("GetPaymentRecieptById", pars);
            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Save(PaymentRecieptViewModel PaymentReciept)
        {
            var dalResponse = await _db.ExecuteNonQuery("SavePaymentReciept",
              _db.CreateListOfSqlParams(PaymentReciept, new List<string>() { "Id" }));

            return new ServiceResponse(dalResponse);
        }

        public async Task<ServiceResponse> Update(PaymentRecieptViewModel PaymentReciept)
        {
            var dalResponse = await _db.ExecuteNonQuery("UpdatePaymentReciept",
               _db.CreateListOfSqlParams(PaymentReciept, new List<string>()));

            return new ServiceResponse(dalResponse);
        }
    }
}
