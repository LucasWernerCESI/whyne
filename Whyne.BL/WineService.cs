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
    public class WineService : AbstractService
    {
        public WineService(WhyneContext context) : base(context)
        {
        }

        public async Task<List<Wine>> ListWines()
        {
            
            return await _context
                .Wines
                .Select(a => new Wine
                {
                    Id = a.Id,
                    Name = a.Name,
                    StoredAmount = a.StoredAmount,
                    Acidity = a.Acidity,
                    Alcohol = a.Alcohol,
                    Color = a.Color,
                    HasBubbles = a.HasBubbles,
                    GrapeVariety = a.GrapeVariety,
                    Region = a.Region,
                    SugarResidues = a.SugarResidues,
                    Tannins = a.Tannins,
                    TaxFreeUnitPrice = a.TaxFreeUnitPrice,
                    Vintage = a.Vintage,
                    Supplier = 
                        (a.Supplier == null)
                            ? null
                            : new Supplier
                                {
                                    Id = a.Supplier.Id,
                                    Name = a.Supplier.Name,
                                    RegistrationNumber = a.Supplier.RegistrationNumber,
                                    TaxNumber = a.Supplier.TaxNumber
                                }
                }).ToListAsync();
        }

        public async Task<Wine?> GetWine(int id)
        {
             DAL.Products.Wine? wine = await _context
                .Wines
                .FindAsync(id);

             if (wine == null) return default;

             return new Wine
             {
                 Id = wine.Id,
                 Name = wine.Name,
                 StoredAmount = wine.StoredAmount,
                 Acidity = wine.Acidity,
                 Alcohol = wine.Alcohol,
                 Color = wine.Color,
                 HasBubbles = wine.HasBubbles,
                 GrapeVariety = wine.GrapeVariety,
                 Region = wine.Region,
                 SugarResidues = wine.SugarResidues,
                 Tannins = wine.Tannins,
                 TaxFreeUnitPrice = wine.TaxFreeUnitPrice,
                 Vintage = wine.Vintage,
                 Supplier = 
                     (wine.Supplier == null)
                         ? null
                         : new Supplier
                             { 
                                 Id = wine.Supplier.Id,
                                 Name = wine.Supplier.Name,
                                 TaxNumber = wine.Supplier.TaxNumber
                             }
             };
        }

        public async Task<Wine> CreateWine(Wine wine)
        {
            DAL.Products.Wine wineToCreate = new DAL.Products.Wine
            {
                Name = wine.Name,
                StoredAmount = wine.StoredAmount,
                Acidity = wine.Acidity,
                Alcohol = wine.Alcohol,
                Color = wine.Color,
                HasBubbles = wine.HasBubbles,
                GrapeVariety = wine.GrapeVariety,
                Region = wine.Region,
                SugarResidues = wine.SugarResidues,
                Tannins = wine.Tannins,
                TaxFreeUnitPrice = wine.TaxFreeUnitPrice,
                Vintage = wine.Vintage,
                Supplier = 
                    (wine.Supplier == null)
                        ? null
                        : new DAL.People.Supplier
                            {
                                Id = wine.Supplier.Id,
                                Name = wine.Supplier.Name,
                                RegistrationNumber = wine.Supplier.RegistrationNumber,
                                TaxNumber = wine.Supplier.TaxNumber
                            }
            };

            EntityEntry<DAL.Products.Wine> result = await _context
                .Wines
                .AddAsync(wineToCreate);

            await _context
                .SaveChangesAsync();

            wine.Id = result.Entity.Id;

            return wine;
        }

        public async Task<Wine> EditWine(Wine wine)
        {
            DAL.Products.Wine? existingWine = 
                await _context
                    .Wines
                    .FindAsync(wine.Id);

            if (existingWine != null)
            {
                existingWine.Name = wine.Name;
                existingWine.StoredAmount = wine.StoredAmount;
                existingWine.Acidity = wine.Acidity;
                existingWine.Alcohol = wine.Alcohol;
                existingWine.Color = wine.Color;
                existingWine.HasBubbles = wine.HasBubbles;
                existingWine.GrapeVariety = wine.GrapeVariety;
                existingWine.Region = wine.Region;
                existingWine.SugarResidues = wine.SugarResidues;
                existingWine.Tannins = wine.Tannins;
                existingWine.TaxFreeUnitPrice = wine.TaxFreeUnitPrice;
                existingWine.Vintage = wine.Vintage;
                existingWine.Supplier = 
                    (wine.Supplier == null)
                        ? null
                        : await _context
                            .Suppliers
                            .FindAsync(wine.Supplier.Id);

                await _context
                    .SaveChangesAsync();
            }

            return wine;
        }

        public async Task<bool> DeleteWine(int id)
        {
            DAL.Products.Wine? wine =
                await _context
                    .Wines
                    .FindAsync(id);

            if (wine != null)
            {
                _context
                    .Wines
                    .Remove(wine);

                await _context
                    .SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
