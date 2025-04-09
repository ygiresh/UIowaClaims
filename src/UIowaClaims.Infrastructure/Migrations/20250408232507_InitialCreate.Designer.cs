﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UIowaClaims.Infrastructure.Persistence;

#nullable disable

namespace UIowaClaims.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250408232507_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.15");

            modelBuilder.Entity("UIowaClaims.Core.Models.ReimbursementForm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Amount")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ReimbursementForms");
                });

            modelBuilder.Entity("UIowaClaims.Core.Models.ReimbursementWithFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ReimbursementFormId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UploadedFileId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ReimbursementFormId");

                    b.HasIndex("UploadedFileId");

                    b.ToTable("ReimbursementWithFiles");
                });

            modelBuilder.Entity("UIowaClaims.Core.Models.UploadedFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<long>("Size")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("UploadedFiles");
                });

            modelBuilder.Entity("UIowaClaims.Core.Models.ReimbursementWithFile", b =>
                {
                    b.HasOne("UIowaClaims.Core.Models.ReimbursementForm", "ReimbursementForm")
                        .WithMany()
                        .HasForeignKey("ReimbursementFormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UIowaClaims.Core.Models.UploadedFile", "UploadedFile")
                        .WithMany()
                        .HasForeignKey("UploadedFileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReimbursementForm");

                    b.Navigation("UploadedFile");
                });
#pragma warning restore 612, 618
        }
    }
}
