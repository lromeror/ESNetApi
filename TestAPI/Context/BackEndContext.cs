using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

namespace TestAPI.Context
{
    public class BackEndContext: DbContext
    {
        public BackEndContext(DbContextOptions<BackEndContext> options):base(options) { //Constructor de la clase base, pasamos parametro option
            //Inicializar el contexto de la base de datos, Inyeccion de dependecias

        }

        public DbSet<Person> Persons { get; set; }// Clase EF, una coleccion de entidades en las bases de Datos, tipo del modelo que se contrsuye
        public DbSet<Product> Product { get; set; }
        //Los get and set, Propiedad para realizar operaciones de escributra en la base de dato Persons
    }
}
