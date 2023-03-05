using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IGdwel7ssService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int gdwel7ss);
        Task<ServiceResponse> Delete(int gdwel7ss);
        Task<ServiceResponse> Save(Gdwel7ssViewModel Gdwel7ss);
        Task<ServiceResponse> Update(Gdwel7ssViewModel Gdwel7ss);
    }
}
