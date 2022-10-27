using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiPolyclinic.Entities;

public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? Id { get; set; }
    public string? Email { get; set; } = string.Empty;
    public string? Password { get; set; } = string.Empty;
    public int? RoleId { get; set; } = 2;
    public string? FirstName { get; set; } = string.Empty;
    public string? LastName { get; set; } = string.Empty;
    public string? Phone { get; set; } = string.Empty;
    public string? City { get; set; } = string.Empty;
    public string? Photo { get; set; } = string.Empty;
}