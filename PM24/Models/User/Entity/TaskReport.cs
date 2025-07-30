using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PM24.Models.Entity
{
    public class TaskReport
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("TaskD")]
        public int TaskId { get; set; }
        public virtual TaskD Task { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public virtual User Author { get; set; }

        [Required]
        public string ReportText { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Если файлы нужно хранить в базе как отдельные сущности
        public virtual ICollection<ReportFile> Files { get; set; } = new List<ReportFile>();

        // Если файлы просто как ссылки, можно сделать так:
        // public string FileUrls { get; set; } // Cохранять в виде строки через запятую
    }
}
