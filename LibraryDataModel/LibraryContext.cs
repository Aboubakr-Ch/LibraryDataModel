using LibraryDataModel.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryDataModel
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Card> Cards { get; set; }

        public DbSet<BorrowingRecord> BorrowingRecords { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BorrowingRecord>().HasOne(o => o.Book).WithMany(o => o.BorrowingRecords).HasForeignKey(o => o.BookId);
            modelBuilder.Entity<BorrowingRecord>().HasOne(o => o.Card).WithMany(o => o.BorrowingRecords).HasForeignKey(o => o.CardId);
            modelBuilder.Entity<BorrowingRecord>().HasOne(o => o.Notification).WithMany(o => o.BorrowingRecords).HasForeignKey(o => o.NotificationId);

            modelBuilder.Entity<BorrowingRecord>().HasOne(o => o.Creator).WithMany(o => o.BorrowingRecordCreators).HasForeignKey(o => o.CreatorId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<BorrowingRecord>().HasOne(o => o.Editor).WithMany(o => o.BorrowingRecordModifiers).HasForeignKey(o => o.EditId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Card>(entity => { entity.HasIndex(o => o.Code).IsUnique(); });
            modelBuilder.Entity<Card>().HasOne(o => o.Creator).WithMany(o => o.CardCreators).HasForeignKey(o => o.CreatorId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Card>().HasOne(o => o.Editor).WithMany(o => o.CardModifiers).HasForeignKey(o => o.EditId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Book>(entity => { entity.HasIndex(o => o.ISBN).IsUnique(); });
            modelBuilder.Entity<Book>().HasOne(o => o.Creator).WithMany(o => o.BookCreators).HasForeignKey(o => o.CreatorId).OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Book>().HasOne(o => o.Editor).WithMany(o => o.BookModifiers).HasForeignKey(o => o.EditId).OnDelete(DeleteBehavior.NoAction);
        }
    }

}
