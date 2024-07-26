using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Agente
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public Guid AgenteId { get; set; }

    [StringLength(100)]
    public string Nombre { get; set; }

    [StringLength(100)]
    public string Apellido { get; set; }

    [StringLength(50)]
    public string Telefono { get; set; }

    [StringLength(100)]
    public string Email { get; set; }

    [StringLength(50)]
    public string CodigoAgente { get; set; }
}
