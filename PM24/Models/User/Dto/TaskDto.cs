using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PM24.Enums;

namespace PM24.Models.Dto
{
    public class TaskDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TaskStatusDto StatusDto { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? DueDate { get; set; } // Дедлайн
        public int CreatorId { get; set; }  // Кто поставил задачу (User.Id)
        public int AssigneeId { get; set; } //Исполнитель
        public List<int> ObserverIds { get; set; } //Наблюдатели   
        public int ConstructionObjectId  { get; set; }  // Id объекта строительства
    }
}