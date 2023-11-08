﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PLApp.Entity;

#nullable disable

namespace PLApp.Migrations
{
    [DbContext(typeof(TableContext))]
    [Migration("20231105114932_fixTransactionImport")]
    partial class fixTransactionImport
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PLApp.Entity.TableEntity.BankAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AccountCurrency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AccountName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BankName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("OpenBalanceAmount")
                        .HasColumnType("float");

                    b.Property<DateTime>("OpenBalanceDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BankAccounts");
                });

            modelBuilder.Entity("PLApp.Entity.TableEntity.BankTransaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("bankAccountId")
                        .HasColumnType("int");

                    b.Property<string>("details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("documentCategory")
                        .HasColumnType("int");

                    b.Property<double>("inwardAmount")
                        .HasColumnType("float");

                    b.Property<double>("outwardAmount")
                        .HasColumnType("float");

                    b.Property<string>("recipientAccountNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("recipientName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("statementType")
                        .HasColumnType("int");

                    b.Property<DateTime>("transactionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("transactionType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("voucherNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("bankAccountId");

                    b.ToTable("BankTransactions");
                });

            modelBuilder.Entity("PLApp.Entity.TableEntity.BankTransaction", b =>
                {
                    b.HasOne("PLApp.Entity.TableEntity.BankAccount", "bankAccount")
                        .WithMany("BankTransactions")
                        .HasForeignKey("bankAccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("bankAccount");
                });

            modelBuilder.Entity("PLApp.Entity.TableEntity.BankAccount", b =>
                {
                    b.Navigation("BankTransactions");
                });
#pragma warning restore 612, 618
        }
    }
}
