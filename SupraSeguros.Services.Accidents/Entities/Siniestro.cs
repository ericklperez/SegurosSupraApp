using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Siniestro
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid SiniestroId { get; set; }

    public Guid? PolizaId { get; set; }

    [Column(TypeName = "date")]
    public DateTime? FechaSiniestro { get; set; }

    [StringLength(500)]
    public string DescripcionSiniestro { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? MontoDanios { get; set; }

    [StringLength(50)]
    public string EstadoSiniestro { get; set; }
}
