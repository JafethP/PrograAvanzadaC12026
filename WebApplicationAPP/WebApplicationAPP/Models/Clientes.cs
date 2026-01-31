namespace WebApplicationAPP.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }

        public string Telefono { get; set; }

        public string Direccion {  get; set; }

        public DateTime FechaRegistro { get; set; }

        public bool Activo { get; set; }=false;

    }
}
