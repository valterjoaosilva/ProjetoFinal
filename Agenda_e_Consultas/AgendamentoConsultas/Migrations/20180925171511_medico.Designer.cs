﻿// <auto-generated />
using AgendamentoConsultas.DAO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgendamentoConsultas.Migrations
{
    [DbContext(typeof(ClinicaContext))]
    [Migration("20180925171511_medico")]
    partial class medico
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.2-rtm-30932")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AgendamentoConsultas.Models.Convenio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConvenioNome");

                    b.HasKey("Id");

                    b.ToTable("Convenios");
                });

            modelBuilder.Entity("AgendamentoConsultas.Models.Especialidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescricaoEspecialidade");

                    b.Property<string>("EspecialidadeNome");

                    b.HasKey("Id");

                    b.ToTable("Especialidades");
                });

            modelBuilder.Entity("AgendamentoConsultas.Models.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<int>("EspecialidadeId");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("EspecialidadeId");

                    b.ToTable("Medicos");
                });

            modelBuilder.Entity("AgendamentoConsultas.Models.Pacientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bairro");

                    b.Property<string>("Celular")
                        .HasMaxLength(13);

                    b.Property<string>("Cep")
                        .HasMaxLength(8);

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("ConfirmarSenha");

                    b.Property<int>("ConvenioId");

                    b.Property<string>("Cpf")
                        .HasMaxLength(11);

                    b.Property<string>("DataNascimento");

                    b.Property<string>("Email");

                    b.Property<string>("Endereco");

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.Property<string>("Sexo");

                    b.Property<string>("Telefone")
                        .HasMaxLength(12);

                    b.Property<string>("Uf");

                    b.HasKey("Id");

                    b.HasIndex("ConvenioId");

                    b.ToTable("Pacientes");
                });

            modelBuilder.Entity("AgendamentoConsultas.Models.Medico", b =>
                {
                    b.HasOne("AgendamentoConsultas.Models.Especialidade", "Especialidade")
                        .WithMany()
                        .HasForeignKey("EspecialidadeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AgendamentoConsultas.Models.Pacientes", b =>
                {
                    b.HasOne("AgendamentoConsultas.Models.Convenio", "Convenio")
                        .WithMany()
                        .HasForeignKey("ConvenioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
