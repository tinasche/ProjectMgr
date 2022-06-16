using System.ComponentModel.DataAnnotations;

namespace ProjectMgr.Models
{
    public class Stakeholder
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Role { get; set; }
        public string Function { get; set; }
        public string Email { get; set; }
        public string ProjectTitle { get; set; }
        [DataType(DataType.Date)]
        public DateTime JoinedOn { get; set; }
    }
}