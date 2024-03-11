using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using roket_chat_api.Data;
using roket_chat_api.Entities;

namespace roket_chat_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController :ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
             _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers() {

            return await _context.Users.ToListAsync();
       
        
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetSingleUserByID(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}
