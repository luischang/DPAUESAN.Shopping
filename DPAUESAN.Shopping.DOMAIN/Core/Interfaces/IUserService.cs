using DPAUESAN.Shopping.DOMAIN.Core.DTO;

namespace DPAUESAN.Shopping.DOMAIN.Core.Interfaces
{
    public interface IUserService
    {
        Task<bool> Register(UserAuthRequestDTO userDTO);
        Task<UserAuthResponseDTO> Validate(string email, string password);
    }
}