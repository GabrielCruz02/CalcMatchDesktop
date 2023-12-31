﻿// <auto-generated />
using System;
using CalcMatchV2.AcessoDados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CalcMatchV2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231112180730_incluindo ferias na tabela funcionario")]
    partial class incluindoferiasnatabelafuncionario
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("CalcMatchV1.Entities.Dependente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("TEXT");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Parentesco")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("FuncionarioId");

                    b.ToTable("Dependentes");
                });

            modelBuilder.Entity("CalcMatchV1.Entities.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Ctps")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Ferias")
                        .HasColumnType("TEXT");

                    b.Property<double>("HorasTrabalhadas")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NomeSocial")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Observacoes")
                        .HasColumnType("TEXT");

                    b.Property<string>("RegistroGeral")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Situacao")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("ValorHora")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("CalcMatchV1.Entities.Dependente", b =>
                {
                    b.HasOne("CalcMatchV1.Entities.Funcionario", "Funcionario")
                        .WithMany("dependentes")
                        .HasForeignKey("FuncionarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcionario");
                });

            modelBuilder.Entity("CalcMatchV1.Entities.Funcionario", b =>
                {
                    b.Navigation("dependentes");
                });
#pragma warning restore 612, 618
        }
    }
}
