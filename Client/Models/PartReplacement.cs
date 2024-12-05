namespace Domain.Models;

public class PartReplacement
{
    public PartReplacement(Guid id, Car car, Part part, DateOnly date)
    {
		this.Id = id;
		this.Car = car;
        this.Part = part;
        this.Date = date;
    }

    private PartReplacement()
    {
    }

    public Guid Id { get; private set; }
    public Car Car { get; private set; } = null!;
    public Part Part { get; private set; } = null!;
    public DateOnly Date { get; private set; }
}