namespace Retail_BE.DBContext.Entities
{
    public class UserPackages
    {
        public int UserId { get; set; }
        public int PackageId { get; set; }
        public int Status { get; set; }
        public Users Users { get; set; }
        public Packages Packages { get; set; }
    }
}
