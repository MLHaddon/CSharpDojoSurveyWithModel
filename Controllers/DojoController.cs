using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;

namespace DojoSurvey.Controllers
{
  public class DojoController : Controller
  {
    //Session Vars

    // HttpRequests
    [HttpGet("")]
    public ViewResult Index()
    {
      return View();
    }
    [HttpGet("result")]

    // Redirects
    [HttpPost("method")]
    public ViewResult Method(Survey survey)
    {
      return View("Result", survey);
    }
    [HttpGet("back")]
    public RedirectToActionResult Back()
    {
      return RedirectToAction("Index");
    }
  }
}