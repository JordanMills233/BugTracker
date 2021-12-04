using Core;

namespace UseCases
{
    public interface IViewProjectUseCase
    {
        IEnumerable<Project> Execute();
    }
}