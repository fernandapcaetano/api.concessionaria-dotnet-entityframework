using System;
using System.ComponentModel.DataAnnotations;
using Concessionaria.Models;

namespace concessionaria.Models;

public class AditionalFeature
{
    [Key]
    public int Id { get; private set; }

    public Guid PublicId { get; set; } = Guid.NewGuid();
    [Required]
    public string Feature {get; set;} = null!;
    [Required]
    public string FeatureDescription {get; set;} = null!;
    public Car Car {get; set;} = null!;


}
