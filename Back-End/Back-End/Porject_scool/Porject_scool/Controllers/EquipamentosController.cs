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
    public class EquipamentosController : ControllerBase
    {
        /// <summary>
        /// Objeto _equipamentoRepository que irá receber todos métodos definidos na interface IEquipamentoRepository
        /// </summary>
        private IEquipamentoRepository _equipamentoRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _equipamentoRepository para que haja a referência aos métodos no repositório
        /// </summary>
        public EquipamentosController()
        {
            _equipamentoRepository = new EquipamentoRepository();
        }

        /// <summary>
        /// Lista todos os equipamentos
        /// </summary>
        /// <returns>Uma lista de equipamentos e um status code 200 - Ok</returns>
        //[Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_equipamentoRepository.ListarTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Busca um equipamento através do seu ID
        /// </summary>
        /// <param name="id">ID do equipamento a ser buscado</param>
        /// <returns>Um equipamento encontrado e um status code 200 - Ok</returns>
        //[Authorize]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_equipamentoRepository.BuscarPorId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Cadastra um novo equipamento
        /// </summary>
        /// <param name="novaEquipamento">Objeto novaEquipamento que será cadastrada</param>
        /// <returns>Um status 201 - Created</returns>
        //[Authorize]
        [HttpPost]
        public IActionResult Post(Equipamento novaEquipamento)
        {
            _equipamentoRepository.Cadastrar(novaEquipamento);

            return StatusCode(201);
        }

        /// <summary>
        /// Modifica um equipamento existnte
        /// </summary>
        /// <param name="id">ID do equipamento que será alterado</param>
        /// <param name="equipamentoAtualizada">Objeto equipamentoAtualizada com as novas informações</param>
        /// <returns>Um status code 204 - No Content</returns>
        //[Authorize]
        [HttpPut]
        public IActionResult Put(int id, Equipamento equipamentoAtualizada)
        {
            _equipamentoRepository.Atualizar(id, equipamentoAtualizada);

            return StatusCode(204);
        }

        /// <summary>
        /// Deleta um equipamento existente
        /// </summary>
        /// <param name="id">ID do equipamento que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns> 
        //[Authorize]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _equipamentoRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}
