using System.Collections.Generic;
using PcParts.Data.Entities;

namespace PcParts.Data
{
    public interface IPcPartsRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string category);
        IEnumerable<Product> GetGraphicsCards();
        IEnumerable<Product> GetMonitors();
        IEnumerable<Product> GetKeyboards();
        IEnumerable<Product> GetMotherboards();

        bool SaveAll();
    }
}