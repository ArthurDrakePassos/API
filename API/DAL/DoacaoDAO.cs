using API.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace API.DAL
{
    public class DoacaoDAO
    {
        private static Context ctx = SingletonContext.GetInstance();

        public static void CadastrarDoacao(Doacao Doacao)
        {
            ctx.Doacao.Add(Doacao);
            ctx.SaveChanges();
        }

        public static IQueryable<Doacao> RetornarDoacoes()
        {
            return ctx.Doacao;
        }

        public static Doacao RetornarDoacaoPorId(int id)
        {
            return ctx.Doacao.Find(id);
        }

        public static void RemoverDoacao(int id)
        {
            Doacao u = RetornarDoacaoPorId(id);
            ctx.Doacao.Remove(u);
            ctx.SaveChanges();
        }

        public static void AlterarDoacao(Doacao doacao, int id)
        {
            Doacao d = RetornarDoacaoPorId(id);

            d.IdUsuarioDoador = doacao.IdUsuarioDoador;
            d.IdCachorroDoador = doacao.IdCachorroDoador;
            d.IdUsuarioReceptor = doacao.IdUsuarioReceptor;
            d.IdCachorroReceptor = doacao.IdCachorroReceptor;
            d.IdClina = doacao.IdClina;
            d.Data = doacao.Data;
            d.Observacao = doacao.Observacao;

            ctx.Entry(d).State = EntityState.Modified;
            ctx.SaveChanges();
        }

    }
}