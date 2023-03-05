using BusinessLogic.Responses;
using BusinessLogic.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Abstractions
{
    public interface IGoodBadStudentsCardService
    {
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int goodBadStudentsCard);
        Task<ServiceResponse> Delete(int goodBadStudentsCard);
        Task<ServiceResponse> Save(GoodBadStudentsCardViewModel GoodBadStudentsCard);
        Task<ServiceResponse> Update(GoodBadStudentsCardViewModel GoodBadStudentsCard);
    }
}
