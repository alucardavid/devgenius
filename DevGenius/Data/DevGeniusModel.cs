namespace DevGenius.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DevGeniusModel : DbContext
    {
        public DevGeniusModel()
            : base("name=DevGeniusModel")
        {
        }

        public virtual DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contato>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Contato>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Contato>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<Contato>()
                .Property(e => e.Mensagem)
                .IsUnicode(false);
        }
    }
}
