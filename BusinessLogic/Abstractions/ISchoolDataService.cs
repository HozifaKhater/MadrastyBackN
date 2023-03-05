using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface ISchoolDataService
    {
        Task<ServiceResponse> Save(SchoolDataViewModel schoolData);
        Task<ServiceResponse> Update(SchoolDataViewModel schoolData);
        Task<ServiceResponse> Delete(int id);
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int id);
    }
}
