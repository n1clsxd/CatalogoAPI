﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoAPI.Models;

[Table("Products")]
public class Product
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(80)]
    public string? Name { get; set; }

    [Required]
    [StringLength(300)]
    public string? Description { get; set; }

    [Column(TypeName = "decimal(10,2)")]
    public decimal Price { get; set; }

    [Required]
    [StringLength(300)]
    public string? ImageURL { get; set; }

    
    public float StockCount { get; set; }

    public DateTime RegisterDate { get; set; }

    public int CategoryId { get; set; }

    public Category? Category { get; set; }
}
