using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseCases.DataStorePlugInInterfaces;

namespace UseCases
{
    public class GetProjectByIdUseCase : IGetProjectByIdUseCase
    {
        private readonly IProjectRepository projectRepository;

        public GetProjectByIdUseCase(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }

        public Project Execute(int ProjectId)
        {
            return projectRepository.GetProjectById(ProjectId);
        }
    }
}
