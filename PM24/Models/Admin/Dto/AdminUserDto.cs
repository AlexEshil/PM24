using PM24.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace PM24.Models.Admin
{
    public class AdminUserDto
    {
        public int Id { get; set; } // Уникальный идентификатор (автоинкремент)
        public string FullName { get; set; } // ФИО админа
        public string Email { get; set; } // E-mail для входа и оповещений
        public string PhoneNumber { get; set; } // Телефон (если потребуется подтверждение/двухфакторка)
        public string PasswordHash { get; set; } // Пароль (в хэше)
        public bool IsActive { get; set; } = true; // Флаг активен/заблокирован
        [Column(TypeName = "datetime2(0)")]
        public DateTime? CreatedAt { get; set; }// Когда был создан
         [Column(TypeName = "datetime2(0)")]
        public DateTime? LastLogin { get; set; } // Когда последний раз логинился
    }
}
