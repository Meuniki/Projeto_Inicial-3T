using Porject_scool.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Porject_scool.Interfaces
{
    interface IEntradaRepository
    {
        /// <summary>
        /// Lista todas as entradas
        /// </summary>
        /// <returns>Uma lista de entradas</returns>
        List<Entrada> ListarTodos();

        /// <summary>
        /// Busca uma entrada pelo seu ID
        /// </summary>
        /// <param name="id">ID da entrada que será buscada</param>
        /// <returns>O objeto Entrada que foi buscado</returns>
        Entrada BuscarPorId(int id);

        /// <summary>
        /// Cadastra uma nova entrada
        /// </summary>
        /// <param name="novaEntrada">Objeto que será cadastrado</param>
        void Cadastrar(Entrada novaEntrada);

        /// <summary>
        /// Atualiza um objeto entrada existente atravez do seu ID
        /// </summary>
        /// <param name="id">ID da entrada que será atualizada</param>
        /// <param name="entradaAtualizada">Objeto com as informações</param>
        void Atualizar(int id, Entrada entradaAtualizada);

        /// <summary>
        /// Deleta uma entrada através do seu ID
        /// </summary>
        /// <param name="id">ID da entrada que será deletada</param>
        void Deletar(int id);
    }
}
