using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PM24.Models.Entity
{
    public class ReportFile
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }

        [ForeignKey("TaskReport")]
        public int TaskReportId { get; set; }
        public virtual TaskReport TaskReport { get; set;}
    }
}