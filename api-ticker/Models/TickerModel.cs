using System.ComponentModel.DataAnnotations;

namespace ticker_api.Models
{
    public class TickerModel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O código é obrigatório")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "O TIcker é obrigatório")]
        [StringLength(5, ErrorMessage = "O ticker deve possuir no máximo 5 digitos")]
        public string Ticker { get; set; }
    }
}
