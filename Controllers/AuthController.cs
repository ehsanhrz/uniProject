using System.Diagnostics;
using System.Runtime.InteropServices.JavaScript;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using uniProject.Models;

namespace uniProject.Controllers;

public class AuthController : Controller
{
    private readonly FormContext _context; 
    public AuthController(FormContext formContext)
    {
        _context = formContext;
    }

    [HttpGet]
    public IActionResult Index(UserModel? userModel)
    {
        return View(userModel);
    }
    // GET
    [HttpGet]
    public IActionResult Login (UserModel userModel, [FromQuery]string? errorMessage)
    {
        var result = _context.Users.AsNoTracking()
            .FirstOrDefault(record => record.NationalId == userModel.NationalId && record.Password == userModel.Password);
        if (result == null)
        {
            
            const string message = "رمز عبور یا کد ملی اشتباه میباشد";
            ModelState.AddModelError("error",message);
            return RedirectToAction("Index",new {userModel});
        }

        HttpContext.Session.SetInt32("auth", result.NationalId);
        return RedirectToAction("Index", "Home");
    }
    
    [HttpPost]
    public IActionResult Signup(UserModel userModel)
    {
        try
        {
            var checkUnique = _context.Users.AsNoTracking()
                .FirstOrDefault(record => record.NationalId == userModel.NationalId);
            if (checkUnique == null)
            {
                _context.Users.Add(userModel);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("auth", userModel.NationalId);
                return RedirectToAction("Index","Home");
            }
            
            const string message = "کد ملی وارد شده در سامانه موجود میباشد"; 
            ModelState.AddModelError("error",message);
            return RedirectToAction("Index", new { userModel });

        }
        catch (Exception e)
        {
            ModelState.AddModelError("error",e.Message);
            return RedirectToAction("Index",new {userModel});
        }
    }
}