using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Trabalho1DevWebNet.Data;

#nullable disable

namespace Trabalho1DevWebNet.Migrations;

[DbContext(typeof(AppDbContext))]
partial class AppDbContextModelSnapshot : ModelSnapshot
{
    protected override void BuildModel(ModelBuilder modelBuilder)
    {
        modelBuilder.HasAnnotation("ProductVersion", "10.0.0");

        modelBuilder.Entity("Trabalho1DevWebNet.Models.Paciente", b =>
        {
            b.Property<int>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("integer")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            b.Property<string>("Cpf").IsRequired().HasMaxLength(14).HasColumnType("character varying(14)");
            b.Property<DateTime>("DataNascimento").HasColumnType("timestamp with time zone");
            b.Property<string>("Endereco").IsRequired().HasMaxLength(200).HasColumnType("character varying(200)");
            b.Property<string>("Nome").IsRequired().HasMaxLength(100).HasColumnType("character varying(100)");
            b.Property<string>("Telefone").IsRequired().HasMaxLength(20).HasColumnType("character varying(20)");

            b.HasKey("Id");
            b.ToTable("Pacientes");
        });
    }
}
