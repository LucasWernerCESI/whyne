using Microsoft.EntityFrameworkCore;
using Whyne.DAL;
using Whyne.Models;

namespace Whyne.BL
{
    public class ItemService
    {
        private readonly WhyneContext _context;
        public ItemService(WhyneContext context)
        {
            _context = context;
        }
        public async Task<List<Item>> GetItem()
        {
            return await _context
                .Items
                .Select(i => new Item
                {
                    Icon = i.Icon,
                    Title = i.Title,
                    Description = i.Description,
                    DegreeAlcoolo = i.DegreeAlcoolo,
                    Familly = i.Familly,
                    Quantity = i.Quantity,
                    Provider = i.Provider,
                    Price = i.Price
                }).ToListAsync();
        }

        public async Task<List<Item>> GetEveryFamilly(string search)    // search = Item.[search]
        {
            return await _context
                .Items
                .Select(f =>  new Item
                {
                    Familly = f.Familly
                })
                .Distinct()
                .ToListAsync();
        }

        public async Task<List<Item>> GetItemOrderDesc(string search)   // search = Item.[search]
        {
            return await _context
                .Items
                .OrderByDescending(s => search)
                .Select(s => new Item
                {
                    Icon = s.Icon,
                    Title = s.Title,
                    Description = s.Description,
                    DegreeAlcoolo = s.DegreeAlcoolo,
                    Familly = s.Familly,
                    Quantity = s.Quantity,
                    Provider = s.Provider,
                    Price = s.Price
                }).ToListAsync();
        }
    }
}
