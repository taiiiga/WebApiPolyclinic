using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebApiPolyclinic.Entities;
using WebApiPolyclinic.Infrastructure;

namespace WebApiPolyclinic.Controllers;

[EnableCors("AllowOrigin")]
[ApiController]
[Route("api/[controller]")]
public class UserController : Controller
{
    private readonly AppDbContext _db;

    public UserController(AppDbContext db)
    {
        _db = db;
    }
    
    [HttpGet("login")]
    public IActionResult Login(string email, string password)
    {
        try
        {
            return Json(_db.Users.FirstOrDefault(x => x.Email == email && x.Password == password));
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest("Ошибка! Невозможно авторизовать пользователя на сервере!");
        }
    }
    
    [HttpGet("list")]
    public IActionResult List()
    {
        try
        {
            var users = _db.Users.ToList();
        
            return Json(users);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest("Ошибка! Невозможно получить пользователей из сервера!");
        }
    }
    
    [HttpGet("get/{id}")]
    public IActionResult Get(int id)
    {
        try
        {
            var user = _db.Users.First(x => x.Id == id);
            
            return Json(user);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest("Ошибка! Невозможно получить пользователя!");
        }
    }
    
    [HttpPost("delete/{id}")]
    public IActionResult Delete(int id)
    {
        try
        {
            var user = _db.Users.First(x => x.Id == id);
            _db.Users.Remove(user);
            _db.SaveChanges();
            
            return Json(true);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest("Ошибка! Невозможно удалить пользователя!");
        }
    }
    
    [HttpPost("create")]
    public IActionResult Create([FromBody] User user)
    {
        try
        {
            var result = _db.Users.Add(user);
            _db.SaveChanges();
            
            return Json(result.Entity);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest("Ошибка! Невозможно создать пользователя!");
        }
    }
    
    [HttpPost("update")]
    public IActionResult Update([FromBody] User user)
    {
        try
        {
            var result = _db.Users.Update(user);
            _db.SaveChanges();
            
            return Json(result.Entity);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest("Ошибка! Невозможно изменить пользователя!");
        }
    }
}