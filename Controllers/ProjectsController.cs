using Microsoft.AspNetCore.Mvc;
using ProjectMgr.Interfaces;

namespace ProjectMgr.Controllers;


public class ProjectsController : Controller
{
    private readonly IProjectService _service;

    public ProjectsController(IProjectService service)
    {
        _service = service;
    }

    public IActionResult Index([FromQuery]int id)
    {
        var selectedProject = _service.GetProjectById(id);
        return View(selectedProject);
    }
    public IActionResult Initiation()
    {
        return View();
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
