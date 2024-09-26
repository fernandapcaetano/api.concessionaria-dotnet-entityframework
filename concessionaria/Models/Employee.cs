using System;
using System.ComponentModel.DataAnnotations;
using concessionaria.Enums;

namespace concessionaria.Models;

public class Employee
{
    [Key]
    public int Id { get; private set;}
    [Required]
    public Guid PublicId { get; private set;} = new Guid();
    [Required]
    public string Name { get; set;} = null!;
    [Required]
    public string Document { get; set;} = null!;
    public DateOnly EntryDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    public DateOnly ExitDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    public Boolean active { get; set; } = true;
    public Role role { get; set; } = Role.Administrador;

}
