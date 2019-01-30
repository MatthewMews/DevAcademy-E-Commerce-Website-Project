using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcParts.Data.Entities
{
  public class Customers
  {
    public int Customer_Id { get; set; }
    public string Forename { get; set; }
    public string Surname { get; set; }
	public string Address { get; set; }
	public string Email { get; set; }
	public string Password { get; set; }
	public string City { get; set; }
	public string Postcode { get; set; }
  }
}
