using ContactsManager.Interface;
using ContactsManager.Models;
using Microsoft.AspNetCore.Http;
using ContactsManager.Utils;
using System.Collections.Generic;
using System.Linq;

namespace ContactsManager.Data
{
  /// <summary>
  /// CRUD for Natural Person
  /// </summary>
  public class NP : INP
  {
    List<NaturalPerson> lstNP = new List<NaturalPerson>();
    /// <summary>
    /// list of NP using Session
    /// </summary>
    List<NaturalPerson> _lstNP { get {
        if (httpcontext.Session.GetObject<List<NaturalPerson>>("lstNP") == null)
          return new List<NaturalPerson>();
        else
        return httpcontext.Session.GetObject<List<NaturalPerson>>("lstNP");
      } set {
        httpcontext.Session.SetObject<List<NaturalPerson>>("lstNP", value);
      } }
    HttpContext httpcontext { get; set; }

    /// <summary>
    /// this constructor uses Http for Session reasons
    /// </summary>
    /// <param name="context"></param>
    public NP(HttpContext context)
    {
      httpcontext = context;
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
      lstNP = _lstNP;
      lstNP.Add(np);
      _lstNP = lstNP;
    }
    /// <summary>
    /// edit natural person
    /// </summary>
    /// <param name="np"></param>
    public void Update(NaturalPerson np)
    {
      lstNP = _lstNP;
      lstNP.Remove(lstNP.Where(t => t.CPF == np.CPF).FirstOrDefault());
      lstNP.Add(np);
      _lstNP = lstNP;
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
      lstNP = _lstNP;
      lstNP.Remove(lstNP.Where(t => t.CPF == cpf).FirstOrDefault());
      _lstNP = lstNP;
    }

  }
  
}
