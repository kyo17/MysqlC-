using System;
using System.Threading.Tasks;
using APIElectron.Interfaces;
using APIElectron.Models;
using APIElectron.Repository;
using Microsoft.AspNetCore.Mvc;

namespace APIElectron.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : Controller
    {

        private UserRepository repo = new UserRepository();

        [HttpPost]
        public async Task<IActionResult> insert([FromBody] User user)
        {
           
            await repo.insert(user);
            return Created("Created", true);
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            return Ok(await repo.getAll());
        }
    }
}
