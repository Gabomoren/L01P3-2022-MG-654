using System.ComponentModel.DataAnnotations;

namespace L01P3_2022_MG_654.Models;
    public class departamentos
{

    [Key]
    public int id { get; set; }

    public string? departamento { get; set; }
}

