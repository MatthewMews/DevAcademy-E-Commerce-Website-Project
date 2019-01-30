using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcParts.Data.Entities
{
  public class Product
  {
    public int Id { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
    public string Title { get; set; }
    public string ProductDescription { get; set; }
    public int ProductStock { get; set; }
    public string KeySellingPoints { get; set; }
    public string ImageId { get; set; }
  }
}
