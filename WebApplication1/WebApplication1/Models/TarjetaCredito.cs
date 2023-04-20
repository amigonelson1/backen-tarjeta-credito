using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class TarjetaCredito
    {
        public int Id { get; set; }
        //entre los los [] podemos usar los data notation para definir requerimientos;
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string numero { get; set; }
        [Required]
        public string fechaExpiracion { get; set; }
        [Required]
        public string CVV { get; set; }
    }
}
