using System.ComponentModel.DataAnnotations;

public class TicketsDetalles
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Es necesario el TicketId")]
    public int TicketId { get; set; }

    [Required(ErrorMessage = "Es necesario el emisor")]
    public string Emisor { get; set; } = string.Empty;

    [Required(ErrorMessage = "Es necesario el mensaje")]
    public string Mensaje { get; set; } = string.Empty;
}