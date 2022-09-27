using System.ComponentModel.DataAnnotations;

namespace ProEShop.Entities;
public class Category
{
    public int Id { get; set; }
    [Required]
    [MaxLength(300)]
    public string Titele { get; set; }

}
