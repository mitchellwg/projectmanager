using System;

namespace Dapper.Repositories.Entities
{
    public class Project : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }

        public int UserId { get; set; }
    }
}
