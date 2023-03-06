using System.ComponentModel.DataAnnotations;

namespace wa_dev_coursework.Models.EventsContext
{
    public class Organization
    {
        // Constructor
        public Organization()
        {
            this.Workers = new HashSet<User>();
        }

        // Properties
        [Key]
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public string Email { get; set; }

        public virtual ICollection<User> Workers { get; set; }
    }
}
