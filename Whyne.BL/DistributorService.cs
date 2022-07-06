using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Whyne.DAL;
using Whyne.Models.People;

namespace Whyne.BL
{
    public class DistributorService : AbstractService
    {
        public DistributorService(WhyneContext context) : base(context)
        {
        }

        public async Task<List<Distributor>> ListDistributors()
        {
            return await _context
                .Distributors
                .Select(a => new Distributor
                {
                    Id = a.Id,
                    Name = a.Name,
                    TaxNumber = a.TaxNumber,
                    RegistrationNumber = a.RegistrationNumber
                }).ToListAsync();
        }

        public async Task<Distributor?> GetDistributor(int id)
        {
            DAL.People.Distributor? distributor = await _context
                .Distributors
                .FindAsync(id);

            if (distributor == null) return default;

            return new Distributor()
            {
                Id = distributor.Id,
                Name = distributor.Name,
                TaxNumber = distributor.TaxNumber,
                RegistrationNumber = distributor.RegistrationNumber
            };
        }

        public async Task<Distributor> CreateDistributor(Distributor distributor)
        {
            DAL.People.Distributor distributorToCreate = new DAL.People.Distributor()
            {
                Name = distributor.Name,
                RegistrationNumber = distributor.RegistrationNumber,
                TaxNumber = distributor.TaxNumber
            };

            EntityEntry<DAL.People.Distributor> result = await _context
                .Distributors
                .AddAsync(distributorToCreate);

            await _context
                .SaveChangesAsync();

            distributor.Id = result.Entity.Id;

            return distributor;
        }

        public async Task<Distributor> EditDistributor(Distributor distributor)
        {
            DAL.People.Distributor? existingDistributor =
                await _context
                    .Distributors
                    .FindAsync(distributor.Id);

            if (existingDistributor != null)
            {
                existingDistributor.Name = distributor.Name;
                existingDistributor.RegistrationNumber = distributor.RegistrationNumber;
                existingDistributor.TaxNumber = distributor.TaxNumber;

                await _context
                    .SaveChangesAsync();
            }

            return distributor;
        }

        public async Task<bool> DeleteDistributor(int id)
        {
            DAL.People.Distributor? distributor =
                await _context
                    .Distributors
                    .FindAsync(id);

            if (distributor != null)
            {
                _context
                    .Distributors
                    .Remove(distributor);

                await _context
                    .SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
