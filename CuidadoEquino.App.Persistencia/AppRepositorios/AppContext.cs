/// <summary> Equino sin domar </summary> ///
/* GIT H.U.B--- */
/* Version 1.1 */
using Microsoft.EntityFrameworkCore;
using CuidadoEquino.App.Dominio;
namespace CuidadoEquino.App.Persistencia;

public class AppContext : DbContext
{
    public DbSet<Persona> Personas { get; set; }
    public DbSet<Doctor> Doctores { get; set; }
	public DbSet<Equino> Equinos { get; set; }
    public DbSet<Propietario> Propietarios { get; set; }
	public DbSet<Historia> HistoriasClinicas { get; set; }
    public DbSet<RegistroVisita> RegistroVisitas { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)// configuracion de la base de datos 

        {
            optionsBuilder
            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = CuidadoEquinoData");

        }
    }
}