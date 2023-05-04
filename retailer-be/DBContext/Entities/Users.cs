namespace Retail_BE.DBContext.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
        public int IsActive { get; set; }

        public ICollection<UserRoles> UserRoles { get; set; }
        public virtual ICollection<UserPackages> UserPackages { get; set; }


    }
}
