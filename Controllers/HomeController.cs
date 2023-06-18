using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using uniProject.Models;

namespace uniProject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly FormContext _context;
    public HomeController(ILogger<HomeController> logger, FormContext formContext)
    {
        _logger = logger;
        _context = formContext;
    }

    [HttpGet("{trackingId:long?}")]
    public IActionResult Index(long? trackingId)
    {
        var userSession = HttpContext.Session.GetString("auth");
        if (userSession == null)
        {
            return RedirectToAction("Login", "Auth");
        }
        if (trackingId == null)
        {
            return View(new MainFormModel());
        }
      
        var result = _context.Forms.FirstOrDefault(item => item.TrackingId == trackingId);
        if (result == null)
        {
            return View(new MainFormModel());
        }
        return View(result);
    }

    [HttpPost]
    public IActionResult Index(MainFormModel formModel)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                return View(formModel);
            }
            var searchResult = _context.Forms.AsNoTracking()
                .FirstOrDefault(item => item.TrackingId == formModel.TrackingId);
            if (searchResult == null || formModel.TrackingId == null)
            {
                formModel.TrackingId = DateTime.Now.Ticks;
                _context.Forms.Add(formModel);
            }
            else
            {
                _context.Forms.Update(formModel);    
            }
            _context.SaveChanges();
            return RedirectToAction("Success",new{trackingId = formModel.TrackingId});
        }
        catch(Exception ex)
        {
            ModelState.AddModelError("error",ex.Message);
            return View(formModel);
        }
       
    }

    [HttpGet("get/{trackingId:long?}")]
    public IActionResult Success(long trackingId)
    {
        
        return View(trackingId);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}