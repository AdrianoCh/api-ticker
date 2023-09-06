using System.ComponentModel.DataAnnotations;

namespace ticker_api.Data.Dto
{
    public class ReadTickerDto
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Ticker { get; set; }
    }
}
