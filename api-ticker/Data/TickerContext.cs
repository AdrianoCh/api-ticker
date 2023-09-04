using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using ticker_api.Models;

namespace ticker_api.Data
{
    public class TickerContext : DbContext
    {
        public TickerContext(DbContextOptions<TickerContext> opts) : base(opts)
        {

        }

        public DbSet<TickerModel> Ticker { get; set; }
    }
}
