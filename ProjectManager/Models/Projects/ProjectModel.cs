using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectManager.Models.Projects
{
    public class ProjectModel
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Cost")]
        public decimal Cost { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}