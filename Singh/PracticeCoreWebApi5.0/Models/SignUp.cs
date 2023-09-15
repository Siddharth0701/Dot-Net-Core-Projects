using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeCoreWebApi5._0.Models
{
    public class SignUp
    {
        [Key]
        public int Id { get; set   ; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(30)]
        public string Username { get; set; }
        [MaxLength(30)]
        public string Password { get; set; }

    }
}
