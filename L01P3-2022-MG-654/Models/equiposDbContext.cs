using L01P3_2022_MG_654.Models;
using Microsoft.EntityFrameworkCore;

public class equiposDbContext : DbContext
{
    public equiposDbContext(DbContextOptions options) : base(options)
    {
        }

    public DbSet<alumnos> alumnos { get; set; }
    public DbSet<departamentos> departamentos { get; set; }
    public DbSet<facultades> facultades { get; set; }

    public DbSet<materias> materias { get; set; }

}