using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace LibraryDataModel.Models
{
    public class Card : BaseEntity
    {
        [Required]
        public string Code { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = string.Empty;

        public PersonType PersonType { get; set; }

        public virtual ICollection<BorrowingRecord>? BorrowingRecords { get; set; } = new ObservableCollection<BorrowingRecord>();

        public bool IsBloked => BorrowingRecords.Count > 5;
    }

    public enum PersonType
    {
        personal,
        teacher,
        student
    }
}
