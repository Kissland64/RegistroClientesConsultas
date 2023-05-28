using System.ComponentModel.DataAnnotations;

public class Tickets
{
    [Key]
    public int TicketsId { get; set; }

    [Required (ErrorMessage ="El nombre del sistema es obligatorio")]
    public String Nombre { get; set; }
}
