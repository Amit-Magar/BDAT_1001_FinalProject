using BDAT_1001_FinalProject_Access.Models.DTO;

namespace BDAT_1001_FinalProject_Access.Repositories.Abstract
{
    public interface IUserAuthenticationService
    {
        Task<Status> LoginAsync(LoginModel model);
        Task LogoutAsync();
        Task<Status> RegisterAsync(RegisterModel model);
        Task<Status> ChangePasswordAsync(ChangePassword model, string username);
    }
}
