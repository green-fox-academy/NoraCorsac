﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SpringBoot.Entities;
using System;

namespace SpringBoot.Migrations
{
    [DbContext(typeof(CarContext))]
    [Migration("20180130051348_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SpringBoot.Models.LicencePlate", b =>
                {
                    b.Property<string>("Plate")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CarBrand");

                    b.Property<string>("CarModel");

                    b.Property<string>("Color");

                    b.Property<string>("Year");

                    b.HasKey("Plate");

                    b.ToTable("LicencePlates");
                });
#pragma warning restore 612, 618
        }
    }
}
