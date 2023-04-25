using WebApi.Models;

namespace WebApi.Repository
{
    public interface IAccountRepository
    {
        Task<LoginResponseModel> SignUp(Register model);
        Task<LoginResponseModel> Login(Login model);
    }
}
