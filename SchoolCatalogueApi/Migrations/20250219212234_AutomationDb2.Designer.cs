﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolCatalogueApi.Data;

#nullable disable

namespace SchoolCatalogueApi.Migrations
{
    [DbContext(typeof(SchoolCatalogueDbContext))]
    [Migration("20250219212234_AutomationDb2")]
    partial class AutomationDb2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SchoolCatalogueApi.SClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Serie")
                        .HasColumnType("nvarchar(1)");

                    b.Property<bool?>("Valid")
                        .HasColumnType("bit");

                    b.Property<int?>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SClasses");
                });

            modelBuilder.Entity("SchoolCatalogueApi.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.PrimitiveCollection<string>("Grades")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SClassId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SClassId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("SchoolCatalogueApi.Student", b =>
                {
                    b.HasOne("SchoolCatalogueApi.SClass", "SClass")
                        .WithMany("Students")
                        .HasForeignKey("SClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SClass");
                });

            modelBuilder.Entity("SchoolCatalogueApi.SClass", b =>
                {
                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
