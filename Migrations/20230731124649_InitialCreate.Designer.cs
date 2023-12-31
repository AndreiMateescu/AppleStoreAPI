﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Subscriptions.Data;

#nullable disable

namespace Subscriptions.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230731124649_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Subscriptions.Models.Notification", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("BundleId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NotificationType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NotificationUUID")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NotificationVersion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Subtype")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Notifications");
                });
#pragma warning restore 612, 618
        }
    }
}
