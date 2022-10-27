using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiPolyclinic.Entities;

public class Diagnose
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? Id { get; set; }
    public string? Description { get; set; }
    public string? Diagnosis { get; set; }
    public DateTime? DateTime { get; set; }
    public int? RecordId { get; set; }
}