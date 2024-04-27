﻿// <auto-generated />
using ADSProyect.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ADSProyect.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240427181354_Profesores")]
    partial class Profesores
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ADSProyect.Models.Carrera", b =>
                {
                    b.Property<int>("IdCarrera")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCarrera"));

                    b.Property<string>("CodigoCarrera")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("NombreCarrera")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("IdCarrera");

                    b.ToTable("Carrrera");
                });

            modelBuilder.Entity("ADSProyect.Models.Estudiante", b =>
                {
                    b.Property<int>("IdEstudiante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdEstudiante"));

                    b.Property<string>("ApellidosEstudiante")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CodigoEstudiante")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CorreoEstudiante")
                        .IsRequired()
                        .HasMaxLength(254)
                        .HasColumnType("nvarchar(254)");

                    b.Property<string>("NombresEstudiante")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdEstudiante");

                    b.ToTable("Estudiante");
                });

            modelBuilder.Entity("ADSProyect.Models.Grupo", b =>
                {
                    b.Property<int>("IdGrupo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdGrupo"));

                    b.Property<int>("Anio")
                        .HasColumnType("int");

                    b.Property<int>("Ciclo")
                        .HasColumnType("int");

                    b.Property<int>("IdCarrera")
                        .HasColumnType("int");

                    b.Property<int>("IdMateria")
                        .HasColumnType("int");

                    b.Property<int>("IdProfesor")
                        .HasColumnType("int");

                    b.HasKey("IdGrupo");

                    b.ToTable("Grupo");
                });

            modelBuilder.Entity("ADSProyect.Models.Materia", b =>
                {
                    b.Property<int>("IdMateria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMateria"));

                    b.Property<string>("NombreMateria")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("IdMateria");

                    b.ToTable("Materia");
                });

            modelBuilder.Entity("ADSProyect.Models.Profesor", b =>
                {
                    b.Property<int>("IdProfesor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProfesor"));

                    b.Property<string>("ApellidosProfesor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(254)
                        .HasColumnType("nvarchar(254)");

                    b.Property<string>("NombresProfesor")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdProfesor");

                    b.ToTable("Profesor");
                });
#pragma warning restore 612, 618
        }
    }
}
