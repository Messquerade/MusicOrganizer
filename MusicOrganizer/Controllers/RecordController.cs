using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
  public class RecordController : Controller
  {
    [HttpGet("/record")]
    public ActionResult Index()
    {
      List<Record> allRecords = Record.GetAll();
      return View(allRecords);
    }

    [HttpGet("/record/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/record")]
    public ActionResult Create(string title)
    {
      Record newRecord = new Record(title);
      return RedirectToAction("Index");
    }

    [HttpGet("/record/{Id}")]
    public ActionResult Show(int id)
    {
      Record foundRecord = Record.Find(id);
      return View(foundRecord);
    }
  }
}