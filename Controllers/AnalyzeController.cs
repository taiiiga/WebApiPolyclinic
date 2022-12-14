using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebApiPolyclinic.Entities;
using WebApiPolyclinic.Infrastructure;

namespace WebApiPolyclinic.Controllers;

[EnableCors("AllowOrigin")]
[ApiController]
[Route("api/[controller]")]
public class AnalyzeController : Controller
{
    private readonly AppDbContext _db;

    public AnalyzeController(AppDbContext db)
    {
        _db = db;
    }
    
    [HttpGet("list")]
    public IActionResult List()
    {
        try
        {
            var analyzes = _db.Analyzes.ToList();
        
            return Json(analyzes);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(e);
        }
    }
    
    [HttpGet("get/{id}")]
    public IActionResult Get(int id)
    {
        try
        {
            var analyze = _db.Analyzes.First(x => x.Id == id);

            return Json(analyze);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(e);
        }
    }
    
    [HttpPost("delete/{id}")]
    public IActionResult Delete(int id, string email, string password)
    {
        try
        {
            if (GetUser(email, password) == null)
                return Unauthorized(); 
        
            var analyze = _db.Analyzes.First(x => x.Id == id);
            _db.Analyzes.Remove(analyze);
            _db.SaveChanges();
        
            return Json(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(e);
        }
    }
    
    [HttpPost("create")]
    public IActionResult Create(string email, string password, [FromBody] Analyze analyze)
    {
        try
        {
            if (GetUser(email, password) == null)
                return Unauthorized();

            _db.Analyzes.Add(analyze);
            _db.SaveChanges();
        
            return Json(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(e);
        }
    }
    
    [HttpPost("update")]
    public IActionResult Update(string email, string password, [FromBody] Analyze analyze)
    {
        try
        {
            if (GetUser(email, password) == null)
                return Unauthorized();
        
            _db.Analyzes.Update(analyze);
            _db.SaveChanges();
        
            return Json(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(e);
        }
    }
    
    private User? GetUser(string email, string password)
    {
        return _db.Users.FirstOrDefault(x => x.Email == email && x.Password == password);
    }
}