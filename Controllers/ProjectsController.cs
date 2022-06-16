using Microsoft.AspNetCore.Mvc;
using ProjectMgr.Services;

namespace ProjectMgr.Controllers;


public class ProjectsController : Controller
{
    private readonly DummyProjectService _projectService;
    private readonly DummyStakeholderService _stakeholderService;

    public int projectId { get; set; } = default;

    public ProjectsController(DummyProjectService projectService, DummyStakeholderService stakeholderService)
    {
        _projectService = projectService;
        _stakeholderService = stakeholderService;
    }

    public IActionResult Index(int id)
    {
        var selectedProject = _projectService.GetProject(id);
        return View(selectedProject);
    }

    public IActionResult Initiation()
    {
        var allStakeholders = _stakeholderService.GetStakeholders();
        return View(allStakeholders);
    }
    public IActionResult Planning()
    {
        return View();
    }
    
    public IActionResult Executing()
    {
        return View();
    }
    public IActionResult Monitoring()
    {
        return View();
    }
    public IActionResult Closing()
    {
        return View();
    }

}
