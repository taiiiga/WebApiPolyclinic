using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiPolyclinic.Entities;

public class Record
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? Id { get; set; }
    public DateTime? Date { get; set; }
    public int? DoctorId { get; set; }
    public string? Phone { get; set; }
    public string? Time { get; set; }
    public bool? Status { get; set; } = true;
    public int? ClientId { get; set; }
    public string Email { get; set; }
}