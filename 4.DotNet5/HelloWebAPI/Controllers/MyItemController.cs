using System.Threading.Tasks;
using HelloWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyItemController : ControllerBase
    {
        private readonly DockerDbContext _context;

        public MyItemController(DockerDbContext context)
        {
            _context = context;
        }

        // POST: api/MyItems
        [HttpPost]
        public async Task PostMyItem(MyItem myItem)
        {
            _context.MyItems.Add(myItem);
            await _context.SaveChangesAsync();
        }
    }
}