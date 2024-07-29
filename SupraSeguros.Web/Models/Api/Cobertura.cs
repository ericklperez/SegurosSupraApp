using System.ComponentModel.DataAnnotations.Schema;

namespace SupraSeguros.Web.Models.Api
{
    public class Cobertura
    {
        public Guid CoberturaId { get; set; }
        public string Descripcion { get; set; }
        public decimal LimiteMaximo { get; set; }
    }
}
