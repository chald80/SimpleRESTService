using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Opgave1;
using SimpleRESTService.Managers;

namespace SimpleRESTService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class FootBallplayerController : Controller
    {
        private readonly FootBallPlayerManager _manager = new FootBallPlayerManager();

        
        [HttpGet]
        public IEnumerable<FootBallPlayer> Get()
        {
            return _manager.GetAll();
        }

        
        [HttpGet("{id}")]
        public FootBallPlayer Get(int id)
        {
            return _manager.GetById(id);
        }

        
        [HttpPost]
        public FootBallPlayer Post([FromBody] FootBallPlayer value)
        {
            return _manager.Add(value);
        }

        
        [HttpPut("{id}")]
        public FootBallPlayer Put(int id, [FromBody] FootBallPlayer value)
        {
            return _manager.Update(id, value);
        }

        
        [HttpDelete("{id}")]
        public FootBallPlayer Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}
