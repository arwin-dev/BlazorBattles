using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBattles.Shared
{
    public class UserRegister
    {
        [Required, EmailAddress]
        public string Email1 { get; set; }
        [StringLength(16, ErrorMessage = "Your username is too long (16 characters max).")]
        public string Username { get; set; }
        public string Bio { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public int StartUnitId { get; set; } = 1;
        public int Bananas { get; set; } = 100;
        public DateTime DateOfBirth { get; set; } = DateTime.Now;
        public bool IsConfirmed { get; set; } = true;
    }
}
