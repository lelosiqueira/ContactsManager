using ContactsManager.Data;
using ContactsManager.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ContactsManager.Controllers
{
  public class NPController : Controller
  {
    public IActionResult Index()
    {
      NP np = new NP();
      var lstNP = np.GetAllNP();
      return View(lstNP);
    }
    /// <summary>
    /// insert natural person
    /// </summary>
    /// <param name="np">New Natural Person</param>
    /// <returns></returns>
    public IActionResult Insert(NaturalPerson np)
    {
      NP obj = new NP();
      try
      {
        obj.Insert(np);
      }
      catch (Exception ex)
      {
        ModelState.AddModelError("NaturalPerson", ex.Message);
        return View(np);
      }
      return View();
    }

    public IActionResult Update(string cpf)
    {
      NP np = new NP();
      try
      {
        
        return View(np.GetNP(cpf));
      }
      catch(Exception ex)
      {
        ModelState.AddModelError("NaturalPerson", ex.Message);
        return View();
      }

    }
  }
}
