using System;
using System.Collections.Generic;
using CadastroFilmes.Core;

namespace CadastroFilmes.Data
{
    public interface IFilmeData
    {
        IEnumerable<Filme> GetAll();
    }

    public class InMemoryFilmesData:IFilmeData
    {
        private readonly List<Filme> _filmes;

        public InMemoryFilmesData()
        {
            _filmes = new List<Filme>
            {
                new Filme{Id = 1,AnoLancamento = 2019, Categoria = Categoria.Terror,Titulo = "Brinquedo Assassino"},
                new Filme{Id = 2,AnoLancamento = 1999, Categoria = Categoria.Ficcao,Titulo = "Matrix"},
                new Filme{Id = 3,AnoLancamento = 2018, Categoria = Categoria.Aventura,Titulo = "Vingadores - Guerra Infinita"},
            };
    }
        public IEnumerable<Filme> GetAll()
        {

            return _filmes;
        }
    }
}
