using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class AcuerdoPago
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid AcuerdoPagoId { get; set; }

    public Guid? ClienteId { get; set; }

    public Guid? PolizaId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? MontoAcordado { get; set; }

    [Column(TypeName = "date")]
    public DateTime? FechaInicio { get; set; }

    [Column(TypeName = "date")]
    public DateTime? FechaFin { get; set; }

    [StringLength(50)]
    public string EstadoAcuerdo { get; set; }
}
