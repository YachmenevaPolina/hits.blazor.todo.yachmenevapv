using System.ComponentModel.DataAnnotations;

namespace TodoServerApp.Data
{
    public class TaskItem
    {
        public int ID { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? FinishDate { get; set; }
    }
}
