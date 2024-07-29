using System.ComponentModel.DataAnnotations;

namespace SupraSeguros.Web.Models.View
{
    public class Customer
    {
        public Guid ClienteId { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellido { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaNacimiento { get; set; }

        [Required]
        public TipoIdentificacion TipoIdentificacion { get; set; }

        [Required]
        [StringLength(50)]
        public string NumeroIdentificacion { get; set; }

        [Required]
        [StringLength(250)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(50)]
        [Phone]
        public string Telefono { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }
    }

    public enum TipoIdentificacion
    {
        Cedula,
        Pasaporte,
        SeguroSocial
    }
}
