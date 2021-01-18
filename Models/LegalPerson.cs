﻿using ContactsManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsManager.Models
{
  public class LegalPerson
  {
    [Required(ErrorMessage = "Please Enter Company Name")]
    [Display(Name = "Company Name:")]
    public string CompanyName { get; set; }
    [Display(Name = "Trade Name:")]
    public string TradeName { get; set; }
    [Required(ErrorMessage = "Please Enter CNPJ")]
    [CustomValidationCNPJ(ErrorMessage = "Invalid CNPJ : pattern 99.999.999/9991-99")]
    [Display(Name = "CNPJ:")]
    public string CNPJ { get; set; }
    [Display(Name = "Address:")]
    public Address address { get; set; }
  }
}
