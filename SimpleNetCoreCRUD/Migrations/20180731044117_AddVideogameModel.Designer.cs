﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SimpleNetCoreCRUD.Models;
using System;

namespace SimpleNetCoreCRUD.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180731044117_AddVideogameModel")]
    partial class AddVideogameModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SimpleNetCoreCRUD.Models.Videogame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Genre");

                    b.Property<string>("Publisher");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Videogames");
                });
#pragma warning restore 612, 618
        }
    }
}
