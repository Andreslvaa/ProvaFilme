using System.Collections.Generic;
using System.Linq;
using ProvaFilme.Data;
using ProvaFilme.Models;
using ProvaFilme.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ProvaFilme.Controllers{
    [ApiController]
    [Route("api/filme")]
    public class FilmeController : ControllerBase
    {
        private readonly DataContext _context;

        //Construtor
        public FilmeController(DataContext context) => _context = context;


        //POST: api/filme/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Filme filme)
        {
            
            _context.Filmes.Add(filme);
            _context.SaveChanges();   
            return Created("", filme);    
         }

        //GET: api/filme/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Filmes.ToList());

       //GET: api/fil,e/getbyid/1
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetByID([FromRoute] int id)
        {
            Filme filme = _context.Filmes.Find(id);
            if (filme == null)
            {
                return NotFound();
            }
            return Ok(filme);
        }
    }
} 