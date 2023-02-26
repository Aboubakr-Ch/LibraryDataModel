using System.ComponentModel.DataAnnotations;

namespace LibraryDataModel.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreationDate { get; set; }

        public int CreatorId { get; set; }

        public virtual User? Creator { get; set; }

        public DateTime EditDate { get; set; }

        public int EditId { get; set; }

        public virtual User? Editor { get; set; }
    }
}
