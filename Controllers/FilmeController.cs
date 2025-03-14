﻿using api_filmes_senai.Domains;
using api_filmes_senai.Interfaces;
using api_filmes_senai.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_filmes_senai.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class FilmeController : ControllerBase
    {
        private readonly IFilmeRepository _filmeRepository;

        public FilmeController(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            try
            {
                List<Filme> listaDeFilmes = _filmeRepository.Listar();
                return Ok(listaDeFilmes);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
        }


        [HttpPost]
        [Authorize]
        public IActionResult Post(Filme novoFilme)
        {
            try
            {
                _filmeRepository.Cadastrar(novoFilme);
                return Created();
            }
            catch (Exception)
            {
                throw;
            }
        }

        [HttpGet("BuscarPorId/{id}")]

        public IActionResult GetById(Guid id)
        {
            try
            {
                Filme filmeBuscado = _filmeRepository.BuscarPorId(id);
                return Ok(filmeBuscado);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
       
        [HttpPut]
        [Authorize]
        public IActionResult Put(Guid id, Filme filme )
        {
            try
            {
                _filmeRepository.Atualizar(id, filme);
                return NoContent();
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }


        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult Delete(Guid id)
        {
            try
            {
                _filmeRepository.deletar(id);
                return NoContent();
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("ListarPorGenero/{id}")]

        public IActionResult GetByGenero(Guid id)
        {
            try
            {
                List<Filme>listaDeFilmePorGenero = _filmeRepository.ListarPorGenero(id);
                return Ok(listaDeFilmePorGenero);
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }


    }
}





