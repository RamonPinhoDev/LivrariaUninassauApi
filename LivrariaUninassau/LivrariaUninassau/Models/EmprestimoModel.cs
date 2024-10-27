namespace LivrariaUninassau.Models
{
    public class EmprestimoModel
    {

        public int Id { get; set; }

        public string? Titulo { get; set; }

        public string? Autor { get; set; }

        public string? Editora { get; set; }

        public string? Idioma { get; set; }

        public string? Genero { get; set; }
        public int? NumeroDePaginas { get; set; }

        public int? ISBN { get; set; }

        public int? Quantidade { get; set; }

        public DateTime? dataPublicação { get; set; }

        public DateTime dataUltimaAtualizacao { get; set; } = DateTime.Now;



    }
}


