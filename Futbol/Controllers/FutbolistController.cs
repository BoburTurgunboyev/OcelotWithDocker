using Futbol.Data;
using Futbol.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Futbol.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FutbolistController : ControllerBase
    {
        private readonly FutbolDbContext _futbolDbContext;

        public FutbolistController(FutbolDbContext futbolDbContext)
        {
            _futbolDbContext = futbolDbContext;
        }

        [HttpPost]

        public async ValueTask<IActionResult> CreateFutbolist(Futbolist futbolist)
        {
            await _futbolDbContext.Futbolists.AddAsync(futbolist);
            await _futbolDbContext.SaveChangesAsync();
            return Ok(futbolist);
        }

        [HttpGet]

        public async ValueTask<IActionResult> GetAllFutbolist()
        {
            var result =  await _futbolDbContext.Futbolists.ToListAsync();
            return Ok(result);
        }
    }
}
