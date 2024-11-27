namespace Infrastructure.Services.PartReplacement.Dto;

public record AddPartReplacementBody(Guid CarId, Guid PartId, DateOnly Date);