using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SignUpUser.Data.Models
{
    public class SignUpWebForm
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        public string Username { get; set; }
        [MaxLength(30)]
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
