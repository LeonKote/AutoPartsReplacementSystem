using System.ComponentModel.DataAnnotations;

namespace Api.Modules.Car.Dto;

public class AddCarRequest
{
    [Required] public string Make { get; set; } = null!;
    [Required] public string Model { get; set; } = null!;
    [Required] public int Year { get; set; }
}