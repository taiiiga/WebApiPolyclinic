using Microsoft.EntityFrameworkCore;
using WebApiPolyclinic.Entities;

namespace WebApiPolyclinic.Infrastructure;

public class AppDbContext : DbContext
{
    static AppDbContext()
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Analyze> Analyzes { get; set; }
    public DbSet<Record> Records { get; set; }
    public DbSet<Diagnose> Diagnoses { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<User>().HasKey(p => new { p.Id });
        modelBuilder.Entity<User>().Property(p => p.Id).ValueGeneratedOnAdd();

        modelBuilder.Entity<Role>().HasData(
            new Role { Id = 1, Name = "Админ"}, 
            new Role { Id = 2, Name = "Пациент"}, 
            new Role { Id = 3, Name = "Доктор"}
        );
        
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Email = "admin@mail.com", Password = "admin", RoleId = 1},
            new User { Id = 2, Email = "client@mail.com", Password = "client", RoleId = 2},
            new User { Id = 3, Email = "doctor@mail.com", Password = "doctor", RoleId = 3}
        );
        
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 11,
                FirstName = "Админ",
                LastName = "Админов",
                Email = "admin@gmail.com",
                Password = "admin",
                Phone = string.Empty,
                RoleId = 1
            },
            new User
            {
                Id = 12,
                FirstName = "Ваня",
                LastName = "Ванов",
                Email = "vanov@gmail.com",
                Password = "123456",
                Phone = "+79443453535",
                RoleId = 2
            },
            new User
            {
                Id = 13,
                FirstName = "Иван",
                LastName = "Иванов",
                Email = "ivan@gmail.com",
                Password = "123456",
                Phone = "+79443453534",
                RoleId = 3
            }
        );
        
        modelBuilder.Entity<Doctor>().HasData(
            new Doctor
            {
                Id = 1,
                Specialization = "Хирург",
                UserId = 13
            }
        );
    }
}