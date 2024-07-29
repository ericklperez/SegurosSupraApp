using System.ComponentModel.DataAnnotations.Schema;

namespace SupraSeguros.Web.Models.Api
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
        public decimal? Prima { get; set; }
        public decimal? Deducible { get; set; }
    }
}
