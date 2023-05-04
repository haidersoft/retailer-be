using Microsoft.AspNetCore.Mvc;
using Retail_BE.DBContext.Entities;
using Retail_BE.DBContext;
using Microsoft.AspNetCore.Authorization;

namespace Retail_BE.Controllers
{
    [ApiController]
    [Route("api/admin")]
    public class AdminOprations : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public AdminOprations(ApplicationDBContext context)
        {
            _context = context;
        }

        [Authorize]
        [HttpPut]
        [Route("UpdateBalance")]
        public IActionResult UpdateBalance([FromBody] Users user)
        {
            IActionResult response;
            var entity = _context.Users.Select(x => x).Where(x => x.Id == user.Id).FirstOrDefault();

            if (entity == null)
                return NotFound();

            entity.Balance = entity.Balance + user.Balance;
            _context.SaveChanges();

            return response = Ok(new { Message = "Success" });
        }

        [Authorize]
        [HttpGet]
        [Route("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            IActionResult response;
            var entity = _context.Users.ToList();

            return response = Ok(entity);
        }

        [Authorize]
        [HttpGet]
        [Route("GetAllUserPackageNotifications")]
        public IActionResult GetAllUserPackageNotifications()
        {
            IActionResult response;
            var entity = _context.Users.ToList();

            return response = Ok(entity);
        }

    }
}
