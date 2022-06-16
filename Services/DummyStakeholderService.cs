using ProjectMgr.Models;

namespace ProjectMgr.Services
{
    public class DummyStakeholderService
    {
        public List<Stakeholder> selectedStakeholders = new()
        {
            new Stakeholder {Id=1, Name="Tinashe Chitakunye", Role="Project Owner", Function="Liason between client and project team", Email="tinashec93@live.com", ProjectTitle="ProjectMgr"}, 
            new Stakeholder {Id=2, Name="Anesu Chitakunye", Role="Scrum Master", Function="Oversee Scrum activities for the team", Email="anesu.chitakunye@gmail.com", ProjectTitle="ProjectMgr"}, 
            new Stakeholder {Id=3, Name="Richard Javangwe", Role="DevOps Engineer", Function="Manages the CI/CD pipeline for the product", Email="rj6820@gmail.com", ProjectTitle="ProjectMgr"}, 
        };

        public List<Stakeholder> GetStakeholders()
        {
            return selectedStakeholders;
        }

        public Stakeholder GetStakeholder(int id)
        {
            return selectedStakeholders.FirstOrDefault(p => p.Id == id);
        } 
    }
}