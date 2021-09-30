using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
  public class ArtistController : Controller
  {
    [HttpGet("/record/{Id}/artist/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}