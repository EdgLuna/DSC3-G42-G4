		using CuidadoEquino.App.Dominio;
		using Microsoft.EntityFrameworkCore;
		namespace CuidadoEquino.App.Persistencia;

		public class AppContext : DbContext
		{
   			 public DbSet<Persona> Personas { get; set; } // Persona igual o demas
			 public DbSet<Doctor> Doctores { get; set; }
			 public DbSet<Equino> Equinos { get; set; }
             public DbSet<Propietario> Propietarios { get; set; }
			 public DbSet<HistoriaClinica> HistoriasClinicas { get; set; }

			 public DbSet<RegistroVisita> RegistroVisitas { get; set; }
   			 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   			 {

        			if (!optionsBuilder.IsConfigured)// configuracion de la base de datos   db

        				{
           				 	optionsBuilder
            					.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = CuidadoEquinoData");

        				}
    			}
		}
      