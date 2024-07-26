using System.ComponentModel.DataAnnotations.Schema;

namespace SupraSeguros.Services.Policy.Entities
{
    public class PolizaCobertura
    {
        public Guid CoberturaId { get; set; }
        public Guid PolizaCoberturaId { get; set; }
        public Guid PolizaId { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        public decimal MontoCubierto { get; set; }

    }
}
