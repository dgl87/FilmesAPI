using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos.Cinemas
{
    public class UpdateCinemaDto
    {
        [Required(ErrorMessage = "O preenchimento do campo Nome é obrigatório")]
        public string Nome { get; set; }
    }
}
