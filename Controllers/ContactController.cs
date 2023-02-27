using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetMVC.Context;
using ASPNetMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetMVC.Controllers
{
  public class ContactController : Controller
  {

    private readonly ContackBookContext _context;

    public ContactController(ContackBookContext context)
    {
      _context = context;
    }


    public IActionResult Index()
    {
      var contacts = _context.Contacts.ToList();
      return View(contacts);
    }

    public IActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create(Contact contacts)
    {
      if (ModelState.IsValid)
      {
        _context.Contacts.Add(contacts);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));

      }
      return View(contacts);
    }

  }
}