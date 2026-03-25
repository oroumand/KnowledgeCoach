namespace KnowledgeCoach.BuildingBlocks.Framework.Abstractions;

public interface ICommand
{
}

public interface ICommand<out TResult>
{
}