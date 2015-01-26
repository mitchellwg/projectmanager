using System;

namespace Dapper.Repositories.Entities
{
    public class Lesson : IEntity
    {
        public int Id { get; set; }

        public bool IsPro { get; set; }
        public string Title { get; set; }
        public string Remarks { get; set; }
        public DateTime CreatedDate { get; set; }
        public int ProjectId { get; set; }
        public int PhaseId { get; set; }
    }
}
