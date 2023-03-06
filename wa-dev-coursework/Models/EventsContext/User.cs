using System.ComponentModel.DataAnnotations;

namespace wa_dev_coursework.Models.EventsContext
{
    public class User
    {
        // Constructor
        public User()
        {
            this.CreatedEvents = new HashSet<Event>();
        }

        // Properties
        [Key]
        public Guid ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Nickname { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        //public Guid UserType { get; set; }
        public Guid OrganizationID { get; set; }

        public virtual ICollection<Event> CreatedEvents { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
