namespace Retail_BE.DBContext.Entities
{
    public class Packages
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int MBS { get; set; }
        public int Type { get; set; }
        public virtual ICollection<UserPackages> UserPackages { get; set; }
    }
}
