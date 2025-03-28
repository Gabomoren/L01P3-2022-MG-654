using System.ComponentModel.DataAnnotations;

namespace L01P3_2022_MG_654.Models
{
    public class materias
    {
        [Key]
        public int Id { get; set; }

        public string? Materia { get; set; }


        public int unidades_valorativas { get; set; }

        public string? Estado { get; set; }
    }
}
