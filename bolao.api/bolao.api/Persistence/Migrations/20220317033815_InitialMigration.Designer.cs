﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bolao.api.Data;

namespace bolao.api.Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220317033815_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.13");

            modelBuilder.Entity("bolao.api.Entities.Participant", b =>
                {
                    b.Property<int>("IdParticipant")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("IdParticipant");

                    b.ToTable("Participants");
                });
#pragma warning restore 612, 618
        }
    }
}
