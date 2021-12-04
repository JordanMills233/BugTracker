using Core;
using UseCases.DataStorePlugInInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class ProjectInMemoryRepository : IProjectRepository
    {
        private List<Project> projects;

        public ProjectInMemoryRepository()
        {
            //Add some default Projects

            projects = new List<Project>()
            {
                new Project { ProjectId = 1,  ProjectDescription = "Test Project", ProjectName = "Test Project", },
                new Project { ProjectId = 2,  ProjectDescription = "Test Project 2", ProjectName = "Test Project 2", }
            };
        }

        public void AddProject(Project project)
        {
            if (projects.Any(x => x.ProjectName.Equals(project.ProjectName, StringComparison.OrdinalIgnoreCase))) return;

            if(projects != null && projects.Count > 0)
            {
                var maxId = projects.Max(x => x.ProjectId);
                project.ProjectId = maxId + 1;
            }
            else
            {
                project.ProjectId = 1;
            }

            projects.Add(project);
        }

        public Project GetProjectById(int ProjectId)
        {
            return projects?.FirstOrDefault(x => x.ProjectId == ProjectId);
        }

        public IEnumerable<Project> GetProjects()
        {
            return projects;
        }

        public void UpdateProject(Project project)
        {
            var projectToUpdate = GetProjectById(project.ProjectId);
            if (projectToUpdate != null) 
            {
                projectToUpdate.ProjectName = project.ProjectName;
                projectToUpdate.ProjectDescription = project.ProjectDescription;
            }
        }
    }
}