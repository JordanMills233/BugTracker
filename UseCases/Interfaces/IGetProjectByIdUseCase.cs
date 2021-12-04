using Core;

namespace UseCases
{
    public interface IGetProjectByIdUseCase
    {
        Project Execute(int ProjectId);
    }
}