namespace Api.Modules.PartReplacement.Dto;

public class AddPartReplacementRequest
{
    public Guid CarId { get; set; }
    public Guid PartId { get; set; }
    public DateOnly Date { get; set; }
}