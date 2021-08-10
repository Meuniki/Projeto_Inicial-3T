using Porject_scool.Contexts;
using Porject_scool.Domains;
using Porject_scool.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Porject_scool.Repositories
{
    public class EntradaRepository : IEntradaRepository
    {
        ProjInicialContext ctx = new ProjInicialContext();

        /// <summary>
        /// Atualiza um objeto entrada existente atravez do seu ID
        /// </summary>
        /// <param name="id">ID da entrada que será atualizada</param>
        /// <param name="entradaAtualizada">Objeto com as informações</param>
        public void Atualizar(int id, Entrada entradaAtualizada)
        {
            Entrada entradaBuscada = BuscarPorId(id);

            if (entradaAtualizada.IdSala != null)
            {
                entradaBuscada.IdSala = entradaAtualizada.IdSala;
            }

            if (entradaAtualizada.IdEquipamento != null)
            {
                entradaBuscada.IdEntrada = entradaAtualizada.IdEntrada;
            }

            if (entradaAtualizada.DataEntrada >= DateTime.Now)
            {
                entradaBuscada.DataEntrada = entradaAtualizada.DataEntrada;
            }

            if (entradaAtualizada.DataSaida >= entradaAtualizada.DataEntrada)
            {
                entradaBuscada.DataSaida = entradaAtualizada.DataSaida;
            }

            ctx.Entradas.Update(entradaBuscada);

            ctx.SaveChanges();

        }
        

        /// <summary>
        /// Busca uma entrada pelo seu ID
        /// </summary>
        /// <param name="id">ID da entrada que será buscada</param>
        /// <returns>O objeto Entrada que foi buscado</returns>
        public Entrada BuscarPorId(int id)
        {
            return ctx.Entradas.Find(id);
        }

        /// <summary>
        /// Cadastra uma nova entrada
        /// </summary>
        /// <param name="novaEntrada">Objeto que será cadastrado</param>
        public void Cadastrar(Entrada novaEntrada)
        {
            ctx.Entradas.Add(novaEntrada);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Deleta uma entrada através do seu ID
        /// </summary>
        /// <param name="id">ID da entrada que será deletada</param>
        public void Deletar(int id)
        {
            ctx.Entradas.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        /// <summary>
        /// Lista todas as entradas
        /// </summary>
        /// <returns>Uma lista de entradas</returns>
        public List<Entrada> ListarTodos()
        {
            return ctx.Entradas.ToList();
        }
    }
}
