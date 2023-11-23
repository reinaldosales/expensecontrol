using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpenseControl.MVC.Data;
using ExpenseControl.MVC.Models;
using Microsoft.AspNetCore.Authorization;

namespace ExpenseControl.MVC.Controllers;

[Authorize]
public class ImageController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly string _imagePath;

    public ImageController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
    {
        _context = context;
        _imagePath = webHostEnvironment.WebRootPath;
    }

    public async Task<IActionResult> Upload(IFormFile avatar)
    {
        string pathToSaveImage = Path.Combine(_imagePath, "avatars");
        string image = $"{Guid.NewGuid()}_{avatar.FileName}";

        if (!Directory.Exists(pathToSaveImage))
            Directory.CreateDirectory(pathToSaveImage);

        using (var stream = System.IO.File.Create(Path.Combine(pathToSaveImage,image)))
        {
            avatar.CopyToAsync(stream);
        }

        var user = _context.Users.FirstOrDefault(x => x.Email == User.Identity.Name);

        user.Avatar = image;

        _context.Update(user);
        _context.SaveChanges();

        return RedirectToAction("Index", new RouteValueDictionary(new { controller = "Home" }));
    }
}

