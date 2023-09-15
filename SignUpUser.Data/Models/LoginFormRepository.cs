using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SignUpUser.Data.Models
{
   
    public class LoginFormRepository
    {
        private readonly ApplicationDbContext _db;
        public LoginFormRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public void LoginUser(LoginForm f)
        {
            var userAvailable = _db.SignUpWebForm.Where(u => u.Email == f.Email && u.Password == f.Password).FirstOrDefault();
            if(userAvailable != null)
            {
                Console.WriteLine("Sucess");
            }
            Console.WriteLine("Failure");
        }
    }
}
