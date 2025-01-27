using System.ComponentModel.DataAnnotations;

namespace Barber.DTO
{
    public class UsuarioDTO
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string foto { get; set; }
        public string numero { get; set; }
        public string password { get; set; }    
        public string role { get; set; }
    }
}

