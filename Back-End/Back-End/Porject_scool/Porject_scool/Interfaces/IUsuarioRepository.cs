using Porject_scool.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Porject_scool.Interfaces
{
    interface IUsuarioRepository
    {
        /// <summary>
        /// Lista todas as usuários
        /// </summary>
        /// <returns>Uma lista de usuários</returns>
        List<Usuario> ListarTodos();

        /// <summary>
        /// Busca um usuário pelo seu ID
        /// </summary>
        /// <param name="id">ID da usuário que será buscada</param>
        /// <returns>O objeto Usuario que foi buscado</returns>
        Usuario BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo usuário
        /// </summary>
        /// <param name="novoUsuario">Objeto que será cadastrado</param>
        void Cadastrar(Usuario novoUsuario);

        /// <summary>
        /// Atualiza um objeto usuário existente atravéz do seu ID
        /// </summary>
        /// <param name="id">ID do usuário que será atualizado</param>
        /// <param name="usuarioAtualizado">Objeto com as informações</param>
        void Atualizar(int id, Usuario usuarioAtualizado);

        /// <summary>
        /// Deleta um usuário através do seu ID
        /// </summary>
        /// <param name="id">ID da usuário que será deletado</param>
        void Deletar(int id);

        /// <summary>
        /// Valida o usuário
        /// </summary>
        /// <param name="email">e-mail do usuário</param>
        /// <param name="senha">senha do usuário</param>
        /// <returns>Um objeto do tipo usuário que foi busacado </returns>
        Usuario Login(string email, string senha);

    }
}
