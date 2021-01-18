﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ContactsManager.Utils
{
  public class CustomValidationCPFAttribute : ValidationAttribute, IClientValidatable
  {

    /// <summary>
    /// Construtor
    /// </summary>
    public CustomValidationCPFAttribute()
    {
    }
    /// <summary>
    /// Server Validation
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public override bool IsValid(object value)
    {
      if (value == null || string.IsNullOrEmpty(value.ToString()))
        return true;
      bool valido = ValidateCPF(value.ToString());
      return valido;
    }
    /// <summary>
    /// Client Validation
    /// </summary>
    /// <param name="metadata"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public IEnumerable<ModelClientValidationRule> GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
    {
      yield return new ModelClientValidationRule
      {
        ErrorMessage = this.FormatErrorMessage(null),
        ValidationType = "customvalidationcpf"
      };
    }
    // <summary>
    /// Remove non numeric
    /// </summary>
    /// <param name="text"></param>
    /// <returns></returns>
    public static string RemoveNonNumeric(string text)
    {
      System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"[^0-9]");
      string ret = reg.Replace(text, string.Empty);
      return ret;
    }
    /// <summary>
    /// Check for CPF
    /// </summary>
    /// <param name="cpf"></param>
    /// <returns></returns>
    public static bool ValidateCPF(string cpf)
    {
      System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$");
      return reg.Match(cpf).Success;
      
    }
  }
}
