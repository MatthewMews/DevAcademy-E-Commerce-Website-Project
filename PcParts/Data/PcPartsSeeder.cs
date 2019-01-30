using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;
using PcParts.Data.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PcParts.Data
{
    public class PcPartsSeeder
    {
        private readonly PcPartsContext _ctx;
        private readonly IHostingEnvironment _hosting;
        private readonly UserManager<StoreUser> _userManager;
        
        public PcPartsSeeder(PcPartsContext ctx, IHostingEnvironment hosting, UserManager<StoreUser> userManager)
        {
            _ctx = ctx;
            _hosting = hosting;
            _userManager = userManager;
        }

        public async Task SeedAsync()
        {
            _ctx.Database.EnsureCreated(); // Ensure database exists

            StoreUser user = await _userManager.FindByEmailAsync("matthew.mews@pcparts.com");

            if(user == null)
            {
                user = new StoreUser()
                {
                    FirstName = "Matthew",
                    LastName = "Mews",
                    Email = "matthew.mews@pcparts.com",
                    UserName = "matthew.mews@pcparts.com"
                };

                var result = await _userManager.CreateAsync(user, "Testing123!");
                if(result != IdentityResult.Success)
                {
                    throw new InvalidOperationException("Could not create a new user in seeder");
                }
            }

            if (!_ctx.Products.Any())
            {
                // Need to create sample data

                var filepath = Path.Combine(_hosting.ContentRootPath, "Data/hardware.json");
                var json = File.ReadAllText(filepath);
                var products = JsonConvert.DeserializeObject<IEnumerable<Product>>(json);

                _ctx.Products.AddRange(products);

                // Create orders

                var order = _ctx.Orders.Where(o => o.Id == 1).FirstOrDefault();

                if(order != null)
                {
                    order.User = user;
                    order.Items = new List<OrderItem>()
                    {
                        new OrderItem()
                        {
                            Product = products.First(),
                            Quantity = 1,
                            UnitPrice = products.First().Price
                            
                        }
                    };
                }


                _ctx.SaveChanges();

            }
        }
    }
}
