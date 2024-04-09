using cursoEFDatabaseFirst.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cursoEFDatabaseFirst.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursoEFController : ControllerBase
    {
        private readonly CursoEfContext _context;
        public CursoEFController(CursoEfContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<int> AddUser(UserDto userDto)
        {
            User user = new User()
            {
                UserName = userDto.UserName
            };
            await _context.AddAsync(user);
            await _context.SaveChangesAsync();

            return user.UserId;
        }
    }
}

public record UserDto(string UserName);
