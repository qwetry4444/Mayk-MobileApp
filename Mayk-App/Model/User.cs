using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayk_App.Model
{
    [Table("users")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        [Column("user_id")]
        public int UserId { get; set; }

        [NotNull]
        [Column("first_name")]
        public string FirstName { get; set; }

        [NotNull]
        [Column("last_name")]
        public string LastName { get; set; }

        [NotNull]
        [Column("email")]
        public string Email { get; set; }

        [NotNull]
        [Column("phone_number")]
        public string PhoneNumber { get; set; }

        [NotNull]
        [Column("password")]
        public string Password { get; set; }

        [NotNull]
        [Column("is_admin")]
        public bool IsAdmin { get; set; }



        public User()
        { }

        public User(int userId, string firstName, string lastName, string email, string phoneNumber, string password, bool isAdmin)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Password = password;
            IsAdmin = isAdmin;
        }
    }
}
