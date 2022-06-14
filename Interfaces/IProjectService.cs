using ProjectMgr.Models;

namespace ProjectMgr.Interfaces
{
    public interface IProjectService
    {
        public IEnumerable<Project> GetAllProjects();
        public Project GetProjectById(int id);

    }
}