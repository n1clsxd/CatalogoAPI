using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CatalogoAPI.Models;

[Table("Categories")]
public class Category
{
    [Key]
    public int Id { get; set; }

    [Required][StringLength(40)]
    public string? Name { get; set; }

    [Required]
    [StringLength(300)]
    public string? ImageURL { get; set; }
      
    public ICollection<Product>? Products { get; set; }

    public Category() { 
        Products = new Collection<Product>();
    }

}
