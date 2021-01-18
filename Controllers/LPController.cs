using ContactsManager.Data;
using ContactsManager.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ContactsManager.Controllers
{
  /// <summary>
  /// Legal Person Main controller for CRUD operations 
  /// </summary>
  public class LPController : Controller
  { 

  public IActionResult Index()
  {
    LP LP = new LP(this.HttpContext);
    var lstLP = LP.GetAllLP();
    return View(lstLP);
  }
  /// <summary>
  /// insert natural person
  /// </summary>
  /// <param name="LP">New Natural Person</param>
  /// <returns></returns>
  public IActionResult Insert(LegalPerson LP)
  {
    if (LP.CNPJ == null)
      return View();
    LP obj = new LP(this.HttpContext);
    try
    {
      if (ModelState.IsValid)
      {
        obj.Insert(LP);
        return RedirectToAction("Index");
      }
    }
    catch (Exception ex)
    {
      ModelState.AddModelError("", ex.Message);
      return View(LP);
    }
    return View();
  }
  public IActionResult Details(string cnpj)
  {
    LP LP = new LP(this.HttpContext);
    try
    {

      return View(LP.GetLP(cnpj));
    }
    catch (Exception ex)
    {
      ModelState.AddModelError("", ex.Message);
      return View();
    }
  }
  public IActionResult Update(string cnpj)
  {
    LP LP = new LP(this.HttpContext);
    try
    {

      return View(LP.GetLP(cnpj));
    }
    catch (Exception ex)
    {
      ModelState.AddModelError("", ex.Message);
      return View();
    }

  }
  [HttpPost]
  public ActionResult Update(LegalPerson LP)
  {
    LP obj = new LP(this.HttpContext);
    try
    {
      if (ModelState.IsValid)
        obj.Update(LP);
    }
    catch (Exception ex)
    {
      ModelState.AddModelError("", ex.Message);
      return View(LP);
    }
    return RedirectToAction("Index");
  }

  public IActionResult Delete(string cnpj)
  {
    LP LP = new LP(this.HttpContext);
    try
    {
      LP.Delete(cnpj);
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
