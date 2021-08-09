using Porject_scool.Contexts;
using Porject_scool.Domains;
using Porject_scool.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Porject_scool.Repositories
{
    public class SalaRepository : ISalaRepository
    {
        ProjInicialContext ctx = new ProjInicialContext();

        /// <summary>
        /// Atualiza um objeto sala existente atravez do seu ID
        /// </summary>
        /// <param name="id">ID da sala que será atualizada</param>
        /// <param name="salaAtualizada">Objeto com as informações</param>
        public void Atualizar(int id, Sala salaAtualizada)
        {
            Sala salaBuscada = BuscarPorId(id);

            if (salaAtualizada.Instituicao != null)
            {
                salaBuscada.Instituicao = salaAtualizada.Instituicao;
            }

            if (salaAtualizada.Andar != null)
            {
                salaBuscada.Andar = salaAtualizada.Andar;
            }

            if (salaAtualizada.Nome != null)
            {
                salaBuscada.Nome = salaAtualizada.Nome;
            }

            if (salaAtualizada.MetragemSala > 0)
            {
                salaBuscada.MetragemSala = salaAtualizada.MetragemSala;
            }

            if (salaAtualizada.Cep != null)
            {
                salaBuscada.Cep = salaAtualizada.Cep;
            }

            if (salaAtualizada.Telefone != null)
            {
                salaBuscada.Telefone = salaAtualizada.Telefone;
            }

            ctx.Salas.Update(salaBuscada);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Busca uma sala pelo seu ID
        /// </summary>
        /// <param name="id">ID da sala que será buscada</param>
        /// <returns>O objeto Sala que foi buscado</returns>
        public Sala BuscarPorId(int id)
        {
            return ctx.Salas.Find(id);
        }

        /// <summary>
        /// Cadastra uma nova sala
        /// </summary>
        /// <param name="novaSala">Objeto que será cadastrado</param>
        public void Cadastrar(Sala novaSala)
        {
            ctx.Salas.Add(novaSala);

            ctx.SaveChanges();
        }

        /// <summary>
        /// Deleta uma sala através do seu ID
        /// </summary>
        /// <param name="id">ID da sala que será deletada</param>
        public void Deletar(int id)
        {
            ctx.Salas.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        /// <summary>
        /// Lista todas as salas
        /// </summary>
        /// <returns>Uma lista de salas</returns>
        public List<Sala> ListarTodos()
        {
            return ctx.Salas.ToList();
        }
    }
}
