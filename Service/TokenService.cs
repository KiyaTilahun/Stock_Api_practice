using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AspApi.Interfaces;
using AspApi.Models;
using Microsoft.IdentityModel.Tokens;

namespace AspApi.Service;

public class TokenService: ITokenService
{
    
    private readonly IConfiguration _configuration;
    private readonly SymmetricSecurityKey _key;
    public TokenService(IConfiguration configuration)
    {
        _configuration = configuration;
        _key=new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:SigningKey"]));
        
    }
    public string CreateToken(User user)
    {
        var claims = new List<Claim>
        {
            new Claim(JwtRegisteredClaimNames.Email, user.Email),
            new Claim(JwtRegisteredClaimNames.GivenName, user.UserName),
        };
    }
}