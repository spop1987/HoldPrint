﻿// <auto-generated />
using HoldPrint_WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HoldPrint_WebAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("HoldPrint_WebAPI.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Cpf")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cpf = "111.222.333-45",
                            Name = "nome1",
                            Surname = "sobrenome1"
                        },
                        new
                        {
                            Id = 2,
                            Cpf = "999.888.777-45",
                            Name = "nome2",
                            Surname = "sobrenome2"
                        },
                        new
                        {
                            Id = 3,
                            Cpf = "652.563.452-87",
                            Name = "nome3",
                            Surname = "sobrenome3"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}