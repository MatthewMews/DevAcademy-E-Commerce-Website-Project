using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcParts.Data.Entities
{
  public class Category
  {
    public int id { get; set; }
    public string Category_Name { get; set; }
    public int Product_Category_Id { get; set;}
  }
}
