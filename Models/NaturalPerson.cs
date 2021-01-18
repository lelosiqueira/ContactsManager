using ContactsManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsManager.Models
{
  public class NaturalPerson
  {
    [Required(ErrorMessage = "Please Enter Name")]
    [Display(Name = "Name:")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Please Enter CPF")]
    [Display(Name = "CPF:")]
    [CustomValidationCPF(ErrorMessage = "Invalid CPF : pattern 999.999.999-99")]
    public string CPF { get; set; }
    [Display(Name = "Birthday:")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
    public DateTime? Birthday { get; set; }
    [Display(Name = "Gender:")]
    [Required(ErrorMessage = "Please Enter Gender")]
    public string Gender { get; set; }
    [Display(Name = "Address:")]
    public Address address { get; set; }
  }
}
