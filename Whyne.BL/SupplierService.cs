using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Whyne.DAL;
using Whyne.Models.People;
using Whyne.Models.Products;

namespace Whyne.BL
{
    public class SupplierService : AbstractService
    {
        public SupplierService(WhyneContext context) : base(context)
        {
        }

        public async Task<List<Supplier>> ListSuppliers()
        {
            return await _context
                .Suppliers
                .Select(a => new Supplier()
                {
                    Id = a.Id,
                    Name = a.Name,
                    TaxNumber = a.TaxNumber,
                    RegistrationNumber = a.RegistrationNumber
                }).ToListAsync();
        }

        public async Task<Supplier?> GetSupplier(int id)
        {
            DAL.People.Supplier? supplier = await _context
                .Suppliers
                .FindAsync(id);

            if (supplier == null) return default;

            return new Supplier()
            {
                Id = supplier.Id,
                Name = supplier.Name,
                TaxNumber = supplier.TaxNumber,
                RegistrationNumber = supplier.RegistrationNumber
            };
        }

        public async Task<Supplier> CreateSupplier(Supplier supplier)
        {
            DAL.People.Supplier supplierToCreate = new DAL.People.Supplier()
            {
                Name = supplier.Name,
                RegistrationNumber = supplier.RegistrationNumber,
                TaxNumber = supplier.TaxNumber
            };

            EntityEntry<DAL.People.Supplier> result = await _context
                .Suppliers
                .AddAsync(supplierToCreate);

            await _context
                .SaveChangesAsync();

            supplier.Id = result.Entity.Id;

            return supplier;
        }

        public async Task<Supplier> EditSupplier(Supplier supplier)
        {
            DAL.People.Supplier? existingSupplier =
                await _context
                    .Suppliers
                    .FindAsync(supplier.Id);

            if (existingSupplier != null)
            {
                existingSupplier.Name = supplier.Name;
                existingSupplier.RegistrationNumber = supplier.RegistrationNumber;
                existingSupplier.TaxNumber = supplier.TaxNumber;

                await _context
                    .SaveChangesAsync();
            }

            return supplier;
        }

        public async Task<bool> DeleteSupplier(int id)
        {
            DAL.People.Supplier? supplier =
                await _context
                    .Suppliers
                    .FindAsync(id);

            if (supplier != null)
            {
                _context
                    .Suppliers
                    .Remove(supplier);

                await _context
                    .SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}