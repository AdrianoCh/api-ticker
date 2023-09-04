using System.ComponentModel.DataAnnotations;

namespace ticker_api.Data.Dto
{
    public class CreateTickerDto
    {
        [Required(ErrorMessage = "O código é obrigatório")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "O TIcker é obrigatório")]
        [StringLength(5, ErrorMessage = "O ticker deve possuir no máximo 5 digitos")]
        public string Ticker { get; set; }
    }
}
