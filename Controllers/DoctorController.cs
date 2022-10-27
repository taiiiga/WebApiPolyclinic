using System.Dynamic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebApiPolyclinic.Entities;
using WebApiPolyclinic.Infrastructure;

namespace WebApiPolyclinic.Controllers;

[EnableCors("AllowOrigin")]
[ApiController]
[Route("api/[controller]")]
public class DoctorController : Controller
{
    private readonly AppDbContext _db;

    public DoctorController(AppDbContext db)
    {
        _db = db;
    }
    
    [HttpGet("list")]
    public IActionResult List()
    {
        try
        {
            var doctors = _db.Doctors.ToList();
            
            var newObjects = new List<dynamic>();
            foreach (var doctor in doctors)
            {
                dynamic objectToAdd = new ExpandoObject();
                var userName = _db.Users.FirstOrDefault(x => x.Id == doctor.UserId);
                objectToAdd.Id = doctor.Id;
                objectToAdd.Specialization = doctor.Specialization;
                objectToAdd.DoctorName = userName?.FirstName + " " + userName?.LastName;
                newObjects.Add(objectToAdd);
            }
        
            return Json(newObjects);
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
            var doctor = _db.Doctors.First(x => x.Id == id);
            var user = _db.Users.First(x => x.Id == doctor.UserId);
            
            dynamic objectToAdd = new ExpandoObject();
            objectToAdd.Id = doctor.Id;
            objectToAdd.Specialization = doctor.Specialization;
            objectToAdd.DoctorName = user?.FirstName + " " + user?.LastName;
            objectToAdd.City = user?.City;
            objectToAdd.Phone = user.Phone;
            objectToAdd.Email = user.Email;
            objectToAdd.Experiance = doctor.Experiance;
            objectToAdd.Photo = user.Photo;
            objectToAdd.UserId = user.Id;

            return Json(objectToAdd);
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

            var doctor = _db.Doctors.First(x => x.Id == id);
            var result = _db.Doctors.Remove(doctor);
            _db.SaveChanges();

            return Json(result.Entity);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return BadRequest(e);
        }
    }
    
    [HttpPost("create")]
    public IActionResult Create(string email, string password, [FromBody] Doctor doctor)
    {
        try
        {
            if (GetUser(email, password) == null)
                return Unauthorized();

            var result = _db.Doctors.Add(doctor);
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
    public IActionResult Update([FromBody] Doctor doctor)
    {
        try
        {
            var result = _db.Doctors.Update(doctor);
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