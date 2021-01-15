using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsManager.Models
{
  public class Address
  {
    [Display(Name = "Zip Code:")]
    public string ZipCode { get; set; }
    [Display(Name = "Country:")]
    public string Country { get; set; }
    [Display(Name = "State:")]
    public string State { get; set; }
    [Display(Name = "City:")]
    public string City { get; set; }
    [Display(Name = "Line 1:")]
    public string Line1 { get; set; }
    [Display(Name = "Line 2:")]
    public string Line2 { get; set; }
  }
}
