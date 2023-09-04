using SoulmateSeeker.Entities;

namespace SoulmateSeeker.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
