﻿// <auto-generated />
using CopywritingWebSite.DataAccess.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CopywritingWebSite.DataAccess.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CopywritingWebSite.Domain.Entities.Article", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("ArticleText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("CopywritingWebSite.Domain.Entities.CopywritingStatus", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CopywritingStatuses");
                });

            modelBuilder.Entity("CopywritingWebSite.Domain.Entities.CustomerTheEmpolyeer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<double>("Amount")
                        .HasColumnType("double precision");

                    b.Property<string>("CardMmYy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("CustomerTheEmpolyeers");
                });

            modelBuilder.Entity("CopywritingWebSite.Domain.Entities.CustomerWorker", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("CardMmYy")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CountTheWork")
                        .HasColumnType("integer");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("CustomerWorkers");
                });

            modelBuilder.Entity("CopywritingWebSite.Domain.Entities.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("ArticeStatus")
                        .HasColumnType("boolean");

                    b.Property<string>("AttachedFile")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CopyWrirtingLevel")
                        .HasColumnType("integer");

                    b.Property<long>("CopywritingStatusId")
                        .HasColumnType("bigint");

                    b.Property<string>("CreateAt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("CustomerTheEmpolyeerId")
                        .HasColumnType("bigint");

                    b.Property<long>("CustomerWorkerId")
                        .HasColumnType("bigint");

                    b.Property<long>("CustomerWorkerIdId")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("LanguageStatus")
                        .HasColumnType("integer");

                    b.Property<string>("LifeTime")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("PriceStatusId")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CopywritingStatusId");

                    b.HasIndex("CustomerTheEmpolyeerId");

                    b.HasIndex("CustomerWorkerId");

                    b.HasIndex("PriceStatusId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CopywritingWebSite.Domain.Entities.PriceStatus", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("CopyWritingStatusId")
                        .HasColumnType("bigint");

                    b.Property<int>("CountSymbol")
                        .HasColumnType("integer");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("CopyWritingStatusId");

                    b.ToTable("PriceStatuses");
                });

            modelBuilder.Entity("CopywritingWebSite.Domain.Entities.TermAccount", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("ArticleStatus")
                        .HasColumnType("integer");

                    b.Property<long>("CustomerTheEmpolyeerId")
                        .HasColumnType("bigint");

                    b.Property<long>("CustomerWorkerId")
                        .HasColumnType("bigint");

                    b.Property<long>("CustomerWorkerIdId")
                        .HasColumnType("bigint");

                    b.Property<bool>("Done")
                        .HasColumnType("boolean");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("CustomerTheEmpolyeerId");

                    b.HasIndex("CustomerWorkerId");

                    b.ToTable("TermAccounts");
                });

            modelBuilder.Entity("CopywritingWebSite.Domain.Entities.Test", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ChooseOne")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ChooseThree")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ChooseTwo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("CopywritingWebSite.Domain.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("CreateAt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Role")
                        .HasColumnType("integer");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CopywritingWebSite.Domain.Entities.CustomerTheEmpolyeer", b =>
                {
                    b.HasOne("CopywritingWebSite.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CopywritingWebSite.Domain.Entities.CustomerWorker", b =>
                {
                    b.HasOne("CopywritingWebSite.Domain.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("CopywritingWebSite.Domain.Entities.Order", b =>
                {
                    b.HasOne("CopywritingWebSite.Domain.Entities.CopywritingStatus", "CopywritingStatus")
                        .WithMany()
                        .HasForeignKey("CopywritingStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CopywritingWebSite.Domain.Entities.CustomerTheEmpolyeer", "CustomerTheEmpolyeer")
                        .WithMany()
                        .HasForeignKey("CustomerTheEmpolyeerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CopywritingWebSite.Domain.Entities.CustomerWorker", "CustomerWorker")
                        .WithMany()
                        .HasForeignKey("CustomerWorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CopywritingWebSite.Domain.Entities.PriceStatus", "PriceStatus")
                        .WithMany()
                        .HasForeignKey("PriceStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CopywritingStatus");

                    b.Navigation("CustomerTheEmpolyeer");

                    b.Navigation("CustomerWorker");

                    b.Navigation("PriceStatus");
                });

            modelBuilder.Entity("CopywritingWebSite.Domain.Entities.PriceStatus", b =>
                {
                    b.HasOne("CopywritingWebSite.Domain.Entities.CopywritingStatus", "CopyWritingStatus")
                        .WithMany()
                        .HasForeignKey("CopyWritingStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CopyWritingStatus");
                });

            modelBuilder.Entity("CopywritingWebSite.Domain.Entities.TermAccount", b =>
                {
                    b.HasOne("CopywritingWebSite.Domain.Entities.CustomerTheEmpolyeer", "CustomerTheEmpolyeer")
                        .WithMany()
                        .HasForeignKey("CustomerTheEmpolyeerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CopywritingWebSite.Domain.Entities.CustomerWorker", "CustomerWorker")
                        .WithMany()
                        .HasForeignKey("CustomerWorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerTheEmpolyeer");

                    b.Navigation("CustomerWorker");
                });
#pragma warning restore 612, 618
        }
    }
}
