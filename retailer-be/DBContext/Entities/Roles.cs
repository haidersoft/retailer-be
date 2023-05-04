namespace Retail_BE.DBContext.Entities
{
    public class Roles
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public ICollection<UserRoles> UserRoles { get; set; }
    }
}
