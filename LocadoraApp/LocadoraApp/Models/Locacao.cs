using LocadoraApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraApp.Models
{
    public class Locacao
    {
        public int Id { get; set; }

        public Cliente Cliente { get; set; }
        public int ClienteId { get; set; }
        public Filme Filme { get; set; }
        public int FilmeId { get; set; }
        public DateTime DataLocacao { get; private set; }
        public DateTime DataDevolucao { get; private set; }

        public Locacao()
        {

        }

        public Locacao(int id, Cliente cliente, Filme filme, DateTime dataLocacao, DateTime dataDevolucao)
        {
            Id = id;
            Cliente = cliente;
            Filme = filme;
            DataLocacao = dataLocacao;
            DataDevolucao = dataDevolucao;
        }

        public void PrazoLancamento(Filme filme)
        {
            if (filme.Lancamento == Lancamento.Lancamento)
                DataDevolucao = DataLocacao.AddDays(2.0);
        }

        public void PrazoComum(Filme filme)
        {
            if (filme.Lancamento == Lancamento.Comum)
                DataDevolucao = DataLocacao.AddDays(3.0);
        }
    }
}
