using System.ComponentModel.DataAnnotations;

public class Prioridades
{
    [Key]
    public int PrioridadId { get; set; }

    [Required(ErrorMessage = "Es obligatorio tener una descripcion")]
    public string? Descripcion { get; set; }

    [Required(ErrorMessage = "Es obligatorio tener dias compromiso")]
    public int DiasCompromiso { get; set; }
}