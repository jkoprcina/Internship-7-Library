﻿// <auto-generated />
using System;
using InternshipLibrary.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InternshipLibrary.Data.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20190217103735_Added loan to student and IsReturned to book")]
    partial class AddedloantostudentandIsReturnedtobook
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InternshipLibrary.Data.Entities.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("InternshipLibrary.Data.Entities.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AuthorId");

                    b.Property<int>("Genre");

                    b.Property<string>("Name");

                    b.Property<int>("NumberOfBooksAvailable");

                    b.Property<int>("NumberOfBooksBorrowed");

                    b.Property<int>("PageNumber");

                    b.Property<int?>("PublisherId");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("PublisherId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("InternshipLibrary.Data.Entities.Models.Borrowing", b =>
                {
                    b.Property<int>("BorrowingId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookId");

                    b.Property<DateTime>("DateOfBorrowing");

                    b.Property<DateTime>("DateOfReturn");

                    b.Property<bool>("IsReturned");

                    b.Property<int>("StudentId");

                    b.HasKey("BorrowingId");

                    b.HasIndex("BookId");

                    b.HasIndex("StudentId");

                    b.ToTable("Borrowings");
                });

            modelBuilder.Entity("InternshipLibrary.Data.Entities.Models.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Letter")
                        .IsRequired()
                        .HasConversion(new ValueConverter<string, string>(v => default(string), v => default(string), new ConverterMappingHints(size: 1)));

                    b.Property<int>("Number");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("InternshipLibrary.Data.Entities.Models.Publisher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("InternshipLibrary.Data.Entities.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClassId");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("FirstName");

                    b.Property<int>("Gender");

                    b.Property<string>("LastName");

                    b.Property<double>("Loan");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("InternshipLibrary.Data.Entities.Models.Book", b =>
                {
                    b.HasOne("InternshipLibrary.Data.Entities.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId");

                    b.HasOne("InternshipLibrary.Data.Entities.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId");
                });

            modelBuilder.Entity("InternshipLibrary.Data.Entities.Models.Borrowing", b =>
                {
                    b.HasOne("InternshipLibrary.Data.Entities.Models.Book", "Book")
                        .WithMany("Borrowings")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InternshipLibrary.Data.Entities.Models.Student", "Student")
                        .WithMany("Borrowings")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("InternshipLibrary.Data.Entities.Models.Student", b =>
                {
                    b.HasOne("InternshipLibrary.Data.Entities.Models.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("ClassId");
                });
#pragma warning restore 612, 618
        }
    }
}
