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
    public class EntradasController : ControllerBase
    {

        /// <summary>
        /// Objeto _entradaRepository que irá receber todos métodos definidos na interface IEntradaRepository
        /// </summary>
        private IEntradaRepository _entradaRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _entradaRepository para que haja a referência aos métodos no repositório
        /// </summary>
        public EntradasController()
        {
            _entradaRepository = new EntradaRepository();
        }

        /// <summary>
        /// Lista todos os entradas
        /// </summary>
        /// <returns>Uma lista de entradas e um status code 200 - Ok</returns>
        //[Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_entradaRepository.ListarTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Busca um entrada através do seu ID
        /// </summary>
        /// <param name="id">ID do entrada a ser buscado</param>
        /// <returns>Um entrada encontrado e um status code 200 - Ok</returns>
        //[Authorize]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_entradaRepository.BuscarPorId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Cadastra um novo entrada
        /// </summary>
        /// <param name="novaEntrada">Objeto novaEntrada que será cadastrada</param>
        /// <returns>Um status 201 - Created</returns>
        //[Authorize]
        [HttpPost]
        public IActionResult Post(Entrada novaEntrada)
        {
            _entradaRepository.Cadastrar(novaEntrada);

            return StatusCode(201);
        }

        /// <summary>
        /// Modifica um entrada existnte
        /// </summary>
        /// <param name="id">ID do entrada que será alterado</param>
        /// <param name="entradaAtualizada">Objeto entradaAtualizada com as novas informações</param>
        /// <returns>Um status code 204 - No Content</returns>
        //[Authorize]
        [HttpPut]
        public IActionResult Put(int id, Entrada entradaAtualizada)
        {
            _entradaRepository.Atualizar(id, entradaAtualizada);

            return StatusCode(204);
        }

        /// <summary>
        /// Deleta um entrada existente
        /// </summary>
        /// <param name="id">ID do entrada que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        //[Authorize]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _entradaRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}
