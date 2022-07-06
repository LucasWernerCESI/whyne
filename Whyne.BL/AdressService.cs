using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Whyne.DAL;

namespace Whyne.BL
{
    public class AdressService : AbstractService
    {
        public AdressService(WhyneContext context) : base(context)
        {
        }

        public async Task<Adress> CreateAdress(Adress adress)
        {
            DAL.Adress adressToCreate = new ()
            {
                Street = adress.Street,
                City = adress.City,
                Id = adress.Id,
                ZipCode = adress.ZipCode
            };

            EntityEntry<DAL.Adress> result = await _context
                .Adresses
                .AddAsync(adressToCreate);

            await _context
                .SaveChangesAsync();

            adress.Id = result.Entity.Id;

            return adress;
        }

        public async Task<Adress> EditAdress(Adress adress)
        {
            DAL.Adress? existingAdress =
                await _context
                    .Adresses
                    .FindAsync(adress.Id);

            if (existingAdress != null)
            {
                existingAdress.Street = adress.Street;
                existingAdress.ZipCode = adress.ZipCode;
                existingAdress.City = adress.City;

                await _context
                    .SaveChangesAsync();
            }

            return adress;
        }

        public async Task<bool> DeleteAdress(int id)
        {
            DAL.Adress? adress =
                await _context
                    .Adresses
                    .FindAsync(id);

            if (adress != null)
            {
                _context
                    .Adresses
                    .Remove(adress);

                await _context
                    .SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
