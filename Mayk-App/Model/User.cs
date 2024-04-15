using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayk_App.Model
{
    public class User
    {
        [PrimaryKey, AutoIncrement, NotNull]
        public int UserId { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int RoleID { get; set; }
        public bool IsAdmin { get; set; }
    }
}
