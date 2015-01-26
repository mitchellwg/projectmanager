using System.Linq;
using AutoMapper;
using Dapper.Repositories;
using Dapper.Repositories.Entities;
using System;
using System.Web.Mvc;
using ProjectManager.Models.Projects;

namespace ProjectManager.Controllers
{
    public class ProjectsController : Controller
    {
        public ActionResult Index()
        {
            var projectRepository = new SimpleRepository<Project>();
            var projects = projectRepository.All();
            var projectModels = projects.Select(Mapper.Map<Project, ProjectModel>);
            return View(projectModels);
        }   

        public ActionResult New()
        {
            //var projectNewModel = new ProjectNewModel();

            return View();
        }

        public ActionResult Edit(int id)
        {
            ViewBag.id = Convert.ToInt32(id);
            return View();
        }

        public ActionResult ViewProject(int id)
        {
            var projectRepository = new SimpleRepository<Project>();
            var project = projectRepository.Get(id);
            var projectModel = Mapper.Map<Project, ProjectModel>(project);
            return View(projectModel);
        }
    }
}
