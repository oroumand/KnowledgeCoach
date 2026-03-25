namespace KnowledgeCoach.BuildingBlocks.SharedKernel.Primitives;

public interface IDomainEvent
{
    DateTime OccurredOnUtc { get; }
}