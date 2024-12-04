using Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.AppDbContext;

public partial class UniversidadContext : DbContext
{
    public UniversidadContext()
    {
    }

    public UniversidadContext(DbContextOptions<UniversidadContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Asignatura> Asignaturas { get; set; }

    public virtual DbSet<Calificacion> Calificacions { get; set; }

    public virtual DbSet<Cuatrimestre> Cuatrimestres { get; set; }

    public virtual DbSet<EstudianteAsignatura> EstudianteAsignaturas { get; set; }

    public virtual DbSet<Titulacion> Titulacions { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-5QQG7I2\\SQLEXPRESS;Database=universidad;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Asignatura>(entity =>
        {
            entity.HasKey(e => e.IdAsignatura).HasName("PK__asignatu__33A22F4C4B86A749");

            entity.ToTable("asignatura");

            entity.Property(e => e.IdAsignatura)
                .ValueGeneratedNever()
                .HasColumnName("id_asignatura");
            entity.Property(e => e.Codigo)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Creditos).HasColumnName("creditos");
            entity.Property(e => e.IdTitulacion).HasColumnName("id_titulacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Semestre).HasColumnName("semestre");

            entity.HasOne(d => d.IdTitulacionNavigation).WithMany(p => p.Asignaturas)
                .HasForeignKey(d => d.IdTitulacion)
                .HasConstraintName("FK__asignatur__id_ti__4BAC3F29");
        });

        modelBuilder.Entity<Calificacion>(entity =>
        {
            entity.HasKey(e => e.IdCalificacion).HasName("PK__califica__38CEF35C145FE427");

            entity.ToTable("calificacion");

            entity.Property(e => e.IdCalificacion)
                .ValueGeneratedNever()
                .HasColumnName("id_calificacion");
            entity.Property(e => e.Asistencia)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("asistencia");
            entity.Property(e => e.ExamenFinal)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("examen_final");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnName("fecha_registro");
            entity.Property(e => e.IdAsignatura).HasColumnName("id_asignatura");
            entity.Property(e => e.IdCuatrimestre).HasColumnName("id_cuatrimestre");
            entity.Property(e => e.IdEstudiante).HasColumnName("id_estudiante");
            entity.Property(e => e.PrimerParcial)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("primer_parcial");
            entity.Property(e => e.SegundoParcial)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("segundo_parcial");

            entity.HasOne(d => d.IdAsignaturaNavigation).WithMany(p => p.Calificacions)
                .HasForeignKey(d => d.IdAsignatura)
                .HasConstraintName("FK__calificac__id_as__5EBF139D");

            entity.HasOne(d => d.IdCuatrimestreNavigation).WithMany(p => p.Calificacions)
                .HasForeignKey(d => d.IdCuatrimestre)
                .HasConstraintName("FK__calificac__id_cu__5FB337D6");

            entity.HasOne(d => d.IdEstudianteNavigation).WithMany(p => p.Calificacions)
                .HasForeignKey(d => d.IdEstudiante)
                .HasConstraintName("FK__calificac__id_es__5DCAEF64");
        });

        modelBuilder.Entity<Cuatrimestre>(entity =>
        {
            entity.HasKey(e => e.IdCuatrimestre).HasName("PK__cuatrime__CA11FC7C7516E500");

            entity.ToTable("cuatrimestre");

            entity.Property(e => e.IdCuatrimestre)
                .ValueGeneratedNever()
                .HasColumnName("id_cuatrimestre");
            entity.Property(e => e.Codigo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("codigo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<EstudianteAsignatura>(entity =>
        {
            entity.HasKey(e => new { e.IdEstudiante, e.IdAsignatura, e.IdCuatrimestre }).HasName("PK__estudian__4E424534890CF4B7");

            entity.ToTable("estudiante_asignatura");

            entity.Property(e => e.IdEstudiante).HasColumnName("id_estudiante");
            entity.Property(e => e.IdAsignatura).HasColumnName("id_asignatura");
            entity.Property(e => e.IdCuatrimestre).HasColumnName("id_cuatrimestre");
            entity.Property(e => e.FechaInscripcion).HasColumnName("fecha_inscripcion");

            entity.HasOne(d => d.IdAsignaturaNavigation).WithMany(p => p.EstudianteAsignaturas)
                .HasForeignKey(d => d.IdAsignatura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__estudiant__id_as__59063A47");

            entity.HasOne(d => d.IdCuatrimestreNavigation).WithMany(p => p.EstudianteAsignaturas)
                .HasForeignKey(d => d.IdCuatrimestre)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__estudiant__id_cu__59FA5E80");

            entity.HasOne(d => d.IdEstudianteNavigation).WithMany(p => p.EstudianteAsignaturas)
                .HasForeignKey(d => d.IdEstudiante)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__estudiant__id_es__5812160E");
        });

        modelBuilder.Entity<Titulacion>(entity =>
        {
            entity.HasKey(e => e.IdTitulacion).HasName("PK__titulaci__61BFC9E4FE99358A");

            entity.ToTable("titulacion");

            entity.Property(e => e.IdTitulacion)
                .ValueGeneratedNever()
                .HasColumnName("id_titulacion");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.Duracion).HasColumnName("duracion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__usuario__4E3E04AD7E198C90");

            entity.ToTable("usuario");

            entity.HasIndex(e => e.Email, "UQ__usuario__AB6E616480856D4D").IsUnique();

            entity.Property(e => e.IdUsuario)
                .ValueGeneratedNever()
                .HasColumnName("id_usuario");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellidos");
            entity.Property(e => e.Departamento)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("departamento");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.TipoUsuario)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo_usuario");

            entity.HasMany(d => d.IdAsignaturas).WithMany(p => p.IdProfesors)
                .UsingEntity<Dictionary<string, object>>(
                    "ProfesorAsignatura",
                    r => r.HasOne<Asignatura>().WithMany()
                        .HasForeignKey("IdAsignatura")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__profesor___id_as__5535A963"),
                    l => l.HasOne<Usuario>().WithMany()
                        .HasForeignKey("IdProfesor")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__profesor___id_pr__5441852A"),
                    j =>
                    {
                        j.HasKey("IdProfesor", "IdAsignatura").HasName("PK__profesor__C6A4F4E396E66D6C");
                        j.ToTable("profesor_asignatura");
                        j.IndexerProperty<int>("IdProfesor").HasColumnName("id_profesor");
                        j.IndexerProperty<int>("IdAsignatura").HasColumnName("id_asignatura");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
