using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Barber.Models;

public class Usuarios 
{
    [Key]
    public int id {get; set;}
    public string nome { get; set; }
    public string foto { get; set; }
    public string numero { get; set; }
    public string hash { get; set; }
    public string salt { get; set; }
    public string role { get; set; }
}
