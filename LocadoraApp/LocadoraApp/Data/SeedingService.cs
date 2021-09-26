using LocadoraApp.Models;
using LocadoraApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraApp.Data
{
    public class SeedingService
    {
        private readonly LocadoraAppContext _context;

        public SeedingService(LocadoraAppContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Locacoes.Any() ||
                _context.Filmes.Any() ||
                _context.Clientes.Any())
            {
                return;
            }

            Filme f1 = new Filme(1, "Godzilla vs. Kong", 14, Lancamento.Lancamento);
            Filme f2 = new Filme(2, "Mortal Kombat", 18, Lancamento.Lancamento);
            Filme f3 = new Filme(3, "Coringa", 18, Lancamento.Comum);
            Filme f4 = new Filme(4, "Vingadores Ultimato", 14, Lancamento.Comum);
            Filme f5 = new Filme(5, "Toy Story 4", 3, Lancamento.Comum);
            Filme f6 = new Filme(6, "Homem-Aranha: Longe de Casa", 12, Lancamento.Comum);
            Filme f7 = new Filme(7, "Velozes e Furiosos 9", 14, Lancamento.Lancamento);
            Filme f8 = new Filme(8, "Viúva Negra", 14, Lancamento.Lancamento);
            Filme f9 = new Filme(9, "Logan", 16, Lancamento.Comum);
            Filme f10 = new Filme(10, "Mulher Maravilha", 14, Lancamento.Comum);
            Filme f11 = new Filme(11, "Patrulha Canina: O Filme", 3, Lancamento.Lancamento);
            Filme f12 = new Filme(12, "007: Sem Tempo para Morrer", 16, Lancamento.Lancamento);
            Filme f13 = new Filme(13, "Guardiões da Galáxia Vol. 2", 12, Lancamento.Comum);
            Filme f14 = new Filme(14, "Área 51", 16, Lancamento.Comum);
            Filme f15 = new Filme(15, "Cruella", 10, Lancamento.Lancamento);
            Filme f16 = new Filme(16, "John Wick - De Volta ao Jogo", 16, Lancamento.Comum);

            Cliente c1 = new Cliente(1, "Carlos", "12378945610", new DateTime(1999, 4, 21));
            Cliente c2 = new Cliente(2, "Júlia", "22113377440", new DateTime(2002, 9, 15));
            Cliente c3 = new Cliente(3, "Maressa", "78932165423", new DateTime(1994, 2, 25));
            Cliente c4 = new Cliente(4, "Leandro", "14725836960", new DateTime(1984, 10, 5));
            Cliente c5 = new Cliente(5, "Amanda", "96385274143", new DateTime(1995, 1, 11));
            Cliente c6 = new Cliente(6, "Victor", "35715984267", new DateTime(1995, 7, 27));
            Cliente c7 = new Cliente(7, "Valmir", "24689751391", new DateTime(1975, 12, 7));
            Cliente c8 = new Cliente(8, "Bruna", "75135982464", new DateTime(1998, 7, 28));
            Cliente c9 = new Cliente(9, "Jean", "32148675912", new DateTime(2004, 3, 15));
            Cliente c10 = new Cliente(10, "Laura", "74236819338", new DateTime(2000, 11, 2));
            Cliente c11 = new Cliente(11, "Vanessa", "29483617270", new DateTime(1967, 6, 18));
            Cliente c12 = new Cliente(12, "Tatiana", "14435790614", new DateTime(1980, 3, 23));
            Cliente c13 = new Cliente(13, "Felipe", "43176591366", new DateTime(1985, 5, 10));
            Cliente c14 = new Cliente(14, "Matheus", "54977013652", new DateTime(2000, 1, 10));
            Cliente c15 = new Cliente(15, "Diana", "61174496344", new DateTime(2001, 9, 11));
            Cliente c16 = new Cliente(16, "Henrique", "93374285180", new DateTime(1990, 8, 27));

            Locacao l1 = new Locacao(1, c2, f4, new DateTime(2021, 9, 10), new DateTime(2021, 9, 13));
            Locacao l2 = new Locacao(2, c7, f1, new DateTime(2021, 9, 18), new DateTime(2021, 9, 20));
            Locacao l3 = new Locacao(3, c16, f7, new DateTime(2021, 9, 9), new DateTime(2021, 9, 12));
            Locacao l4 = new Locacao(4, c1, f13, new DateTime(2021, 9, 1), new DateTime(2021, 9, 4));
            Locacao l5 = new Locacao(5, c10, f7, new DateTime(2021, 9, 25), new DateTime(2021, 9, 27));
            Locacao l6 = new Locacao(6, c8, f16, new DateTime(2020, 4, 21), new DateTime(2020, 4, 25));
            Locacao l7 = new Locacao(7, c8, f5, new DateTime(2020, 6, 9), new DateTime(2020, 6, 12));
            Locacao l8 = new Locacao(8, c14, f4, new DateTime(2020, 12, 1), new DateTime(2020, 12, 4));
            Locacao l9 = new Locacao(9, c2, f14, new DateTime(2020, 5, 18), new DateTime(2020, 5, 15));
            Locacao l10 = new Locacao(10, c6, f15, new DateTime(2021, 9, 12), new DateTime(2021, 9, 14));
            Locacao l11 = new Locacao(11, c15, f9, new DateTime(2021, 4, 3), new DateTime(2021, 4, 7));
            Locacao l12 = new Locacao(12, c3, f8, new DateTime(2021, 8, 27), new DateTime(2021, 8, 29));
            Locacao l13 = new Locacao(13, c12, f12, new DateTime(2021, 9, 23), new DateTime(2021, 9, 26));
            Locacao l14 = new Locacao(14, c14, f3, new DateTime(2020, 10, 2), new DateTime(2020, 10, 5));
            Locacao l15 = new Locacao(15, c5, f3, new DateTime(2020, 11, 20), new DateTime(2020, 11, 23));
            Locacao l16 = new Locacao(16, c4, f13, new DateTime(2020, 7, 27), new DateTime(2020, 7, 31));
            Locacao l17 = new Locacao(17, c6, f16, new DateTime(2020, 6, 9), new DateTime(2020, 6, 13));
            Locacao l18 = new Locacao(18, c11, f16, new DateTime(2020, 2, 12), new DateTime(2020, 2, 15));
            Locacao l19 = new Locacao(19, c7, f9, new DateTime(2021, 1, 1), new DateTime(2021, 1, 4));
            Locacao l20 = new Locacao(20, c8, f15, new DateTime(2021, 9, 21), new DateTime(2021, 9, 23));

            _context.Filmes.AddRange(f1, f2, f3, f4, f5, f6, f7, f8, f9, f10,
                f11, f12, f13, f14, f15, f16);

            _context.Clientes.AddRange(c1, c2, c3, c4, c5, c6, c7, c8, c9, c10,
                c11, c12, c13, c14, c15, c16);

            _context.Locacoes.AddRange(l1, l2, l3, l4, l5, l6, l7, l8, l9, l10,
                l11, l12, l13, l14, l15, l16, l17, l18, l19, l20);

            _context.SaveChanges();
        }
    }
}
