using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using concessionaria.Models;
namespace Concessionaria.Models;
    public class Car
    {
        [Key]
        public int Id { get; set; }

        public Guid PublicId { get; set; } = Guid.NewGuid();

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [Required]
        public Brand Brand { get; set; } = null!;

        [Required]
        public Category Category { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; } = null!;

        public List<Image> Images { get; set; } = new List<Image>();

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; } = 0;

        public string Description { get; set; } = null!;

        [Required]
        [Range(1900, 2100)]
        public int Year { get; set; }

        public double Km { get; set; } = 0;

        public int LastNumberLicensePlate { get; set; }

        [MaxLength(30)]
        public string Color { get; set; } = null!;

        [MaxLength(30)]
        public string Transmission { get; set; } = null!;

        [MaxLength(30)]
        public string Fuel { get; set; }  = null!;

        public List<AditionalFeature> AditionalFeatures { get; set; } = new List<AditionalFeature>();

        public Sale? Sale { get; set; }

    }
