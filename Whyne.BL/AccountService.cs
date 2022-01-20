using Microsoft.EntityFrameworkCore;
using Whyne.DAL;
using Account = Whyne.Models.Account;

namespace Whyne.BL
{
    public class AccountService
    {
        private readonly WhyneContext _context;
        public AccountService(WhyneContext context)
        {
            _context = context;
        }
        public async Task<List<Account>> GetAccounts()
        {
            return await _context
                .Accounts
                .Select( a => new Account
                {
                    Id = a.AccountId,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    Title = a.Title
                }).ToListAsync();
        }
    }
}