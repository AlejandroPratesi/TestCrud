using AbmNetCore5.Models;
using AbmNetCore5.Models;
using Microsoft.EntityFrameworkCore;

namespace AbmNetCore5.Data
{
    public class AplicationDbContext:DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }

        //public DbSet<Models.TUser> TUser { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            //modelBuilder.Entity<Models.TGenero>(entity =>
            //{
            //    entity.HasKey(e => e.CodGenero)
            //        .HasName("PK__tGenero__0DACB9D59928A4C4");

            //    entity.ToTable("tGenero");

            //    entity.Property(e => e.CodGenero).HasColumnName("cod_genero");

            //    entity.Property(e => e.TxtDesc)
            //        .HasMaxLength(500)
            //        .IsUnicode(false)
            //        .HasColumnName("txt_desc");
            //});

            //modelBuilder.Entity<Models.TGeneroPelicula>(entity =>
            //{
            //    entity.HasKey(e => new { e.CodPelicula, e.CodGenero })
            //        .HasName("PK__tGeneroP__6285A595402D57ED");

            //    entity.ToTable("tGeneroPelicula");

            //    entity.Property(e => e.CodPelicula).HasColumnName("cod_pelicula");

            //    entity.Property(e => e.CodGenero).HasColumnName("cod_genero");

            //    entity.HasOne(d => d.CodGeneroNavigation)
            //        .WithMany(p => p.TGeneroPeliculas)
            //        .HasForeignKey(d => d.CodGenero)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("fk_pelicula_genero");

            //    entity.HasOne(d => d.CodPeliculaNavigation)
            //        .WithMany(p => p.TGeneroPeliculas)
            //        .HasForeignKey(d => d.CodPelicula)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("fk_genero_pelicula");
            //});

            //modelBuilder.Entity<Models.TPelicula>(entity =>
            //{
            //    entity.HasKey(e => e.CodPelicula)
            //        .HasName("PK__tPelicul__225F6E08FD22B9A3");

            //    entity.ToTable("tPelicula");

            //    entity.Property(e => e.CodPelicula).HasColumnName("cod_pelicula");

            //    entity.Property(e => e.CantDisponiblesAlquiler).HasColumnName("cant_disponibles_alquiler");

            //    entity.Property(e => e.CantDisponiblesVenta).HasColumnName("cant_disponibles_venta");

            //    entity.Property(e => e.PrecioAlquiler)
            //        .HasColumnType("numeric(18, 2)")
            //        .HasColumnName("precio_alquiler");

            //    entity.Property(e => e.PrecioVenta)
            //        .HasColumnType("numeric(18, 2)")
            //        .HasColumnName("precio_venta");

            //    entity.Property(e => e.TxtDesc)
            //        .HasMaxLength(500)
            //        .IsUnicode(false)
            //        .HasColumnName("txt_desc");
            //});

            modelBuilder.Entity<Models.TRol>(entity =>
            {
                entity.HasKey(e => e.CodRol)
                    .HasName("PK__tRol__F13B1211935B2147");

                entity.ToTable("tRol");

                entity.Property(e => e.CodRol).HasColumnName("cod_rol");

                entity.Property(e => e.SnActivo).HasColumnName("sn_activo");

                entity.Property(e => e.TxtDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("txt_desc");
            });

            modelBuilder.Entity<Models.TUser>(entity =>
            {
                entity.HasKey(e => e.CodUsuario)
                    .HasName("PK__tUsers__EA3C9B1AF80E1582");

                entity.ToTable("tUsers");

                entity.Property(e => e.CodUsuario).HasColumnName("cod_usuario");

                entity.Property(e => e.CodRol).HasColumnName("cod_rol");

                entity.Property(e => e.NroDoc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nro_doc");

                entity.Property(e => e.SnActivo).HasColumnName("sn_activo");

                entity.Property(e => e.TxtApellido)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("txt_apellido");

                entity.Property(e => e.TxtNombre)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("txt_nombre");

                entity.Property(e => e.TxtPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("txt_password");

                entity.Property(e => e.TxtUser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("txt_user");

                //entity.HasOne(d => d.CodRolNavigation)
                //    .WithMany(p => p.TUsers)
                //    .HasForeignKey(d => d.CodRol)
                //    .HasConstraintName("fk_user_rol");
            });

           // OnModelCreatingPartial(modelBuilder);
        }

       // partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
