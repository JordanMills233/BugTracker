using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStorePlugInInterfaces
{
    public interface IProjectRepository
    {
        public IEnumerable<Project> GetProjects();
        void AddProject(Project project);
        void UpdateProject(Project project);
        Project GetProjectById(int ProjectId);
    }
}
