using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Whyne.DAL;
using Whyne.Models.People;

namespace Whyne.BL
{
    public class CustomerService : AbstractService
    {
        public CustomerService(WhyneContext context) : base(context)
        {
        }

        public async Task<List<Customer>> ListCustomers()
        {
            return await _context
                .Customers
                .Select(a => new Customer
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    Email = a.Email,
                    PhoneNumber = a.PhoneNumber,
                    Adresses =
                        (a.Adresses != null)
                            ? a.Adresses.Select(a => new Models.Adress()
                            {
                                Id = a.Id,
                                City = a.City,
                                Street = a.Street,
                                ZipCode = a.ZipCode
                            }).ToList()
                            : null
                }).ToListAsync();
        }

        public async Task<Customer?> GetCustomer(int id)
        {
            DAL.People.Customer? customer = await _context
                .Customers
                .Where(c => c.Id == id)
                .FirstAsync();

            if (customer == null) return default;

            return new Customer()
            {
                Id = customer.Id,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Adresses = customer.Adresses.Select(a => new Models.Adress
                {
                    City = a.City,
                    ZipCode = a.ZipCode,
                    Street = a.Street,
                    Id = a.Id
                }).ToList()
            };
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            DAL.People.Customer customerToCreate = new DAL.People.Customer()
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                PhoneNumber = customer.PhoneNumber
            };

            customerToCreate.Adresses =
                (customer.Adresses != null)
                    ? customer.Adresses.Select(a => new DAL.Adress()
                    {
                        City = a.City,
                        Street = a.Street,
                        ZipCode = a.ZipCode,
                        Customer = customerToCreate
                    }).ToList()
                    : null;

            EntityEntry<DAL.People.Customer> result = await _context
                .Customers
                .AddAsync(customerToCreate);

            await _context
                .SaveChangesAsync();

            customer.Id = result.Entity.Id;

            return customer;
        }

        public async Task<Customer> EditCustomer(Customer customer)
        {
            DAL.People.Customer? existingCustomer =
                await _context
                    .Customers
                    .Where(c => c.Id == customer.Id)
                    .Include(d => d.Adresses)
                    .SingleAsync();

            if (existingCustomer != null)
            {
                existingCustomer.FirstName = customer.FirstName;
                existingCustomer.LastName = customer.LastName;
                existingCustomer.Email = customer.Email;
                existingCustomer.PhoneNumber = customer.PhoneNumber;
                existingCustomer.Adresses =
                    (customer.Adresses != null)
                        ? customer
                            .Adresses
                            .Select(a =>
                                {
                                    DAL.Adress adress =
                                        _context.Adresses.Find(a.Id)
                                        ?? new DAL.Adress();
                                    adress.City = a.City;
                                    adress.Street = a.Street;
                                    adress.ZipCode = a.ZipCode;
                                    return adress;
                                }
                            ).ToList()
                        : null;

                await _context
                    .SaveChangesAsync();
            }

            return customer;
        }

        public async Task<bool> DeleteCustomer(int id)
        {
            DAL.People.Customer? customer =
                await _context
                    .Customers
                    .FindAsync(id);

            if (customer != null)
            {
                _context
                    .Customers
                    .Remove(customer);

                await _context
                    .SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}