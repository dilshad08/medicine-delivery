using Shared.Persistence.Models;

namespace AuthService.Models;
public class User : BaseEntity
{
    public string Username { get; set; }
    public string PasswordHash { get; set; }  // For storing hashed password
    public string Email { get; set; }
    public bool IsActive { get; set; }
    public Guid RoleId { get; set; }
    public Role Role { get; set; }

    public ICollection<UserRole> UserRoles { get; set; }
}

public class Role : BaseEntity
{
    public string RoleName { get; set; }
    public ICollection<User> Users { get; set; }
}

public class UserRole
{
    public Guid UserId { get; set; }
    public User User { get; set; }
    public Guid RoleId { get; set; }
    public Role Role { get; set; }
}
