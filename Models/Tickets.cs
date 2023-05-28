using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Tickets
{
    [Key]

    [Required (ErrorMessage ="El campo ticket es obligatorio")]
    public int TicketsId { get; set; }

    [Required (ErrorMessage ="El campo fecha es obligatorio")]
    public DateTime Fecha { get; set; }

    [ForeignKey("ClienteId")]
    public int ClienteId { get; set; }

    [Required (ErrorMessage ="El campo sistemaId es obligatorio")]
    public int SistemaId { get; set; }

    [ForeignKey("PrioridadId")]
    public int PrioridadId { get; set; }

    [Required (ErrorMessage ="El campo solicitadoPor es obligatorio")]
    public string SolicitadoPor { get; set; }

    [Required (ErrorMessage ="El campo asunto es obligatorio")]
    public string Asunto { get; set; }

    [Required (ErrorMessage ="El campo descripcion es obligatorio")]
    public string Descripcion { get; set; }
}
