using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public DbSet<Pelicula> Peliculas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Especifica la conexión a SQLite, usando una base de datos local en la ruta especificada.
        optionsBuilder.UseSqlite("Data Source=peliculas.db");
    }
}
