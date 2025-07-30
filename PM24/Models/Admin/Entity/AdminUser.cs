using System;
using System.ComponentModel.DataAnnotations;
using PM24.Enums;

namespace PM24.Models.Entity
{
    public class AdminUser
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }
        
        public string PhoneNumber { get; set; }
        
        [Required]
        public string PasswordHash { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? LastLogin { get; set; }

    }
}
