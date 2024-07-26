using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Pago
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PagoId { get; set; }

    public Guid? PolizaId { get; set; }

    [Column(TypeName = "date")]
    public DateTime? FechaPago { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Monto { get; set; }

    [StringLength(50)]
    public string MetodoPago { get; set; }

    [StringLength(50)]
    public string EstadoPago { get; set; }
}
