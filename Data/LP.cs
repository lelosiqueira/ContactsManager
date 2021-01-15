using ContactsManager.Interface;
using ContactsManager.Models;
using System.Collections.Generic;

namespace ContactsManager.Data
{
  /// <summary>
  /// CRUD for Legal Person
  /// </summary>
  public class LP : ILP
  {
    List<LegalPerson> _lstLP { get; set; }
    public LP()
    {
      _lstLP = new List<LegalPerson>();
      _lstLP.Add(new LegalPerson() { TradeName = "Company 1", CNPJ = "33.517.359/0001-90", address = new Address() { Line1 = "faria lima", City = "Sao Paulo", State = "SP" } });
    }
    /// <summary>
    /// List all Legal Persons
    /// </summary>
    /// <returns></returns>
    public IEnumerable<LegalPerson> GetAllLP()
    {
      return _lstLP;
    }
    /// <summary>
    /// insert new Legal person
    /// </summary>
    /// <param name="np"></param>
    public void Insert(LegalPerson lp)
    {
      _lstLP.Add(lp);
    }
    /// <summary>
    /// edit Legal person
    /// </summary>
    /// <param name="np"></param>
    public void Update(LegalPerson lp)
    {

    }
    /// <summary>
    /// get Legal person by CPF
    /// </summary>
    /// <param name="cpf"></param>
    /// <returns></returns>
    public LegalPerson GetLP(string cpf)
    {
      LegalPerson lp = new LegalPerson();
      return lp;
    }
    /// <summary>
    /// delete Legal person by cpf
    /// </summary>
    /// <param name="cpf"></param>
    public void Delete(string cpf)
    {

    }
  }
}
