using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DDona.RepositoryPattern.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDona.RepositoryPattern.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public IActionResult Get()
        {
            return Ok(_personRepository.Get());
        }

        [Route("inactive")]
        public IActionResult GetInative()
        {
            return Ok(_personRepository.GetInactive());
        }
    }
}