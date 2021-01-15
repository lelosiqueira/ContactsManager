using ContactsManager.Interface;
using ContactsManager.Models;
using System.Collections.Generic;
using System.Linq;

namespace ContactsManager.Data
{
  /// <summary>
  /// CRUD for Natural Person
  /// </summary>
  public class NP : INP
  {
    List<NaturalPerson> _lstNP { get; set; }
    public NP()
    {
      _lstNP = new List<NaturalPerson>();
      _lstNP.Add(new NaturalPerson() { Name = "Leandro", CPF = "353.720.908-80", address = new Address() { Line1 = "r. teste", City = "jundiai", State = "SP"} });
    }
    /// <summary>
    /// List all Natural Persons
    /// </summary>
    /// <returns></returns>
    public IEnumerable<NaturalPerson> GetAllNP()
    {
      return _lstNP;
    }
    /// <summary>
    /// insert new natural person
    /// </summary>
    /// <param name="np"></param>
    public void Insert(NaturalPerson np)
    {
      _lstNP.Add(np);
    }
    /// <summary>
    /// edit natural person
    /// </summary>
    /// <param name="np"></param>
    public void Update(NaturalPerson np)
    {

    }
    /// <summary>
    /// get natural person by CPF
    /// </summary>
    /// <param name="cpf"></param>
    /// <returns></returns>
    public NaturalPerson GetNP(string cpf)
    {
      var np = _lstNP.Where(t => t.CPF == cpf).FirstOrDefault();
      return np;
    }
    /// <summary>
    /// delete natural person by cpf
    /// </summary>
    /// <param name="cpf"></param>
    public void Delete(string cpf)
    {

    }
  }
}
