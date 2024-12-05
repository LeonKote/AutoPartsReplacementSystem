namespace Domain.Models;

public class Part
{
    public Part(Guid id, string name, string description)
    {
        this.Id = id;
        this.Name = name;
        this.Description = description;
    }
    
    private Part() {}

    public Guid Id { get; private set; }
    public string Name { get; private set; } = null!;
    public string Description { get; private set; } = null!;
    
    public List<PartReplacement> PartReplacements { get; private set; } = [];
}