using System;
using System.ComponentModel.DataAnnotations;
using Concessionaria.Models;

namespace concessionaria.Models;

public class Image
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Url { get; set; } = null!;
    public Car Car{ get; set; } = null!;

}
