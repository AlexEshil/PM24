using PM24.Enums;
using System.ComponentModel.DataAnnotations; 

namespace PM24.Models.Entity
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime DateRegistred { get; set; }
        public DateTime DateBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public UserRoleDto Role { get; set; }

        // Вот тут связь “многие ко многим” с ConstructionObject
        public virtual ICollection<ConstructionObject> ConstructionObjects { get; set; } = new List<ConstructionObject>();
    }
}
