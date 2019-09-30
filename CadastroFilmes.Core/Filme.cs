using System;

namespace CadastroFilmes.Core
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int AnoLancamento { get; set; }
        public Categoria Categoria { get; set; }
    }
}
