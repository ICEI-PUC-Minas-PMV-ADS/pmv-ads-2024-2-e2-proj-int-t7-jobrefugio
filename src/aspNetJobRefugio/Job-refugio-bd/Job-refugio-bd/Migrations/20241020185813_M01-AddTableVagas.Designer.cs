﻿// <auto-generated />
using Job_refugio_bd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Job_refugio_bd.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241020185813_M01-AddTableVagas")]
    partial class M01AddTableVagas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Job_refugio_bd.Models.Empregador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cep")
                        .HasColumnType("int");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeEmpresa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Empregador");
                });

            modelBuilder.Entity("Job_refugio_bd.Models.Vaga", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DescVaga")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmpregadorId")
                        .HasColumnType("int");

                    b.Property<string>("InfoAdicional")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Local")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MetodoContratacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegimeTrabalho")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RequisitosQualificacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SobreEmpresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("VagaPCD")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("EmpregadorId");

                    b.ToTable("Vaga");
                });

            modelBuilder.Entity("Job_refugio_bd.Models.Vaga", b =>
                {
                    b.HasOne("Job_refugio_bd.Models.Empregador", "Empregador")
                        .WithMany("Vagas")
                        .HasForeignKey("EmpregadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empregador");
                });

            modelBuilder.Entity("Job_refugio_bd.Models.Empregador", b =>
                {
                    b.Navigation("Vagas");
                });
#pragma warning restore 612, 618
        }
    }
}
