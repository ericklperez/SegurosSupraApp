using System.ComponentModel.DataAnnotations.Schema;

namespace SupraSeguros.Services.Policy.Entities
{
    public class Cobertura
    {
        public Guid CoberturaId { get; set; }
        public string Descripcion { get; set; }
        [Column(TypeName ="decimal(6,2)")]
        public decimal LimiteMaximo { get; set; }
    }
}
