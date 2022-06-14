#nullable disable
using System.ComponentModel.DataAnnotations;

namespace ProjectMgr.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Required]
        public string ProjectName { get; set; }
        [MaxLength(255)]
        public string Description { get; set; }
        [Required]
        public string Owner { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartedOn { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime ClosedOn { get; set; }
        


    }
}