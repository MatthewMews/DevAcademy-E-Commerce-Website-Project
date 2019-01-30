using Microsoft.Extensions.Logging;
using PcParts.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PcParts.Data
{
    public class PcPartsRepository : IPcPartsRepository
    {
        private readonly PcPartsContext _ctx;
        private readonly ILogger<IPcPartsRepository> _logger;

        public PcPartsRepository(PcPartsContext ctx, ILogger<PcPartsRepository> logger)
        {
            _ctx = ctx;
            _logger = logger;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            try // All methods should have similar logging with try-catches
            {
                _logger.LogInformation("Get all products was called");

                return _ctx.Products
                    .OrderBy(p => p.Title)
                    .ToList();
            }catch (Exception ex)
            {
                _logger.LogError($"Failed to get all products: {ex}");
                return null;
            }
        }

        public IEnumerable<Product> GetProductsByCategory(string category)
        {
            return _ctx.Products
                .Where(p => p.Category == category)
                .ToList();
        }

        public IEnumerable<Product> GetGraphicsCards()
        {
            return _ctx.Products
                .Where(p => p.Category == "Graphics Card")
                .ToList();
        }

        public IEnumerable<Product> GetMonitors()
        {
            return _ctx.Products
                .Where(p => p.Category == "Monitor")
                .ToList();
        }

        public IEnumerable<Product> GetMotherboards()
        {
            return _ctx.Products
                .Where(p => p.Category == "Motherboard")
                .ToList();
        }

        public IEnumerable<Product> GetKeyboards()
        {
            return _ctx.Products
                .Where(p => p.Category == "Keyboard")
                .ToList();
        }

        public bool SaveAll()
        {
            return _ctx.SaveChanges() > 0; // if at least 1 row is effected, changes have been saved.
        }
    }
}
