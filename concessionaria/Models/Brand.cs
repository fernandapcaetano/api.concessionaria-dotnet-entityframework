using System;
using System.ComponentModel.DataAnnotations;
using Concessionaria.Models;

namespace concessionaria.Models;

public class Brand
{
    [Key]
    public int Id { get; set; }

    public Guid PublicId { get; set; } = Guid.NewGuid();

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;

    public List<Car> cars { get; set; } = new List<Car>();

}
