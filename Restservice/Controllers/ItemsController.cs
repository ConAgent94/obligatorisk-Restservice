using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restservice.Managers;
using Restservice.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Restservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly ItemsManager _manager = new();
        // GET: api/<ItemsController>
        [HttpGet]
        public IEnumerable<Item> Get()
        {
            return _manager.GetAll();
        }

        // GET api/<ItemsController>/5
        [HttpGet("{id}")]
        public Item Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<ItemsController>
        [HttpPost]
        public Item Post([FromBody] Item value)
        {
            return _manager.Add(value);
        }

        // PUT api/<ItemsController>/5
        [HttpPut("{id}")]
        public Item Put(int id, [FromBody] Item value)
        {
            return _manager.Update(id, value);
        }

        // DELETE api/<ItemsController>/5
        [HttpDelete("{id}")]
        public Item Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}
