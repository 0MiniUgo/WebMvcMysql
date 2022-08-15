using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMvcMysql.Models;

[Table("Usuario")]
public class Usuario
{
    [Display(Name = "Código")]
    [Column("id")]
    public int Id { get; set; }
    [Display(Name = "Nome")]
    [Column("nome")]
    public string Name { get; set; }
}