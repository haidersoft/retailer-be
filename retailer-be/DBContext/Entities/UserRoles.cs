namespace Retail_BE.DBContext.Entities
{
    public class UserRoles
    {
        public int RoleId { get; set; }
        public int UserId { get; set; }

        public Users Users { get; set; }
        public Roles Roles { get; set; }

    }
}
