using DPAUESAN.Shopping.DOMAIN.Core.Entities;
using DPAUESAN.Shopping.DOMAIN.Core.Settings;

namespace DPAUESAN.Shopping.DOMAIN.Core.Interfaces
{
    public interface IJWTFactory
    {
        JWTSettings _settings { get; }

        string GenerateJWToken(User user);
    }
}