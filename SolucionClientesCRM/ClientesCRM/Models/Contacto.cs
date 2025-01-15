namespace ClientesCRM.Models
{
    public class Contacto
    {
        public int ContactoId { get; set; }
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Rol { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Notas { get; set; }

        // Propiedad de navegación para la relación con Cliente
        public Cliente Cliente { get; set; }
    }
}
