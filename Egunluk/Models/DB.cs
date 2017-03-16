namespace Egunluk.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DB : DbContext
    {
        public DB()
            : base("name=DB")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Commentz> Commentzs { get; set; }
        public virtual DbSet<Note> Notes { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<Commentz>()
                .Property(e => e.Comment)
                .IsUnicode(false);

            modelBuilder.Entity<Note>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<Note>()
                .Property(e => e.Note1)
                .IsUnicode(false);

            modelBuilder.Entity<Note>()
                .HasMany(e => e.Commentzs)
                .WithRequired(e => e.Note)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Note>()
                .HasMany(e => e.Tags)
                .WithRequired(e => e.Note)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Note>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Notes)
                .Map(m => m.ToTable("Favorites").MapLeftKey("Nid").MapRightKey("Uid"));

            modelBuilder.Entity<Note>()
                .HasMany(e => e.Users1)
                .WithMany(e => e.Notes1)
                .Map(m => m.ToTable("Likes").MapLeftKey("Nid").MapRightKey("Uid"));

            modelBuilder.Entity<Tag>()
                .Property(e => e.Tag1)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.First_Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Last_Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasOptional(e => e.Admin)
                .WithRequired(e => e.User);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Commentzs)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasOptional(e => e.Note)
                .WithRequired(e => e.User);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Users1)
                .WithMany(e => e.Users)
                .Map(m => m.ToTable("Friends").MapLeftKey("Fid").MapRightKey("Uid"));
        }
    }
}
