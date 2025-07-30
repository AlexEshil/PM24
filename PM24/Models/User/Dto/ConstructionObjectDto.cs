using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PM24.Models.Dto
{
    public class ConstructionObjectDto
    {
        public int Id { get; set; }// Уникальный идентификатор объекта
        public string Name { get; set; }// Наименование объекта
        public string Address { get; set; } // Адрес объекта
        public DateTime PermitDate { get; set; } // Дата разрешения на строительство
        public DateTime EndDate { get; set; } // Дата окончания строительства

        public string Customer { get; set; } //Заказчик
        public string CustomerLegalAddress { get; set; } //Юр адрес заказчика

        public string TechnicalCustomer { get; set; }//Технический заказчик
        public string TechnicalCustomerLegalAddres { get; set; }//Юр адрес

        public string GeneralContractor { get; set; }//Ген подряд
        public string GeneralContractorLegalAddress { get; set; }//Юр адрес
           // Связь с пользователями
        public List<int> UserIds { get; set; } = new();
    }
}