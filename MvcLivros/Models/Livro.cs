using System;
using System.ComponentModel.DataAnnotations;

namespace MvcLivros.Models
{
    public class Livro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }
        public string Genero { get; set; }
        public string Detalhes { get; set; }
    }
}
