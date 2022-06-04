using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O preenchimento do campo Titulo é obrigatório")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O Preenchimento do campo Diretor é obrigatório")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O Genero não pode conter mais de 30 caracteres")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A Duração deve estar entre 1 e 600")]
        public int Duracao { get; set; }
    }
}
