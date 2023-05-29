using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fam.Service.Domain.Models;
using Fam.Service.Repository.Interfaces;
using Fam.Service.Users.Command;
using Fam.Service.Users.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Fam.Service.Domain.Students.Queries.Request;

namespace Fam.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase

    {
        private readonly ILogger<StudentController> _logger;
        private readonly IStudentRepository _repository;

        public StudentController(ILogger<StudentController> logger,
                                 IStudentRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        /// <summary>
        /// Get all Alineas.
        /// </summary>
        /// <param name="query"></param>
        /// <returns>All Alineas</returns>
        /// <response code="200">All Alineas</response>
        /// <response code="500">Internal server error.</response>
        [ProducesResponseType(typeof(StudentDto), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("{registrationNumber}")]
        public async Task<IActionResult> GetAsync([FromRoute] string registrationNumber, [FromServices] IStudentRepository repository)
        {
            try
            {
                var student = await repository.GetAsync(registrationNumber);
                return Ok(student);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
                throw;
            }

        }


    }
}
