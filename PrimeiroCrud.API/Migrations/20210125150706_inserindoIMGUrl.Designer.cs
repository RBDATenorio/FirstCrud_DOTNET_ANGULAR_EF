﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrimeiroCrud.API.Data;

namespace PrimeiroCrud.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20210125150706_inserindoIMGUrl")]
    partial class inserindoIMGUrl
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("PrimeiroCrud.API.Model.Banda", b =>
                {
                    b.Property<int>("BandaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CD1");

                    b.Property<string>("CD2");

                    b.Property<string>("CD3");

                    b.Property<string>("CD4");

                    b.Property<string>("ImgUrl");

                    b.Property<string>("Nome");

                    b.HasKey("BandaId");

                    b.ToTable("Bandas");
                });
#pragma warning restore 612, 618
        }
    }
}
