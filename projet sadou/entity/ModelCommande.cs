namespace projet_sadou.entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelCommande : DbContext
    {
        public ModelCommande()
            : base("name=ModelCommande")
        {
        }

        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Commande> Commande { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>()
                .HasMany(e => e.Commande)
                .WithOptional(e => e.Article)
                .HasForeignKey(e => e.article_id);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Commande)
                .WithOptional(e => e.Client)
                .HasForeignKey(e => e.client_id);

            modelBuilder.Entity<User>()
                .Property(e => e.Login1)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password1)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Nom1)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Prenom1)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Profil1)
                .IsUnicode(false);
        }
    }
}
