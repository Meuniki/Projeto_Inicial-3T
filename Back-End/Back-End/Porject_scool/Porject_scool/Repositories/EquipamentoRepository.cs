using Porject_scool.Contexts;
using Porject_scool.Domains;
using Porject_scool.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Porject_scool.Repositories
{
    public class EquipamentoRepository : IEquipamentoRepository
    {
        ProjInicialContext ctx = new ProjInicialContext();

        public void Atualizar(int id, Equipamento equipamentoAtualizado)
        {
            Equipamento equipamentoBuscado = BuscarPorId(id);

            if (equipamentoAtualizado.Marca != null)
            {
                equipamentoBuscado.Marca = equipamentoAtualizado.Marca;
            }

            if (equipamentoAtualizado.TipoEquipamento != null)
            {
                equipamentoBuscado.TipoEquipamento = equipamentoAtualizado.TipoEquipamento;
            }

            if (equipamentoAtualizado.NumSerie != null)
            {
                equipamentoBuscado.NumSerie = equipamentoAtualizado.NumSerie;
            }

            if (equipamentoAtualizado.Descricao != null)
            {
                equipamentoBuscado.Descricao = equipamentoAtualizado.Descricao;
            }

            if (equipamentoAtualizado.NumPatrimonio != null)
            {
                equipamentoBuscado.NumPatrimonio = equipamentoAtualizado.NumPatrimonio;
            }

            if (equipamentoAtualizado.Ativo == true || equipamentoAtualizado.Ativo == false)
            {
                equipamentoBuscado.Ativo = equipamentoAtualizado.Ativo;
            }

            ctx.Equipamentos.Update(equipamentoBuscado);

            ctx.SaveChanges();
        }

        public Equipamento BuscarPorId(int id)
        {
            return ctx.Equipamentos.Find(id);
        }

        public void Cadastrar(Equipamento novoEquipamento)
        {
            ctx.Equipamentos.Add(novoEquipamento);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            ctx.Equipamentos.Remove(BuscarPorId(id));

            ctx.SaveChanges();
        }

        public List<Equipamento> ListarTodos()
        {
            return ctx.Equipamentos.ToList();
        }
    }
}
