using ContactsManager.Data;
using ContactsManager.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ContactsManager.Controllers
{
  /// <summary>
  /// CRUD operations for Natural Person
  /// </summary>
  public class NPController : Controller
  {
    public IActionResult Index()
    {
      NP np = new NP(this.HttpContext);
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
      if (np.CPF == null)
        return View();
      NP obj = new NP(this.HttpContext);
      try
      {
        if (ModelState.IsValid)
        {
          obj.Insert(np);
          return RedirectToAction("Index");
        }
      }
      catch (Exception ex)
      {
        ModelState.AddModelError("", ex.Message);
        return View(np);
      }
      return View();
    }
    public IActionResult Details(string cpf)
    {
      NP np = new NP(this.HttpContext);
      try
      {

        return View(np.GetNP(cpf));
      }
      catch (Exception ex)
      {
        ModelState.AddModelError("NaturalPerson", ex.Message);
        return View();
      }
    }
    public IActionResult Update(string cpf)
    {
      NP np = new NP(this.HttpContext);
      try
      {
        
        return View(np.GetNP(cpf));
      }
      catch(Exception ex)
      {
        ModelState.AddModelError("", ex.Message);
        return View();
      }

    }
    [HttpPost]
    public ActionResult Update(NaturalPerson np)
    {
      NP obj = new NP(this.HttpContext);
      try
      {
        if(ModelState.IsValid)
          obj.Update(np);
      }
      catch (Exception ex)
      {
        ModelState.AddModelError("", ex.Message);
        return View(np);
      }
      return RedirectToAction("Index");
    }

    public IActionResult Delete(string cpf)
    {
      NP np = new NP(this.HttpContext);
      try
      {
        np.Delete(cpf);
        return RedirectToAction("Index");
      }
      catch (Exception ex)
      {
        ModelState.AddModelError("", ex.Message);
        return View();
      }

    }
  }
}
