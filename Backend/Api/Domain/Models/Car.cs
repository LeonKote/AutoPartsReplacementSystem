namespace Domain.Models;

public class Car
{
    public Car(string make, string model, int year)
    {
        this.Make = make;
        this.Model = model;
        this.Year = year;
    }

    protected Car()
    {
    }

    public Guid Id { get; private set; }
    public string Make { get; private set; } = null!;
    public string Model { get; private set; } = null!;
    public int Year { get; private set; }

    public List<PartReplacement> PartReplacements { get; private set; } = [];
}