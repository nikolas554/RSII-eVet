using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace eVet.WebAPI.Database
{
    public partial class VeterinarskaStanicaContext : DbContext
    {
        public VeterinarskaStanicaContext()
        {
        }

        public VeterinarskaStanicaContext(DbContextOptions<VeterinarskaStanicaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dijagnoza> Dijagnozas { get; set; }
        public virtual DbSet<KorisniciUloge> KorisniciUloges { get; set; }
        public virtual DbSet<Korisnik> Korisniks { get; set; }
        public virtual DbSet<Lijekovi> Lijekovis { get; set; }
        public virtual DbSet<LijekoviPregled> LijekoviPregleds { get; set; }
        public virtual DbSet<Ljubimac> Ljubimacs { get; set; }
        public virtual DbSet<Pregled> Pregleds { get; set; }
        public virtual DbSet<Racun> Racuns { get; set; }
        public virtual DbSet<Rezervacije> Rezervacijes { get; set; }
        public virtual DbSet<Termini> Terminis { get; set; }
        public virtual DbSet<Uloge> Uloges { get; set; }
        public virtual DbSet<Ustanovljena> Ustanovljenas { get; set; }
        public virtual DbSet<VrstaUsluge> VrstaUsluges { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=.;Database=VeterinarskaStanica;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Dijagnoza>(entity =>
            {
                entity.ToTable("Dijagnoza");

                entity.Property(e => e.DijagnozaId).HasColumnName("DijagnozaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            modelBuilder.Entity<KorisniciUloge>(entity =>
            {
                entity.HasKey(e => e.KorisnikUlogaId)
                    .HasName("PK_KorisnikUloga_Prima");

                entity.ToTable("KorisniciUloge");

                entity.Property(e => e.KorisnikUlogaId).HasColumnName("KorisnikUlogaID");

                entity.Property(e => e.DatumIzmjene).HasColumnType("datetime");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisniciUloges)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KorisnikID_Key09");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisniciUloges)
                    .HasForeignKey(d => d.UlogaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UlogaID_Key09");
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.ToTable("Korisnik");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Adresa).HasMaxLength(80);

                entity.Property(e => e.DatumRodjenja).HasColumnType("date");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mobilni).HasMaxLength(15);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Lijekovi>(entity =>
            {
                entity.HasKey(e => e.LijekId)
                    .HasName("LijekID_PK");

                entity.ToTable("Lijekovi");

                entity.Property(e => e.LijekId).HasColumnName("LijekID");

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(80);
            });

            modelBuilder.Entity<LijekoviPregled>(entity =>
            {
                entity.ToTable("LijekoviPregled");

                entity.Property(e => e.LijekoviPregledId).HasColumnName("LijekoviPregledID");

                entity.Property(e => e.LijekId).HasColumnName("LijekID");

                entity.Property(e => e.PregledId).HasColumnName("PregledID");

                entity.HasOne(d => d.Lijek)
                    .WithMany(p => p.LijekoviPregleds)
                    .HasForeignKey(d => d.LijekId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LijekID_FK1");

                entity.HasOne(d => d.Pregled)
                    .WithMany(p => p.LijekoviPregleds)
                    .HasForeignKey(d => d.PregledId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PregledID_FK1");
            });

            modelBuilder.Entity<Ljubimac>(entity =>
            {
                entity.ToTable("Ljubimac");

                entity.Property(e => e.LjubimacId).HasColumnName("LjubimacID");

                entity.Property(e => e.Boja).HasMaxLength(50);

                entity.Property(e => e.DatumRodjenja).HasColumnType("date");

                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.Mikrocip).HasMaxLength(15);

                entity.Property(e => e.Rasa)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Ljubimacs)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ljubimac__Korisn__0B91BA14");
            });

            modelBuilder.Entity<Pregled>(entity =>
            {
                entity.ToTable("Pregled");

                entity.Property(e => e.PregledId).HasColumnName("PregledID");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.KorisnikId).HasColumnName("KorisnikID");

                entity.Property(e => e.LjubimacId).HasColumnName("LjubimacID");

                entity.Property(e => e.VrstaUslugeId).HasColumnName("VrstaUslugeID");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Pregleds)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Foreign_Key5");

                entity.HasOne(d => d.Ljubimac)
                    .WithMany(p => p.Pregleds)
                    .HasForeignKey(d => d.LjubimacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Foreign_Key6");

                entity.HasOne(d => d.VrstaUsluge)
                    .WithMany(p => p.Pregleds)
                    .HasForeignKey(d => d.VrstaUslugeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Foreign_Key7");
            });

            modelBuilder.Entity<Racun>(entity =>
            {
                entity.ToTable("Racun");

                entity.Property(e => e.RacunId).HasColumnName("RacunID");

                entity.Property(e => e.DatumIzdavanja).HasColumnType("datetime");

                entity.Property(e => e.Iznos).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Pregled)
                    .WithMany(p => p.Racuns)
                    .HasForeignKey(d => d.PregledId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Racun__PregledId__2739D489");
            });

            modelBuilder.Entity<Rezervacije>(entity =>
            {
                entity.HasKey(e => e.RezervacijaId)
                    .HasName("PK_RezervacijaID_Prima");

                entity.ToTable("Rezervacije");

                entity.Property(e => e.RezervacijaId).HasColumnName("RezervacijaID");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.LjubimacId).HasColumnName("LjubimacID");

                entity.Property(e => e.TerminId).HasColumnName("TerminID");

                entity.Property(e => e.VrstaUslugeId).HasColumnName("VrstaUslugeID");

                entity.HasOne(d => d.Ljubimac)
                    .WithMany(p => p.Rezervacijes)
                    .HasForeignKey(d => d.LjubimacId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LjubimacID_Key091");

                entity.HasOne(d => d.Termin)
                    .WithMany(p => p.Rezervacijes)
                    .HasForeignKey(d => d.TerminId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TerminID_Key09");

                entity.HasOne(d => d.VrstaUsluge)
                    .WithMany(p => p.Rezervacijes)
                    .HasForeignKey(d => d.VrstaUslugeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VrstaUslugeID_Key09");
            });

            modelBuilder.Entity<Termini>(entity =>
            {
                entity.HasKey(e => e.TerminId)
                    .HasName("PK_TerminID_Prima");

                entity.ToTable("Termini");

                entity.Property(e => e.TerminId).HasColumnName("TerminID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Uloge>(entity =>
            {
                entity.HasKey(e => e.UlogaId)
                    .HasName("PK_UlogaID_Prima");

                entity.ToTable("Uloge");

                entity.Property(e => e.UlogaId).HasColumnName("UlogaID");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis).HasMaxLength(200);
            });

            modelBuilder.Entity<Ustanovljena>(entity =>
            {
                entity.HasKey(e => new { e.PregledId, e.DijagnozaId })
                    .HasName("PK_ustanovljena_Pr");

                entity.ToTable("ustanovljena");

                entity.Property(e => e.PregledId).HasColumnName("PregledID");

                entity.Property(e => e.DijagnozaId).HasColumnName("DijagnozaID");

                entity.HasOne(d => d.Dijagnoza)
                    .WithMany(p => p.Ustanovljenas)
                    .HasForeignKey(d => d.DijagnozaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Foreign_Key10");

                entity.HasOne(d => d.Pregled)
                    .WithMany(p => p.Ustanovljenas)
                    .HasForeignKey(d => d.PregledId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Foreign_Key9");
            });

            modelBuilder.Entity<VrstaUsluge>(entity =>
            {
                entity.ToTable("VrstaUsluge");

                entity.Property(e => e.VrstaUslugeId).HasColumnName("VrstaUslugeID");

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
