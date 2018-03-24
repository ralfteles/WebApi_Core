using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetCore_WebApi.Contract;
using AspnetCore_WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspnetCore_WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TarefaController : Controller
    {
        private readonly ITarefaRepositorio _tarefaRepositorio;
        public TarefaController(ITarefaRepositorio tarefaRepositorio)
        {
            _tarefaRepositorio = tarefaRepositorio;
        }
        [HttpGet]
        public IEnumerable<TarefaItem> GetAll()
        {
            return _tarefaRepositorio.GetAll();
        }

        [HttpGet("{id}", Name = "GetTarefa")]
        public IActionResult GetById(long id)
        {
            var item = _tarefaRepositorio.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] TarefaItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            _tarefaRepositorio.Add(item);

            return CreatedAtRoute("GetTarefa", new { id = item.Chave }, item);
        }
    }
}