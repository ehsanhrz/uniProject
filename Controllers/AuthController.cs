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
    public IActionResult Login()
    {
        return View(new UserModel());
    }
    [HttpPost]
    public IActionResult Login (UserModel userModel, [FromQuery]string? errorMessage)
    {
        var result = _context.Users.AsNoTracking()
            .FirstOrDefault(record => record.NationalId == userModel.NationalId && record.Password == userModel.Password);
        if (result == null)
        {
            const string message = "رمز عبور یا کد ملی اشتباه میباشد";
            ModelState.AddModelError("error",message);
            return View(userModel);
        }

        HttpContext.Session.SetString("auth", result.NationalId);
        return RedirectToAction("Index","Home");
    }

    [HttpGet]
    public IActionResult Signup()
    {
        return View(new UserModel());
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
                HttpContext.Session.SetString("auth", userModel.NationalId);
                return RedirectToAction("Index","Home");
            }
            
            const string message = "کد ملی وارد شده در سامانه موجود میباشد"; 
            ModelState.AddModelError("error",message);
            return View(userModel);
            

        }
        catch (Exception e)
        {
            ModelState.AddModelError("error",e.Message);
            return View(userModel);
        }
    }
}