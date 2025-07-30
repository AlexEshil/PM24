using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PM24.Enums;

namespace PM24.Models.Dto
{
    public class UserDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateRegistred { get; set; }
        public DateTime DateBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public UserRoleDto Role { get; set; }
          // Связь с объектами
        public List<int> ConstructionObjectIds { get; set; } = new();
    }
}