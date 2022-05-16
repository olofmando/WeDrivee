using Microsoft.AspNetCore.Mvc;
using WeDrivee.Server.Data;
using WeDrivee.Server.Models;

namespace WeDrivee.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class CarController : ControllerBase
    {
        private readonly ApplicationDbContext _appDbContext;
        public CarController(ApplicationDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        [HttpGet]
        public async Task<IEnumerable<CarModel>> Get()
        {
            return _appDbContext.Cars;
        }
    }
}
