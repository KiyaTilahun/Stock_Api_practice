using AspApi.Dtos.Accounts;
using AspApi.Interfaces;
using AspApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspApi.Controllers;

[Route("api/account")]
public class AccountController : ControllerBase
{
    private readonly UserManager<User> _userManager;
    private readonly ITokenService _tokenService;
    private readonly SignInManager<User> _signInManager;
    public AccountController(UserManager<User> userManager,ITokenService tokenService,SignInManager<User> signInManager)
    {
        _userManager = userManager;
        _tokenService = tokenService;
        _signInManager = signInManager;
    }
    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDto loginDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var user = await _userManager.Users.FirstOrDefaultAsync(x=>x.UserName == loginDto.UserName);
        if (user == null) return Unauthorized();

        var result= await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password,false);
        if(!result.Succeeded)  return BadRequest(result);
        return Ok(
            new NewUserDto
            {
                UserName = user.UserName,
                Email = user.Email,
                Token = _tokenService.CreateToken(user)
            });


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
                    return Ok(
                        new NewUserDto
                        {

                            UserName = newUser.UserName,
                            Email = newUser.Email,
                            Token=_tokenService.CreateToken(newUser)
                        });
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