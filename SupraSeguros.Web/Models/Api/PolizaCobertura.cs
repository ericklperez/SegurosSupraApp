using System.ComponentModel.DataAnnotations.Schema;

namespace SupraSeguros.Web.Models.Api
{
    public class PolizaCobertura
    {
        public Guid CoberturaId { get; set; }
        public Guid PolizaCoberturaId { get; set; }
        public Guid PolizaId { get; set; }
        public decimal MontoCubierto { get; set; }
    }
}
