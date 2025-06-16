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
            new Claim(JwtRegisteredClaimNames.Email, user.Email ?? string.Empty), 
            new Claim(JwtRegisteredClaimNames.GivenName, user.UserName ?? string.Empty),
        };

        // Create signing credentials
        var creds = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512Signature);

        // Create token descriptor
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(claims),
            Expires = DateTime.Now.AddDays(7), 
            SigningCredentials = creds,
            Issuer = _configuration["JWT:Issuer"],
            Audience = _configuration["JWT:Audience"]

        };

        // Create and write the token
        var tokenHandler = new JwtSecurityTokenHandler();
        var token = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(token);
    }
}