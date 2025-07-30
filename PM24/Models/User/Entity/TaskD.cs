using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PM24.Enums;

namespace PM24.Models.Entity
{
    public class TaskD
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        public TaskStatusDto StatusDto { get; set; } // enum, как и в DTO

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? DueDate { get; set; }

        // Связи с User (создатель и исполнитель)
        [ForeignKey("Creator")]
        public int CreatorId { get; set; }
        public virtual User Creator { get; set; }

        [ForeignKey("Assignee")]
        public int AssigneeId { get; set; }
        public virtual User Assignee { get; set; }

        // Множественная связь с наблюдателями (многие ко многим)
        public virtual ICollection<User> Observers { get; set; } = new List<User>();

        // Связь с объектом строительства
        [ForeignKey("ConstructionObject")]
        public int ConstructionObjectId { get; set; }
        public virtual ConstructionObject ConstructionObject { get; set; }
    }
}
