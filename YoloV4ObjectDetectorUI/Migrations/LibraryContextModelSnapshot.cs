﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using YoloV4ObjectDetectorUI;

namespace YoloV4ObjectDetectorUI.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21");

            modelBuilder.Entity("YoloV4ObjectDetectorUI.DetectedObject", b =>
                {
                    b.Property<int>("ObjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClassName")
                        .HasColumnType("TEXT");

                    b.Property<int?>("DetailsID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Width")
                        .HasColumnType("INTEGER");

                    b.Property<int>("X")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Y")
                        .HasColumnType("INTEGER");

                    b.HasKey("ObjectId");

                    b.HasIndex("DetailsID");

                    b.ToTable("DetectedObjects");
                });

            modelBuilder.Entity("YoloV4ObjectDetectorUI.DetectedObjectDetails", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Image")
                        .HasColumnType("BLOB");

                    b.HasKey("ID");

                    b.ToTable("DetectedObjectsDetails");
                });

            modelBuilder.Entity("YoloV4ObjectDetectorUI.DetectedObject", b =>
                {
                    b.HasOne("YoloV4ObjectDetectorUI.DetectedObjectDetails", "Details")
                        .WithMany()
                        .HasForeignKey("DetailsID");
                });
#pragma warning restore 612, 618
        }
    }
}
