using ContactsManager.Interface;
using ContactsManager.Models;
using ContactsManager.Utils;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;

namespace ContactsManager.Data
{
  /// <summary>
  /// CRUD for Legal Person
  /// </summary>
  public class LP : ILP
  {
    List<LegalPerson> lstLP = new List<LegalPerson>();
    /// <summary>
    /// list of lp using Session
    /// </summary>
    List<LegalPerson> _lstLP
    {
      get
      {
        if (httpcontext.Session.GetObject<List<LegalPerson>>("lstLP") == null)
          return new List<LegalPerson>();
        else
          return httpcontext.Session.GetObject<List<LegalPerson>>("lstLP");
      }
      set
      {
        httpcontext.Session.SetObject<List<LegalPerson>>("lstLP", value);
      }
    }
    HttpContext httpcontext { get; set; }

    /// <summary>
    /// this constructor uses Http for Session reasons
    /// </summary>
    /// <param name="context"></param>
    public LP(HttpContext context)
    {
      httpcontext = context;
    }
    /// <summary>
    /// List all legal Persons
    /// </summary>
    /// <returns></returns>
    public IEnumerable<LegalPerson> GetAllLP()
    {
      return _lstLP;
    }
    /// <summary>
    /// insert new legal person
    /// </summary>
    /// <param name="np"></param>
    public void Insert(LegalPerson lp)
    {
      lstLP = _lstLP;
      lstLP.Add(lp);
      _lstLP = lstLP;
    }
    /// <summary>
    /// edit legal person
    /// </summary>
    /// <param name="lp"></param>
    public void Update(LegalPerson lp)
    {
      lstLP = _lstLP;
      lstLP.Remove(lstLP.Where(t => t.CNPJ == lp.CNPJ).FirstOrDefault());
      lstLP.Add(lp);
      _lstLP = lstLP;
    }
    /// <summary>
    /// get legal person by cnpj
    /// </summary>
    /// <param name="cnpj"></param>
    /// <returns></returns>
    public LegalPerson GetLP(string cnpj)
    {
      var lp = _lstLP.Where(t => t.CNPJ == cnpj).FirstOrDefault();
      return lp;
    }
    /// <summary>
    /// delete legal person by cnpj
    /// </summary>
    /// <param name="cnpj"></param>
    public void Delete(string cnpj)
    {
      lstLP = _lstLP;
      lstLP.Remove(lstLP.Where(t => t.CNPJ == cnpj).FirstOrDefault());
      _lstLP = lstLP;
    }

  }
}
