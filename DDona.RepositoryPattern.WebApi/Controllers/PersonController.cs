using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDona.RepositoryPattern.Domain.Interfaces.Repositories;
using DDona.RepositoryPattern.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDona.RepositoryPattern.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        public IActionResult Get()
        {
            return Ok(_personService.GetAllActivePeople());
        }

        [Route("inactive")]
        public IActionResult GetInative()
        {
            return Ok(_personService.GetAllInactivePeople());
        }
    }
}