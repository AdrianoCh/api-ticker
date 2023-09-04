using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ticker_api.Data;
using ticker_api.Data.Dto;
using ticker_api.Models;

namespace ticker_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TickerController : ControllerBase
    {
        private TickerContext _context;
        private IMapper _mapper;

        public TickerController(TickerContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost("post")]
        public IActionResult AdicionaTicker([FromBody] CreateTickerDto tickerRecebido)
        {
            TickerModel ticker = _mapper.Map <TickerModel>(tickerRecebido);
            _context.Ticker.Add(ticker);
            _context.SaveChanges();

            return Ok(ticker);
        }
    }
}
