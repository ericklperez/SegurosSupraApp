namespace SupraSeguros.Services.Policy.Entities
{
    public class Cobertura
    {
        public Guid CoberturaId { get; set; }
        public string Descripcion { get; set; }
        public decimal LimeteMaximo { get; set; }
    }
}
