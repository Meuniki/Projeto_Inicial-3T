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
    public class UsuariosController : ControllerBase
    {

        /// <summary>
        /// Objeto _usuarioRepository que irá receber todos métodos definidos na interface IUsuarioRepository
        /// </summary>
        private IUsuarioRepository _usuarioRepository { get; set; }

        /// <summary>
        /// Instancia o objeto _usuarioRepository para que haja a referência aos métodos no repositório
        /// </summary>
        public UsuariosController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        /// <summary>
        /// Lista todos os usuarios
        /// </summary>
        /// <returns>Uma lista de usuarios e um status code 200 - Ok</returns>
        //[Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_usuarioRepository.ListarTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Busca um usuário através do seu ID
        /// </summary>
        /// <param name="id">ID do usuário a ser buscado</param>
        /// <returns>Um usuário encontrado e um status code 200 - Ok</returns>
        //[Authorize]
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_usuarioRepository.BuscarPorId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Cadastra um novo usuário
        /// </summary>
        /// <param name="novaUsuario">Objeto novaUsuario que será cadastrada</param>
        /// <returns>Um status 201 - Created</returns>
        //[Authorize]
        [HttpPost]
        public IActionResult Post(Usuario novaUsuario)
        {
            _usuarioRepository.Cadastrar(novaUsuario);

            return StatusCode(201);
        }

        /// <summary>
        /// Modifica um usuário existnte
        /// </summary>
        /// <param name="id">ID do usuário que será alterado</param>
        /// <param name="usuarioAtualizada">Objeto usuarioAtualizada com as novas informações</param>
        /// <returns>Um status code 204 - No Content</returns>
        //[Authorize]
        [HttpPut]
        public IActionResult Put(int id, Usuario usuarioAtualizada)
        {
            _usuarioRepository.Atualizar(id, usuarioAtualizada);

            return StatusCode(204);
        }

        /// <summary>
        /// Deleta um usuário existente
        /// </summary>
        /// <param name="id">ID do usuário que será deletado</param>
        /// <returns>Um status code 204 - No Content</returns>
        //[Authorize]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _usuarioRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}
