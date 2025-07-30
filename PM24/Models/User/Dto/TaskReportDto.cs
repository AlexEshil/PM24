using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PM24.Models.Dto
{
    public class TaskReportDto
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int AuthorId { get; set; }
        public string ReportText { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<string> FileUrl { get; set; } // ссылки на загруженные файлы/фото/видео
    }
}