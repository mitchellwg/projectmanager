namespace Dapper.Repositories.Entities
{
    public class Company : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
