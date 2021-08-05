using Porject_scool.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Porject_scool.Interfaces
{
    /// <summary>
    /// Interface responsavel pelo repositorio equipamento
    /// </summary>
    interface IEquipamentoRepository
    {
        /// <summary>
        /// Lista todas as equipamentos
        /// </summary>
        /// <returns>Uma lista de equipamentos</returns>
        List<Equipamento> ListarTodos();

        /// <summary>
        /// Busca um equipamento pelo seu ID
        /// </summary>
        /// <param name="id">ID da equipamento que será buscada</param>
        /// <returns>O objeto Equipamento que foi buscado</returns>
        Equipamento BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo equipamento
        /// </summary>
        /// <param name="novoEquipamento">Objeto que será cadastrado</param>
        void Cadastrar(Equipamento novoEquipamento);

        /// <summary>
        /// Atualiza um objeto equipamento existente atravéz do seu ID
        /// </summary>
        /// <param name="id">ID do equipamento que será atualizado</param>
        /// <param name="equipamentoAtualizado">Objeto com as informações</param>
        void Atualizar(int id, Equipamento equipamentoAtualizado);

        /// <summary>
        /// Deleta um equipamento através do seu ID
        /// </summary>
        /// <param name="id">ID da equipamento que será deletado</param>
        void Deletar(int id);
    }
}
