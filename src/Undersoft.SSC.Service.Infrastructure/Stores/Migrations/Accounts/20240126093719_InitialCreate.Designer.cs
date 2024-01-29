﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Undersoft.SSC.Service.Infrastructure.Stores;

#nullable disable

namespace Undersoft.SSC.Service.Infrastructure.Stores.Migrations.Accounts
{
    [DbContext(typeof(AccountStore))]
    [Migration("20240126093719_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Accounts")
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Undersoft.SDK.Service.Server.Accounts.Account", b =>
                {
                    b.Property<long>("Id")
                        .HasColumnType("bigint")
                        .HasColumnOrder(1);

                    b.Property<bool>("Authenticated")
                        .HasColumnType("boolean");

                    b.Property<bool>("Authorized")
                        .HasColumnType("boolean");

                    b.Property<string>("CodeNo")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)")
                        .HasColumnOrder(4);

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp")
                        .HasColumnOrder(8);

                    b.Property<string>("Creator")
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)")
                        .HasColumnOrder(9);

                    b.Property<int>("Index")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnOrder(10);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Index"));

                    b.Property<string>("Label")
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)")
                        .HasColumnOrder(11);

                    b.Property<DateTime>("Modified")
                        .HasColumnType("timestamp")
                        .HasColumnOrder(6);

                    b.Property<string>("Modifier")
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)")
                        .HasColumnOrder(7);

                    b.Property<int>("OriginId")
                        .HasColumnType("integer")
                        .HasColumnOrder(3);

                    b.Property<long>("TypeId")
                        .HasColumnType("bigint")
                        .HasColumnOrder(2);

                    b.Property<string>("TypeName")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)")
                        .HasColumnOrder(5);

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Accounts", "Accounts");
                });

            modelBuilder.Entity("Undersoft.SDK.Service.Server.Accounts.AccountClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long>("AccountId")
                        .HasColumnType("bigint");

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<long>("TypeId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("UserId");

                    b.ToTable("AccountClaims", "Accounts");
                });

            modelBuilder.Entity("Undersoft.SDK.Service.Server.Accounts.AccountLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<long>("TypeId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AccountLogins", "Accounts");
                });

            modelBuilder.Entity("Undersoft.SDK.Service.Server.Accounts.AccountRole", b =>
                {
                    b.Property<long>("AccountId")
                        .HasColumnType("bigint");

                    b.Property<long>("AccountRoleId")
                        .HasColumnType("bigint");

                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<long>("TypeId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("AccountId", "AccountRoleId");

                    b.HasIndex("AccountRoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AccountRoles", "Accounts");
                });

            modelBuilder.Entity("Undersoft.SDK.Service.Server.Accounts.AccountToken", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<long>("AccountId")
                        .HasColumnType("bigint");

                    b.Property<long>("Id")
                        .HasColumnType("bigint");

                    b.Property<long>("TypeId")
                        .HasColumnType("bigint");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.HasIndex("AccountId");

                    b.ToTable("AccountTokens", "Accounts");
                });

            modelBuilder.Entity("Undersoft.SDK.Service.Server.Accounts.AccountUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<long?>("AccountId")
                        .HasColumnType("bigint");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<long>("TypeId")
                        .HasColumnType("bigint");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AccountUsers", "Accounts");
                });

            modelBuilder.Entity("Undersoft.SDK.Service.Server.Accounts.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<long>("TypeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("Roles", "Accounts");
                });

            modelBuilder.Entity("Undersoft.SDK.Service.Server.Accounts.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<long>("AccountRoleId")
                        .HasColumnType("bigint");

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<long>("TypeId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AccountRoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", "Accounts");
                });

            modelBuilder.Entity("Undersoft.SDK.Service.Server.Accounts.Account", b =>
                {
                    b.HasOne("Undersoft.SDK.Service.Server.Accounts.AccountUser", "User")
                        .WithOne()
                        .HasForeignKey("Undersoft.SDK.Service.Server.Accounts.Account", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Undersoft.SDK.Service.Server.Accounts.AccountClaim", b =>
                {
                    b.HasOne("Undersoft.SDK.Service.Server.Accounts.Account", "Account")
                        .WithMany("Claims")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Undersoft.SDK.Service.Server.Accounts.AccountUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Undersoft.SDK.Service.Server.Accounts.AccountLogin", b =>
                {
                    b.HasOne("Undersoft.SDK.Service.Server.Accounts.AccountUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Undersoft.SDK.Service.Server.Accounts.AccountRole", b =>
                {
                    b.HasOne("Undersoft.SDK.Service.Server.Accounts.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Undersoft.SDK.Service.Server.Accounts.Role", "Role")
                        .WithMany()
                        .HasForeignKey("AccountRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Undersoft.SDK.Service.Server.Accounts.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Undersoft.SDK.Service.Server.Accounts.AccountUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Undersoft.SDK.Service.Server.Accounts.AccountToken", b =>
                {
                    b.HasOne("Undersoft.SDK.Service.Server.Accounts.Account", "Account")
                        .WithMany("Tokens")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Undersoft.SDK.Service.Server.Accounts.AccountUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Undersoft.SDK.Service.Server.Accounts.AccountUser", b =>
                {
                    b.HasOne("Undersoft.SDK.Service.Server.Accounts.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Undersoft.SDK.Service.Server.Accounts.RoleClaim", b =>
                {
                    b.HasOne("Undersoft.SDK.Service.Server.Accounts.Role", "Role")
                        .WithMany("Claims")
                        .HasForeignKey("AccountRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Undersoft.SDK.Service.Server.Accounts.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Undersoft.SDK.Service.Server.Accounts.Account", b =>
                {
                    b.Navigation("Claims");

                    b.Navigation("Tokens");
                });

            modelBuilder.Entity("Undersoft.SDK.Service.Server.Accounts.Role", b =>
                {
                    b.Navigation("Claims");
                });
#pragma warning restore 612, 618
        }
    }
}
