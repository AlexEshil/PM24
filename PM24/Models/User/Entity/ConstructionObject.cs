using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PM24.Models.Entity
{
    public class ConstructionObject
    {
        [Key]
        public int Id { get; set; } // Primary Key

        [Required]
        public string Name { get; set; }  // Наименование объекта

        [Required]
        public string Address { get; set; }  // Адрес объекта

        public DateTime PermitDate { get; set; } // Дата разрешения на строительство
        public DateTime EndDate { get; set; }    // Дата окончания строительства

        public string Customer { get; set; }                  // Заказчик
        public string CustomerLegalAddress { get; set; }      // Юр. адрес заказчика

        public string TechnicalCustomer { get; set; }         // Технический заказчик
        public string TechnicalCustomerLegalAddress { get; set; } // Юр. адрес

        public string GeneralContractor { get; set; }         // Генеральный подрядчик
        public string GeneralContractorLegalAddress { get; set; } // Юр. адрес

        // Навигационное свойство: связь "многие ко многим" с пользователями
        public virtual ICollection<User> Users { get; set; } = new List<User>();
    }
}
