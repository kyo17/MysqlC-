using System;
using System.ComponentModel.DataAnnotations;

namespace APIElectron.Models
{
    public class User
    {
        public User()
        {
            idUser = Guid.NewGuid().ToString();
        }
        [Key]
        public string idUser { get; set; }
        [EmailAddress]
        [Required, MaxLength(250)]
        public string email { get; set; }
        [Range(1, 120)]
        [Required]
        public int age { get; set; }
    }
}
