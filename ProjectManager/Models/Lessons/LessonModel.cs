using System;

namespace ProjectManager.Models.Lessons
{
    public class LessonModel
    {
        public int Id { get; set; }
        public string Phase { get; set; }
        public string PC { get; set; }
        public string Title { get; set; }
        public string Remarks { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}