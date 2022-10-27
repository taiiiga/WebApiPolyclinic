using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebApiPolyclinic.Entities;
using WebApiPolyclinic.Infrastructure;

namespace WebApiPolyclinic.Controllers;

[EnableCors("AllowOrigin")]
[ApiController]
[Route("api/[controller]")]
public class DiagnoseController : Controller
{
    private readonly AppDbContext _db;

    public DiagnoseController(AppDbContext db)
    {
        _db = db;
    }
    
    [HttpGet("list")]
    public IActionResult List(int id)
    {
        try
        {
            var diagnoses = _db.Diagnoses.Where(x => x.RecordId == id).ToList();
        
            return Json(diagnoses);
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
            var diagnose = _db.Diagnoses.First(x => x.Id == id);

            return Json(diagnose);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(e);
        }
    }
    
    [HttpPost("delete/{id}")]
    public IActionResult Delete(string email, string password, int id)
    {
        try
        {
            if (GetUser(email, password) == null)
                return Unauthorized();

            var diagnose = _db.Diagnoses.First(x => x.Id == id);
            var result = _db.Diagnoses.Remove(diagnose);
            _db.SaveChanges();

            return Json(result);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(e);
        }
    }
    
    [HttpPost("create")]
    public IActionResult Create([FromBody] Diagnose diagnose)
    {
        try
        {
            var result = _db.Diagnoses.Add(diagnose);
            _db.SaveChanges();

            return Json(result.Entity);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(e);
        }
    }
    
    [HttpPost("update")]
    public IActionResult Update(string email, string password, [FromBody] Diagnose diagnose)
    {
        try
        {
            if (GetUser(email, password) == null)
                return Unauthorized();

            var result = _db.Diagnoses.Update(diagnose);
            _db.SaveChanges();

            return Json(result.Entity);
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