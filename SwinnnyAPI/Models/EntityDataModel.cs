namespace SwinnnyAPI
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityDataModel : DbContext
    {
        public EntityDataModel()
            : base("name=Azure")
        {
        }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .Property(e => e.AuthorId)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .Property(e => e.TFN)
                .IsUnicode(false);

            modelBuilder.Entity<Author>()
                .HasMany(e => e.Books)
                .WithRequired(e => e.Author)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.ISBN)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Book>()
                .Property(e => e.AuthorId)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
