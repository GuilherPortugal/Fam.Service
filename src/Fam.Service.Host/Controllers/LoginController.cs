using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fam.Service.Repository.Interfaces;
using Fam.Service.Users.Command;
using Fam.Service.Users.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Fam.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
 
   {
        private readonly ILogger<LoginController> _logger;
        private readonly IUserRepository _repository;

        public LoginController(ILogger<LoginController> logger,
                               IUserRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserAcessCommand command,
                                              [FromServices] UserResponse response)
        {
            var user = await _repository.GetAsync(command.Login, command.Password);

            response.Sucess = user != null;

            return Ok(response);
        }
    }
}
