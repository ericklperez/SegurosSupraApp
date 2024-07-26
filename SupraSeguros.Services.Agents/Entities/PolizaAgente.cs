using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class PolizaAgente
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid PolizaAgenteId { get; set; }

    public Guid? PolizaId { get; set; }

    public Guid? AgenteId { get; set; }

    [Column(TypeName = "date")]
    public DateTime? FechaAsignacion { get; set; }
}
