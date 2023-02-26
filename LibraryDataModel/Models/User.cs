using System.ComponentModel.DataAnnotations;

namespace LibraryDataModel.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        public UserType UserType { get; set; }

        public virtual ICollection<BorrowingRecord>? BorrowingRecordCreators { get; set; }

        public virtual ICollection<BorrowingRecord>? BorrowingRecordModifiers { get; set; }

        public virtual ICollection<Card>? CardCreators { get; set; }

        public virtual ICollection<Card>? CardModifiers { get; set; }

        public virtual ICollection<Book>? BookCreators { get; set; }

        public virtual ICollection<Book>? BookModifiers { get; set; }
    }

    public enum UserType
    {
        admin,
        user
    }
}
