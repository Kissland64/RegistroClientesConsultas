using System.ComponentModel.DataAnnotations;

public class Clientes{
    
    [Key]

    public int ClienteId { get; set; }

    [Required(ErrorMessage = "El campo nombre es obligatorio")]
    [StringLength(maximumLength: 15, MinimumLength = 10)]
    public string Nombre { get; set; } = string.Empty;

    [Required(ErrorMessage = "El campo telefono es obligatorio")]
    [StringLength(maximumLength: 15, MinimumLength = 10)]
    public string? Telefono { get; set; }

    [Required(ErrorMessage = "El campo celular es obligatorio")]
    [StringLength(maximumLength: 15, MinimumLength = 10)]
    public string? Celular { get; set; }

    [Required(ErrorMessage = "El campo rnc es obligatorio")]
    [StringLength(maximumLength: 15, MinimumLength = 10)]
    public string RNC { get; set; } = string.Empty;

    [Required(ErrorMessage = "El campo email es obligatorio")]
    [StringLength(maximumLength: 30, MinimumLength = 15)]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "El campo direccion es obligatorio")]
    [StringLength(maximumLength: 30, MinimumLength = 15)]
    public string Direccion { get; set; } = string.Empty;
}