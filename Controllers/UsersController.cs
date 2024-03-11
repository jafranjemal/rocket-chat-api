using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public ActionResult<IEnumerable<AppUser>> GetUsers() {

            return _context.Users.ToArray();
       
        
        }

        [HttpGet("{id}")]
        public ActionResult<AppUser> GetSingleUserByID(int id)
        {
            return _context.Users.Find(id);
        }
    }
}
