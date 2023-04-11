using System.ComponentModel.DataAnnotations;

namespace EjercicioPeliculas.Models;

public class Movie{
    public string Code { get; set; }

    [Display(Name="Nombre")]
    [Required]
    public string Name { get; set; }
    [Display(Name="Tiempo en minutos")]
    public int Runtime { get; set; }
    [Display(Name="Genero")]
    public string Category { get; set; }
}