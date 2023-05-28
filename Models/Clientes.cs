using System.ComponentModel.DataAnnotations;

public class Clientes{
    
    [Key]

    public int ClienteId { get; set; }

    [Required(ErrorMessage = "El campo nombre es obligatorio")]

    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "El campo telefono es obligatorio")]
    public string? Telefono { get; set; }

    [Required(ErrorMessage = "El campo celular es obligatorio")]
    public string? Celular { get; set; }

    [Required(ErrorMessage = "El campo rnc es obligatorio")]
    public string RNC { get; set; } = string.Empty;

    [Required(ErrorMessage = "El campo email es obligatorio")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "El campo direccion es obligatorio")]
    public string Direccion { get; set; } = string.Empty;
}