using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using concessionaria.Enums;
using Concessionaria.Models;

namespace concessionaria.Models;

public class Sale
{
    [Key]
    public int Id { get; set;}
    public Guid PublicId { get; set;} = new Guid();

    public int CarId { get; set;} //chave estrangeira
    public Car car { get; set;} = null!;
    public Employee employee{ get; set; } = null!;
    public PaymentMethod PaymentMethod{ get; set; } = PaymentMethod.Debito;
    [Column(TypeName = "decimal(18,2)")]
    public decimal FinalPrice {get; set; } = 0;
    public decimal Discount {get; set;}
    [Column(TypeName = "decimal(18,2)")]
    public decimal PriceWithDiscount {get; set;}
    public DateOnly Date {get; set; } = DateOnly.FromDateTime(DateTime.Now);



}
