using Microsoft.AspNetCore.Identity;

namespace AspApi.Models;


public class User:IdentityUser
{
    public List<Portfolio> Portfolios { get; set; } = new List<Portfolio>();
}