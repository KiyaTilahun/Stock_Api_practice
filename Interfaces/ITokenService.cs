using AspApi.Models;

namespace AspApi.Interfaces;

public interface ITokenService
{
    string CreateToken(User user);
}