using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly AppUserContext _appUserContext;

    public UsersController(AppUserContext appUserContext)
    {
        _appUserContext = appUserContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
    {
        var users = await _appUserContext.Users.ToListAsync();
        return users;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<AppUser>> GetUser(int id)
    {
        var user = await _appUserContext.Users.FindAsync(id);
        return user;
    }
}
