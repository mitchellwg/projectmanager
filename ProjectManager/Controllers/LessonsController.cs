using System.Web.Mvc;

namespace ProjectManager.Controllers
{
    public class LessonsController : Controller
    {
        //
        // GET: /Lessons/

        public ActionResult Index()
        {
            //var lessons = new LessonModel();
            //lessons.Lessons = bl_lesson.GetLessons();


            return View();
        }

        public ActionResult New()
        {
            //var LessonNewModel = new LessonNewModel();

            return View();
        }

    }
}
