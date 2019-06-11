﻿// <auto-generated />
using System;
using HospitalisOOAD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HospitalisOOAD.Migrations
{
    [DbContext(typeof(HospitalisContext))]
    [Migration("20190609122514_migration")]
    partial class migration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HospitalisOOAD.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("AdminId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("HospitalisOOAD.Models.Anketa", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("konacnaOcjena");

                    b.HasKey("ID");

                    b.ToTable("Anketa");
                });

            modelBuilder.Entity("HospitalisOOAD.Models.Doktor", b =>
                {
                    b.Property<int>("DoktorId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KorisnikId");

                    b.Property<int>("OdjelId");

                    b.Property<string>("userId");

                    b.HasKey("DoktorId");

                    b.HasIndex("OdjelId");

                    b.ToTable("Doktor");
                });

            modelBuilder.Entity("HospitalisOOAD.Models.Dokumentacija", b =>
                {
                    b.Property<int>("DokumentacijaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DoktorId");

                    b.Property<int>("PacijentId");

                    b.Property<int>("PregledId");

                    b.Property<DateTime>("datumIzdavanja");

                    b.HasKey("DokumentacijaId");

                    b.HasIndex("PregledId");

                    b.ToTable("Dokumentacija");
                });

            modelBuilder.Entity("HospitalisOOAD.Models.InfoAplikacije", b =>
                {
                    b.Property<int>("InfoAplikacijeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tekst");

                    b.HasKey("InfoAplikacijeId");

                    b.ToTable("InfoAplikacije");
                });

            modelBuilder.Entity("HospitalisOOAD.Models.InfoBolnice", b =>
                {
                    b.Property<int>("InfoBolniceId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("InfoBolniceId");

                    b.ToTable("InfoBolnice");
                });

            modelBuilder.Entity("HospitalisOOAD.Models.Izvjestaj", b =>
                {
                    b.Property<int>("IzvjestajId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DokumentacijaId");

                    b.Property<string>("rezultatPregleda");

                    b.HasKey("IzvjestajId");

                    b.ToTable("Izvjestaj");
                });

            modelBuilder.Entity("HospitalisOOAD.Models.Korisnik", b =>
                {
                    b.Property<int>("KorisnikId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email");

                    b.Property<string>("ime");

                    b.Property<string>("kontaktTelefon");

                    b.Property<string>("passwordHash");

                    b.Property<string>("prezime");

                    b.Property<string>("spol");

                    b.Property<string>("username");

                    b.HasKey("KorisnikId");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("HospitalisOOAD.Models.Obavjestenje", b =>
                {
                    b.Property<int>("ObavjestenjeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("tekst");

                    b.Property<DateTime>("vrijemeObjave");

                    b.HasKey("ObavjestenjeId");

                    b.ToTable("Obavjestenje");
                });

            modelBuilder.Entity("HospitalisOOAD.Models.Odjel", b =>
                {
                    b.Property<int>("OdjelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InfoBolniceId");

                    b.Property<string>("naziv");

                    b.HasKey("OdjelId");

                    b.HasIndex("InfoBolniceId");

                    b.ToTable("Odjel");
                });

            modelBuilder.Entity("HospitalisOOAD.Models.Pacijent", b =>
                {
                    b.Property<int>("PacijentId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KorisnikId");

                    b.Property<string>("adresaPrebivalista");

                    b.Property<DateTime>("datumRodjenja");

                    b.Property<string>("drzavaRodjenja");

                    b.Property<string>("gradRodjenja");

                    b.Property<string>("jmbg");

                    b.HasKey("PacijentId");

                    b.ToTable("Pacijent");
                });

            modelBuilder.Entity("HospitalisOOAD.Models.Pregled", b =>
                {
                    b.Property<int>("PregledId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DoktorId");

                    b.Property<int>("KorisnikId");

                    b.Property<int>("PacijentId");

                    b.Property<DateTime>("termin");

                    b.HasKey("PregledId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Pregled");
                });

            modelBuilder.Entity("HospitalisOOAD.Models.Recept", b =>
                {
                    b.Property<int>("ReceptId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DokumentacijaId");

                    b.Property<string>("nazivLijeka");

                    b.HasKey("ReceptId");

                    b.ToTable("Recept");
                });

            modelBuilder.Entity("HospitalisOOAD.Models.Uputnica", b =>
                {
                    b.Property<int>("UputnicaId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DokumentacijaId");

                    b.Property<string>("odrediste");

                    b.Property<string>("svrha");

                    b.HasKey("UputnicaId");

                    b.ToTable("Uputnica");
                });

            modelBuilder.Entity("HospitalisOOAD.Models.Doktor", b =>
                {
                    b.HasOne("HospitalisOOAD.Models.Odjel", "Odjel")
                        .WithMany()
                        .HasForeignKey("OdjelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HospitalisOOAD.Models.Dokumentacija", b =>
                {
                    b.HasOne("HospitalisOOAD.Models.Pregled", "Pregled")
                        .WithMany()
                        .HasForeignKey("PregledId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HospitalisOOAD.Models.Odjel", b =>
                {
                    b.HasOne("HospitalisOOAD.Models.InfoBolnice", "InfoBolnice")
                        .WithMany()
                        .HasForeignKey("InfoBolniceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("HospitalisOOAD.Models.Pregled", b =>
                {
                    b.HasOne("HospitalisOOAD.Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
