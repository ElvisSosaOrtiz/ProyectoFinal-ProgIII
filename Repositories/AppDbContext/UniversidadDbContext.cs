using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repositories.AppDbContext;

public partial class UniversidadDbContext : DbContext
{
    public UniversidadDbContext()
    {
    }

    public UniversidadDbContext(DbContextOptions<UniversidadDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AreaConocimiento> AreaConocimientos { get; set; }

    public virtual DbSet<Asignatura> Asignaturas { get; set; }

    public virtual DbSet<Estudiante> Estudiantes { get; set; }

    public virtual DbSet<EstudianteAsignatura> EstudianteAsignaturas { get; set; }

    public virtual DbSet<Profesor> Profesors { get; set; }

    public virtual DbSet<ProfesorAsignatura> ProfesorAsignaturas { get; set; }

    public virtual DbSet<Titulacion> Titulacions { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AreaConocimiento>(entity =>
        {
            entity.HasKey(e => e.AreaConocimientoId).HasName("PK__AreaCono__FAEC1FDD2F924454");

            entity.ToTable("AreaConocimiento");

            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Titulacion).WithMany(p => p.AreaConocimientos)
                .HasForeignKey(d => d.TitulacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AreaConoc__Titul__4BAC3F29");
        });

        modelBuilder.Entity<Asignatura>(entity =>
        {
            entity.HasKey(e => e.AsignaturaId).HasName("PK__Asignatu__EB67EDBE60B0B71C");

            entity.ToTable("Asignatura");

            entity.Property(e => e.Codigo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.DiaSemana1)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.DiaSemana2)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Titulacion).WithMany(p => p.Asignaturas)
                .HasForeignKey(d => d.TitulacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Asignatur__Titul__534D60F1");
        });

        modelBuilder.Entity<Estudiante>(entity =>
        {
            entity.HasKey(e => e.EstudianteId).HasName("PK__Estudian__6F7682D87CE1BD28");

            entity.ToTable("Estudiante");

            entity.HasIndex(e => e.Email, "UQ__Estudian__A9D1053466AF1D79").IsUnique();

            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Titulacion).WithMany(p => p.Estudiantes)
                .HasForeignKey(d => d.TitulacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Estudiant__Titul__4F7CD00D");
        });

        modelBuilder.Entity<EstudianteAsignatura>(entity =>
        {
            entity.HasKey(e => e.EstudianteAsignaturaId).HasName("PK__Estudian__D44836A65179D98B");

            entity.ToTable("EstudianteAsignatura");

            entity.Property(e => e.Calificacion).HasColumnType("decimal(4, 2)");

            entity.HasOne(d => d.Asignatura).WithMany(p => p.EstudianteAsignaturas)
                .HasForeignKey(d => d.AsignaturaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Estudiant__Asign__5CD6CB2B");

            entity.HasOne(d => d.Estudiante).WithMany(p => p.EstudianteAsignaturas)
                .HasForeignKey(d => d.EstudianteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Estudiant__Estud__5DCAEF64");
        });

        modelBuilder.Entity<Profesor>(entity =>
        {
            entity.HasKey(e => e.ProfesorId).HasName("PK__Profesor__4DF3F0C8C6D8C3D7");

            entity.ToTable("Profesor");

            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Titulacion).WithMany(p => p.Profesors)
                .HasForeignKey(d => d.TitulacionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Profesor__Titula__5629CD9C");
        });

        modelBuilder.Entity<ProfesorAsignatura>(entity =>
        {
            entity.HasKey(e => e.ProfesorAsignaturaId).HasName("PK__Profesor__0C46F5AF3C66A5BD");

            entity.ToTable("ProfesorAsignatura");

            entity.HasOne(d => d.Asignatura).WithMany(p => p.ProfesorAsignaturas)
                .HasForeignKey(d => d.AsignaturaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ProfesorA__Asign__59FA5E80");

            entity.HasOne(d => d.Profesor).WithMany(p => p.ProfesorAsignaturas)
                .HasForeignKey(d => d.ProfesorId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ProfesorA__Profe__59063A47");
        });

        modelBuilder.Entity<Titulacion>(entity =>
        {
            entity.HasKey(e => e.TitulacionId).HasName("PK__Titulaci__13593316E56D3AA8");

            entity.ToTable("Titulacion");

            entity.Property(e => e.Encargado).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
