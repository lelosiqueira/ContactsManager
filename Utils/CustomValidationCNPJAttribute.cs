using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ContactsManager.Utils
{
  public class CustomValidationCNPJAttribute : ValidationAttribute, IClientValidatable
  {

    /// <summary>
    /// Construtor
    /// </summary>
    public CustomValidationCNPJAttribute()
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
      bool valido = ValidateCNPJ(value.ToString());
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
        ValidationType = "customvalidationcnpj"
      };
    }
    /// <summary>
    /// Check for CNPJ
    /// </summary>
    /// <param name="cnpj"></param>
    /// <returns></returns>
    public static bool ValidateCNPJ(string cpf)
    {
      System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex(@"^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$");
      return reg.Match(cpf).Success;

    }
  }
}
