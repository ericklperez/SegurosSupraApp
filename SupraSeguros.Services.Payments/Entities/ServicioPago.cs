using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ServicioPago
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid ServicioPagoId { get; set; }

    [StringLength(250)]
    public string Descripcion { get; set; }

    [StringLength(100)]
    public string Proveedor { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Costo { get; set; }
}
