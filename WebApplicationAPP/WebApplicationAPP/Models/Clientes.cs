using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationAPP.Models
{
        [Table("Cliente_JafethPoveda")]

        public class Clientes
        {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }

        public string Telefono { get; set; }

        public string Direccion {  get; set; }

        public DateTime FechaRegistro { get; set; }

        public bool Estado { get; set; }=false;

        }

}
