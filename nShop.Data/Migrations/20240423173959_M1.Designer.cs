﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using nShop.Data.Data;

#nullable disable

namespace nShop.Data.Migrations
{
    [DbContext(typeof(nShopContext))]
    [Migration("20240423173959_M1")]
    partial class M1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("nShop.Data.Data.CMS.Aktualnosc", b =>
                {
                    b.Property<int>("IdAktualnosci")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAktualnosci"));

                    b.Property<string>("LinkTytul")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Pozycja")
                        .HasColumnType("int");

                    b.Property<string>("Tresc")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Tytul")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IdAktualnosci");

                    b.ToTable("Aktualnosc");
                });

            modelBuilder.Entity("nShop.Data.Data.CMS.Strona", b =>
                {
                    b.Property<int>("IdStrony")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdStrony"));

                    b.Property<string>("LinkTytul")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Pozycja")
                        .HasColumnType("int");

                    b.Property<string>("Tresc")
                        .IsRequired()
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<string>("Tytul")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("IdStrony");

                    b.ToTable("Strona");
                });

            modelBuilder.Entity("nShop.Data.Data.Sklep.ElementZamowienia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("CenaJednostkowa")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Ilosc")
                        .HasColumnType("int");

                    b.Property<int>("ProduktId")
                        .HasColumnType("int");

                    b.Property<int>("ZamowienieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProduktId");

                    b.HasIndex("ZamowienieId");

                    b.ToTable("ElementZamowienia");
                });

            modelBuilder.Entity("nShop.Data.Data.Sklep.Kategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kategoria");
                });

            modelBuilder.Entity("nShop.Data.Data.Sklep.Producent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SciezkaLogo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Producent");
                });

            modelBuilder.Entity("nShop.Data.Data.Sklep.Produkt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Cena")
                        .HasColumnType("money");

                    b.Property<int>("IloscNaMagazynie")
                        .HasColumnType("int");

                    b.Property<int>("KategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProducentId")
                        .HasColumnType("int");

                    b.Property<string>("SciezkaZdjecia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KategoriaId");

                    b.HasIndex("ProducentId");

                    b.ToTable("Produkt");
                });

            modelBuilder.Entity("nShop.Data.Data.Sklep.Recenzja", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Ocena")
                        .HasColumnType("int");

                    b.Property<int>("ProduktId")
                        .HasColumnType("int");

                    b.Property<string>("Tekst")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UzytkownikId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProduktId");

                    b.HasIndex("UzytkownikId");

                    b.ToTable("Recenzja");
                });

            modelBuilder.Entity("nShop.Data.Data.Sklep.Rola", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rola");
                });

            modelBuilder.Entity("nShop.Data.Data.Sklep.StatusZamowienia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StatusZamowienia");
                });

            modelBuilder.Entity("nShop.Data.Data.Sklep.Uzytkownik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Haslo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RolaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RolaId");

                    b.ToTable("Uzytkownik");
                });

            modelBuilder.Entity("nShop.Data.Data.Sklep.Zamowienie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataZamowienia")
                        .HasColumnType("datetime2");

                    b.Property<int>("StatusZamowieniaId")
                        .HasColumnType("int");

                    b.Property<decimal>("Suma")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UzytkownikId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StatusZamowieniaId");

                    b.HasIndex("UzytkownikId");

                    b.ToTable("Zamowienie");
                });

            modelBuilder.Entity("nShop.Data.Data.Sklep.ElementZamowienia", b =>
                {
                    b.HasOne("nShop.Data.Data.Sklep.Produkt", "Produkt")
                        .WithMany()
                        .HasForeignKey("ProduktId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("nShop.Data.Data.Sklep.Zamowienie", "Zamowienie")
                        .WithMany("ElementyZamowienia")
                        .HasForeignKey("ZamowienieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produkt");

                    b.Navigation("Zamowienie");
                });

            modelBuilder.Entity("nShop.Data.Data.Sklep.Produkt", b =>
                {
                    b.HasOne("nShop.Data.Data.Sklep.Kategoria", "Kategoria")
                        .WithMany("Produkty")
                        .HasForeignKey("KategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("nShop.Data.Data.Sklep.Producent", "Producent")
                        .WithMany("Produkty")
                        .HasForeignKey("ProducentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategoria");

                    b.Navigation("Producent");
                });

            modelBuilder.Entity("nShop.Data.Data.Sklep.Recenzja", b =>
                {
                    b.HasOne("nShop.Data.Data.Sklep.Produkt", "Produkt")
                        .WithMany("Recenzje")
                        .HasForeignKey("ProduktId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("nShop.Data.Data.Sklep.Uzytkownik", "Uzytkownik")
                        .WithMany()
                        .HasForeignKey("UzytkownikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produkt");

                    b.Navigation("Uzytkownik");
                });

            modelBuilder.Entity("nShop.Data.Data.Sklep.Uzytkownik", b =>
                {
                    b.HasOne("nShop.Data.Data.Sklep.Rola", "Rola")
                        .WithMany("Uzytkownicy")
                        .HasForeignKey("RolaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rola");
                });

            modelBuilder.Entity("nShop.Data.Data.Sklep.Zamowienie", b =>
                {
                    b.HasOne("nShop.Data.Data.Sklep.StatusZamowienia", "StatusZamowienia")
                        .WithMany("Zamowienia")
                        .HasForeignKey("StatusZamowieniaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("nShop.Data.Data.Sklep.Uzytkownik", "Uzytkownik")
                        .WithMany()
                        .HasForeignKey("UzytkownikId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StatusZamowienia");

                    b.Navigation("Uzytkownik");
                });

            modelBuilder.Entity("nShop.Data.Data.Sklep.Kategoria", b =>
                {
                    b.Navigation("Produkty");
                });

            modelBuilder.Entity("nShop.Data.Data.Sklep.Producent", b =>
                {
                    b.Navigation("Produkty");
                });

            modelBuilder.Entity("nShop.Data.Data.Sklep.Produkt", b =>
                {
                    b.Navigation("Recenzje");
                });

            modelBuilder.Entity("nShop.Data.Data.Sklep.Rola", b =>
                {
                    b.Navigation("Uzytkownicy");
                });

            modelBuilder.Entity("nShop.Data.Data.Sklep.StatusZamowienia", b =>
                {
                    b.Navigation("Zamowienia");
                });

            modelBuilder.Entity("nShop.Data.Data.Sklep.Zamowienie", b =>
                {
                    b.Navigation("ElementyZamowienia");
                });
#pragma warning restore 612, 618
        }
    }
}