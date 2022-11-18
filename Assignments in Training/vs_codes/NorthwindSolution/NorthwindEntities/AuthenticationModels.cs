using System.ComponentModel.DataAnnotations;

namespace NorthwindEntities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Username is requried. ")]
        public string Username { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is requried. ")]
        public string Password { get; set; }
        public string FullName { get => $"{FirstName} {LastName}"; }//"Mohan  Madan"
        public void Deconstruct(out int userId, out string fullName)
        {
            userId = UserId;
            fullName = FullName;
        }
    }
    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }

    }
    public class UserRole
    {
        [Key]
        public int UserId { get; set; }
        public int RoleId { get; set; }

    }
    public class ApplicationUser
    {
        [Key]
        public int AppID { get; set; }
        public string ApplicationName { get; set; }
        [MinLength(32, ErrorMessage = "Secret Key should be atleast 32 characters. ")]
        public string AppSecretKey { get; set; }
    }

    public class AuthenticationResponse
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string Token { get; set; }
        public AuthenticationResponse(User user,string token)
        {
            (UserId, FullName) = user;
            Token = token;
        }
    }
}
