using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestAPI.Models
{
    [Table("producto")]
    public class Product
    {
        [Key]//nos ayudara a mapear el key de nuestra columna, NO ES NECESARIO MAPEAR SI se llaman iguales tanto en la base como en la clase
        [Column("id")]
        public int id { get; set; }
        [Column("nombre")]
        public string name { get; set; }
        [Column("descripcion")]
        public string description { get; set; }
        [Column("precio")]
        public decimal precio { get; set; }

        public Product()
        {

        }
        public Product(int id, string nombre, decimal precio)
        {
            this.id = id;
            name = nombre;
            this.precio = precio;
        }

        public Product(int id, string nombre)
        {
            this.id = id;
            name = nombre;
            precio = 2000;
        }

    }
}
