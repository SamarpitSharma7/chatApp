﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using chatApp.Persistence;

#nullable disable

namespace chatApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240225142130_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("chatApp.Models.Chat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ChatName")
                        .HasColumnType("text");

                    b.Property<bool>("IsGroupChat")
                        .HasColumnType("boolean");

                    b.Property<Guid?>("UsersId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("Chats");
                });

            modelBuilder.Entity("chatApp.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("chatApp.Models.Chat", b =>
                {
                    b.HasOne("chatApp.Models.User", "Users")
                        .WithMany()
                        .HasForeignKey("UsersId");

                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}