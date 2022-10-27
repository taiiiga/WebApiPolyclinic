using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiPolyclinic.Entities;

public class Doctor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? Id { get; set; }
    public string? Specialization { get; set; } = string.Empty;
    public byte? Experiance { get; set; } = 0;
    [Required]
    public int? UserId { get; set; }
}