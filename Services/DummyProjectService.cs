using ProjectMgr.Models;

namespace ProjectMgr.Services
{
    public class DummyProjectService
    {
        public List<Project> myProjects = new() {
        new Project {Id = 1, ProjectName="ProjectMgr", Description="Project Management tool for small projects/teams. Based on PMIs process groups.", Owner="Tinashe Chitakunye", StartedOn=DateTime.Parse("2021-12-13"), ClosedOn=DateTime.Parse("2022-02-01")},
        new Project {Id = 2, ProjectName="Abacustore", Description="Inventory Management System for small/medium stores.", Owner="Tinashe Chitakunye", StartedOn=DateTime.Parse("2022-02-03"), ClosedOn=DateTime.Parse("2022-02-26")},
        new Project {Id = 3, ProjectName="Kubhuya", Description="Small chat app for localised communications.", Owner="Anesu Chitakunye", StartedOn=DateTime.Parse("2022-01-13"), ClosedOn=DateTime.Parse("2022-04-01")},
        new Project {Id = 4, ProjectName="Bugly", Description="Bug tracking application for reporting, analysing, and resolving client tickets.", Owner="Tinashe Chitakunye", StartedOn=DateTime.Parse("2021-09-18"), ClosedOn=DateTime.Parse("2021-11-01")},
        new Project {Id = 5, ProjectName="Gadza", Description="News Recommendation System for subscribers based on their view choices.", Owner="Richard Dzingai", StartedOn=DateTime.Parse("2021-12-13"), ClosedOn=DateTime.Parse("2022-03-03")}
    };

        public IEnumerable<Project> GetProjects()
        {
            return myProjects;
        }

        public Project GetProject(int id)
        {
            return myProjects.FirstOrDefault(p => p.Id == id) ?? null;
        }
    }
}