using ContactsManager.Data;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ContactsManager.Controllers
{
  public class LPController : Controller
  {
    public IActionResult Index()
    {
      LP np = new LP();
      try
      {
        var lstNP = np.GetAllLP();
        return View(lstNP);
      }
      catch (Exception ex)
      {
        return View();
      }
      
    }
  }
}
