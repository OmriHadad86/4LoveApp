using APT.Data;
using APT.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APT.Controllers
{
    
[ApiController]
[Route("api/[controller]")] // /api/users


  public class UsersController : ControllerBase
    {
    private readonly DataContext _context;
       public UsersController(DataContext context){
      _context = context;
       }

  [HttpGet]
  public async Task<ActionResult<IEnumerable<AUser>>> GetUsers()
  {
    var users = await _context.Users.ToListAsync();

    return users;
  }



  [HttpGet("{id}")]
  public async Task<ActionResult<AUser>> GetUser(int id)
  {
    return await  _context.Users.FindAsync(id);
  }

    }
} 