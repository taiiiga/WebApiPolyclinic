using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiPolyclinic.Entities;

public class Analyze
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int? Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Result { get; set; }
    public int? PatientId { get; set; }
}