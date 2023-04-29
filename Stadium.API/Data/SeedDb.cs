using Stadium.Shared.Entities;
using Stadium.Shared.Enums;

namespace Stadium.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            //await CheckTicketsAsync();
        }

        private async Task CheckTicketsAsync()
        {
            if (!_context.Tickets.Any())
            {
                DateTime date = DateTime.Now;

                _context.Tickets.Add(new Ticket { DateUse = date, Used = false, ReceptionType = ReceptionType.North });

                await _context.SaveChangesAsync();
            }
        }
    }
}
