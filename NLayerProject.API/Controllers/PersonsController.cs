using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLayerProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IService<Person> _personService;
        public PersonsController(IService<Person> service)
        {
            _personService = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var person = await _personService.GetAllAsync();
            return Ok(person);
        }
    }
}
