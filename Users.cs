using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRR_8
{
    internal enum UserRole
    {
        Administator,
        Manager,
        Trainer,
        Accountant

    }
    internal class AuthUser
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public bool IsActive { get; set; } = true;
    }
}

    
