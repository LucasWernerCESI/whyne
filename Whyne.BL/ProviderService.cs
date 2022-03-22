using Microsoft.EntityFrameworkCore;
using Whyne.DAL;
using Whyne.Models;


namespace Whyne.BL
{
    public class ProviderService
    {
        private readonly WhyneContext _context;
        public ProviderService(WhyneContext context)
        {
            _context = context;
        }
        public async Task<List<Provider>> GetProvider()
        {
            return await _context
                .Provider
                .Select(p => new Provider
                {
                    Name = p.Name,
                    Location = p.Location,
                    Product = p.Product
                })
                .Distinct()
                .ToListAsync();
        }

    }
}
