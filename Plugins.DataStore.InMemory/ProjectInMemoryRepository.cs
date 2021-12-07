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
                new Project { Id = 1, Description  = "Test Project 1", Name = "Test Project 1", StartDate = DateTime.UtcNow, EndDate = DateTime.UtcNow, CompanyId = 1, ProjectPriorityId = 1},
                new Project { Id = 2,  Description = "Test Project 2", Name = "Test Project 2", StartDate = DateTime.Now, EndDate = DateTime.Today, CompanyId = 1, ProjectPriorityId = 1}
            };
        }

        public void AddProject(Project project)
        {
            if (projects.Any(x => x.Name.Equals(project.Name, StringComparison.OrdinalIgnoreCase))) return;

            if(projects != null && projects.Count > 0)
            {
                var maxId = projects.Max(x => x.Id);
                project.Id = maxId + 1;
            }
            else
            {
                project.Id = 1;
            }

            projects.Add(project);
        }

        public Project GetProjectById(int ProjectId)
        {
            return projects?.FirstOrDefault(x => x.Id == ProjectId);
        }

        public IEnumerable<Project> GetProjects()
        {
            return projects;
        }

        public void UpdateProject(Project project)
        {
            var projectToUpdate = GetProjectById(project.Id);
            if (projectToUpdate != null) 
            {
                projectToUpdate.Name = project.Name;
                projectToUpdate.Description = project.Description;
            }
        }
    }
}