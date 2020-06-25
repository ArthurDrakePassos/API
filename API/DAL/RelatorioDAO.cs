using API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace API.DAL
{
    public class RelatorioDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static void CadastrarRelatorio(Relatorio Relatorio)
        {
            ctx.Relatorio.Add(Relatorio);
            ctx.SaveChanges();
        }

        public static IQueryable<Relatorio> RetornarRelatorios()
        {
            return ctx.Relatorio;
        }

        public static Relatorio RetornarRelatorioPorId(int id)
        {
            return ctx.Relatorio.Find(id);
        }

        public static void RemoverRelatorio(int id)
        {
            Relatorio u = RetornarRelatorioPorId(id);
            ctx.Relatorio.Remove(u);
            ctx.SaveChanges();
        }

        public static void AlterarRelatorio(Relatorio relatorio, int id)
        {
            Relatorio r = RetornarRelatorioPorId(id);

            r.IdDoacao = relatorio.IdDoacao;
            r.IdCachorroDoador = relatorio.IdCachorroDoador;
            r.IdCachorroReceptor = relatorio.IdCachorroReceptor;
            r.Descricao = relatorio.Descricao;

            ctx.Entry(r).State = EntityState.Modified;
            ctx.SaveChanges();
        }

    }
}