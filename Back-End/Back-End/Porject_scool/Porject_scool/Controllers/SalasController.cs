using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Porject_scool.Domains;
using Porject_scool.Interfaces;
using Porject_scool.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Porject_scool.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class SalasController : ControllerBase
    {
        /// <summary>
        /// Objeto _salaRepository que irá receber todos métodos definidos na interface ISalaRepository
        /// </summary>
        private ISalaRepository _salaRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _salaRepository para que haja a referência aos métodos no repositório
        /// </summary>
        public SalasController()
        {
            _salaRepository = new SalaRepository();
        }

        /// <summary>
        /// Lista todas as salas
        /// </summary>
        /// <returns>Uma lista de salas e um status code 200 - Ok</returns>
        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_salaRepository.ListarTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Busca uma sala através do seu ID
        /// </summary>
        /// <param name="id">ID da sala a ser buscada</param>
        /// <returns>Uma sala encontrada e um status code 200 - Ok</returns>
        [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        { 
            try
            {
                return Ok(_salaRepository.BuscarPorId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Cadastra uma nova sala
        /// </summary>
        /// <param name="novaSala">Objeto novaSala que será cadastrada</param>
        /// <returns>Um status code 201 - Created</returns>
        [Authorize]
        [HttpPost]
        public IActionResult Post(Sala novaSala)
        {
            try
            {
                _salaRepository.Cadastrar(novaSala);

                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Modifica uma sala existnte
        /// </summary>
        /// <param name="id">ID da sala que será alterada</param>
        /// <param name="salaAtualizada">Objeto salaAtualizada com as novas informações</param>
        /// <returns>Um status code 204 - No Content</returns>
        [Authorize]
        [HttpPut]
        public IActionResult Put(int id, Sala salaAtualizada)
        {
            try
            {
                _salaRepository.Atualizar(id, salaAtualizada);

                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Deleta uma sala através do seu ID
        /// </summary>
        /// <param name="id">ID da sala a ser deletada</param>
        /// <returns>Um status code 204 - No Content</returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _salaRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }
    }
}
