using LocadoraApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraApp.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int ClassificacaoIndicativa { get; set; }
        public Lancamento Lancamento { get; set; }
        public ICollection<Locacao> Locacoes { get; set; } = new List<Locacao>();

        public Filme()
        {

        }

        public Filme(int id, string titulo, int classificacaoIndicativa, Lancamento lancamento)
        {
            Id = id;
            Titulo = titulo;
            ClassificacaoIndicativa = classificacaoIndicativa;
            Lancamento = lancamento;
        }
    }
}
