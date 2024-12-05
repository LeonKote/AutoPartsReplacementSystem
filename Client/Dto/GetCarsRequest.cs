namespace Api.Modules.Car.Dto;

public class GetCarsRequest
{
    public string? Make { get; set; }
    public string? Model { get; set; }
    public int? MinYear { get; set; }
    public int? MaxYear { get; set; }
}