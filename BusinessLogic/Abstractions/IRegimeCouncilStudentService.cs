using BusinessLogic.Responses;
using BusinessLogic.ViewModels;

namespace BusinessLogic.Abstractions
{
    public interface IRegimeCouncilStudentService
    {
        Task<ServiceResponse> Save(RegimeCouncilStudentViewModel regimeCouncilStudent);
        Task<ServiceResponse> Update(RegimeCouncilStudentViewModel regimeCouncilStudent);
        Task<ServiceResponse> Delete(int id);
        Task<ServiceResponse> Get();
        Task<ServiceResponse> GetById(int id);
    }
}
