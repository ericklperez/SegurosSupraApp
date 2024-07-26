using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Reclamacion
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid ReclamacionId { get; set; }

    public Guid? PolizaId { get; set; }

    [Column(TypeName = "date")]
    public DateTime? FechaReclamacion { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? MontoReclamado { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? MontoAprobado { get; set; }

    [StringLength(50)]
    public string Estado { get; set; }
}
