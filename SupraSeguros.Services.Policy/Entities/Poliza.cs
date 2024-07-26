using System.ComponentModel.DataAnnotations.Schema;

namespace SupraSeguros.Services.Policy.Entities
{
    public class Poliza
    {
        public Guid PolizaId { get; set; }
        public string NumeroPoliza { get; set; }
        public Guid? ClienteId { get; set; }
        public string TipoSeguro { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string Estado { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        public decimal? Prima { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        public decimal? Deducible { get; set; }
    }
}
