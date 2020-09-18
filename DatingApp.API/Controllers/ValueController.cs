using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;



namespace DatingApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ValueController : Controller
    {
        private readonly DataContext _context;
        public ValueController(DataContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetValues()
        {
            var values = _context.Values.ToList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetValues(int id)
        {
            var values = _context.Values.FirstOrDefault(x => x.Id == id);
            return Ok(values);
        }


    }


}