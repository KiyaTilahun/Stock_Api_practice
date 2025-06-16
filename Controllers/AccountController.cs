using AspApi.Dtos.Accounts;
using AspApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AspApi.Controllers;

[Route("api/account")]
public class AccountController : ControllerBase
{
    private readonly UserManager<User> _userManager;
    public AccountController(UserManager<User> userManager)
    {
        _userManager = userManager;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterDto dto)
    {
        try
        {
            // if (!ModelState.IsValid)
            // {
            //     return BadRequest("Invalid Inputs");
            // }

            var newUser = new User
            {
                UserName = dto.UserName,
                Email = dto.Email
            };
            var createUser=await _userManager.CreateAsync(newUser, dto.Password);
            if (createUser.Succeeded)
            {
                var roles = await _userManager.AddToRoleAsync(newUser, "User");
                if (roles.Succeeded)
                {
                    return Ok("User Created Successfully");
                }
                else
                {
                    return StatusCode(500,roles.Errors);
                }
            }
            else
            {
                return StatusCode(500,createUser.Errors);
            }
            return Ok("User created");
        }
        catch (Exception ex)
        {
            return StatusCode(500, new { Message = "An unexpected error occurred during user registration. Please try again later." }); return StatusCode(500,ex);
        }
    }
}