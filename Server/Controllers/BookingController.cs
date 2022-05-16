using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WeDrivee.Server.Data;
using WeDrivee.Server.Models;
using WeDrivee.Shared;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WeDrivee.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ApplicationDbContext _appDbContext;
        public BookingController(SignInManager<ApplicationUser> signInManager, ApplicationDbContext applicationDbContext)
        {
            _signInManager = signInManager;
            _appDbContext = applicationDbContext;
        }
        // GET: api/<BookingController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BookingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BookingController>
        [HttpPost("Confirm")]
        public async Task Post(BookingDto bookingDto)
        {
            if (bookingDto != null)
            {
                ApplicationUser bookingUser = await _signInManager.UserManager.FindByNameAsync(bookingDto.Username);
                BookingModel newBooking = new BookingModel()
                {
                    CarId = bookingDto.CarId,
                    Start = bookingDto.Start,
                    End = bookingDto.End,
                    UserId = bookingUser.Id
                };
                await _appDbContext.AddAsync(newBooking);
                await _appDbContext.SaveChangesAsync();
            }
        }

        // PUT api/<BookingController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookingController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
