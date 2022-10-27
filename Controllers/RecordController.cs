using System.Dynamic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebApiPolyclinic.Entities;
using WebApiPolyclinic.Infrastructure;

namespace WebApiPolyclinic.Controllers;

[EnableCors("AllowOrigin")]
[ApiController]
[Route("api/[controller]")]
public class RecordController : Controller
{
    private readonly AppDbContext _db;

    public RecordController(AppDbContext db)
    {
        _db = db;
    }
    
    [HttpGet("list")]
    public IActionResult List(string email, string password)
    {
        try
        {
            var user = GetUser(email, password);
            if (user == null)
                return Unauthorized();

            var records = _db.Records
                .Where(x => (x.ClientId == user.Id && x.ClientId != null && user.Id != null) 
                    || (x.Email == user.Email && !string.IsNullOrEmpty(x.Email) && !string.IsNullOrEmpty(user.Email))
                    || (x.Phone == user.Phone && !string.IsNullOrEmpty(x.Phone) && !string.IsNullOrEmpty(user.Phone))
                    || (_db.Doctors.FirstOrDefault(y => y.Id == x.DoctorId).UserId == user.Id 
                        && _db.Doctors.FirstOrDefault(y => y.Id == x.DoctorId).UserId != null 
                            && user.Id != null))
                .ToList();

            var newObjects = new List<dynamic>();
            foreach (var record in records)
            {
                var newDate = new DateTime(record.Date.Value.Year, record.Date.Value.Month, record.Date.Value.Day,
                    Convert.ToInt32(record.Time.Split(':')[0]), Convert.ToInt32(record.Time.Split(':')[1]), 0);
                
                dynamic objectToAdd = new ExpandoObject();
                var userName = _db.Users.FirstOrDefault(y =>
                    y.Id == _db.Doctors.FirstOrDefault(x => x.Id == record.DoctorId).UserId);
                objectToAdd.Id = record.Id;
                objectToAdd.Date = record.Date.Value.ToLongDateString();
                objectToAdd.Time = record.Time;
                objectToAdd.Email = record.Email;
                objectToAdd.Phone = record.Phone;
                objectToAdd.Status = newDate >= DateTime.Now;
                objectToAdd.ClientId = record.ClientId;
                objectToAdd.DoctorId = record.DoctorId;
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
            var record = _db.Records.First(x => x.Id == id);

            return Json(record);
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

            var record = _db.Records.First(x => x.Id == id);
            var result = _db.Records.Remove(record);
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
    public IActionResult Create([FromBody] Record record)
    {
        try
        {
            record.Date = record.Date.Value;
            record.Id = null;
            var result = _db.Records.Add(record);
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
    public IActionResult Update(string email, string password, [FromBody] Record record)
    {
        try
        {
            if (GetUser(email, password) == null)
                return Unauthorized();

            var result = _db.Records.Update(record);
            _db.SaveChanges();

            return Json(result);
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