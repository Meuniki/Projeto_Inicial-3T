using Porject_scool.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Porject_scool.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório SalaRepository
    /// </summary>
    interface ISalaRepository
    {
        /// <summary>
        /// Lista todas as salas
        /// </summary>
        /// <returns>Uma lista de salas</returns>
        List<Sala> ListarTodos();

        /// <summary>
        /// Busca uma sala pelo seu ID
        /// </summary>
        /// <param name="id">ID da sala que será buscada</param>
        /// <returns>O objeto Sala que foi buscado</returns>
        Sala BuscarPorId(int id);

        /// <summary>
        /// Cadastra uma nova sala
        /// </summary>
        /// <param name="novaSala">Objeto que será cadastrado</param>
        void Cadastrar(Sala novaSala);

        /// <summary>
        /// Atualiza um objeto sala existente atravez do seu ID
        /// </summary>
        /// <param name="id">ID da sala que será atualizada</param>
        /// <param name="salaAtualizada">Objeto com as informações</param>
        void Atualizar(int id, Sala salaAtualizada);

        /// <summary>
        /// Deleta uma sala através do seu ID
        /// </summary>
        /// <param name="id">ID da sala que será deletada</param>
        void Deletar(int id);
    }
}
