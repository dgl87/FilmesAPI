using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos.Cinemas
{
    public class ReadCinemaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O preenchimento do campo Nome é obrigatório")]
        public string Nome { get; set; }
        public int Endereco { get; set; }
    }
}
