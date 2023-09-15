using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SignUpUser.Data.Models
{
    
     public class SignUpWebFormRepository
    {

        public readonly ApplicationDbContext _db;
        public SignUpWebFormRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<SignUpWebForm> GetAllSingupUser()
        {
            return _db.SignUpWebForm.ToList();
        }

        public void AddUser(SignUpWebForm s)
        {
            _db.SignUpWebForm.Add(s);
            _db.SaveChanges();
        }
    }
}
