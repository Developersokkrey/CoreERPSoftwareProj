﻿// <auto-generated />
using CoreERPProj.DataApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoreERPProj.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoreERPProj.Models.Branches.Branch", b =>
                {
                    b.Property<decimal>("BranchID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("BranchID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CompID")
                        .HasColumnType("decimal(20,0)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BranchID");

                    b.HasIndex("CompID");

                    b.ToTable("BRANCH");
                });

            modelBuilder.Entity("CoreERPProj.Models.Branches.BranchInfor", b =>
                {
                    b.Property<decimal>("BranInforID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("BranInforID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("BranchID")
                        .HasColumnType("decimal(20,0)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BranInforID");

                    b.HasIndex("BranchID");

                    b.ToTable("BINFOR");
                });

            modelBuilder.Entity("CoreERPProj.Models.BusinessPartner.Vendor", b =>
                {
                    b.Property<decimal>("VendorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("VendorID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CompID")
                        .HasColumnType("decimal(20,0)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VendorID");

                    b.HasIndex("CompID");

                    b.ToTable("VENDOR");
                });

            modelBuilder.Entity("CoreERPProj.Models.BusinessPartners.Customer", b =>
                {
                    b.Property<decimal>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("CustomerID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CompID")
                        .HasColumnType("decimal(20,0)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerID");

                    b.HasIndex("CompID");

                    b.ToTable("CUSMER");
                });

            modelBuilder.Entity("CoreERPProj.Models.Companies.Company", b =>
                {
                    b.Property<decimal>("CompID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("CompID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("LCID")
                        .HasColumnType("decimal(20,0)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SCID")
                        .HasColumnType("decimal(20,0)");

                    b.HasKey("CompID");

                    b.ToTable("COMPAN");
                });

            modelBuilder.Entity("CoreERPProj.Models.Companies.Currency", b =>
                {
                    b.Property<decimal>("CurrID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("CurrID"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Symbol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CurrID");

                    b.ToTable("CUREER");
                });

            modelBuilder.Entity("CoreERPProj.Models.Companies.ExchangeRate", b =>
                {
                    b.Property<decimal>("ExchaRateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("ExchaRateID"));

                    b.Property<decimal>("CurrID")
                        .HasColumnType("decimal(20,0)");

                    b.Property<decimal>("Rate1")
                        .HasColumnType("decimal(25,12)");

                    b.Property<decimal>("Rate2")
                        .HasColumnType("decimal(25,12)");

                    b.HasKey("ExchaRateID");

                    b.HasIndex("CurrID");

                    b.ToTable("EXRATE");
                });

            modelBuilder.Entity("CoreERPProj.Models.UserAccounts.Department", b =>
                {
                    b.Property<decimal>("DeparmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("DeparmentID"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CompID")
                        .HasColumnType("decimal(20,0)");

                    b.Property<bool>("Enable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeparmentID");

                    b.HasIndex("CompID");

                    b.ToTable("DEPMENT");
                });

            modelBuilder.Entity("CoreERPProj.Models.UserAccounts.UserAccount", b =>
                {
                    b.Property<decimal>("UserAccountID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("UserAccountID"));

                    b.Property<decimal>("BranchID")
                        .HasColumnType("decimal(20,0)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("CompID")
                        .HasColumnType("decimal(20,0)");

                    b.Property<decimal>("DepartmentID")
                        .HasColumnType("decimal(20,0)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("RuleID")
                        .HasColumnType("decimal(20,0)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserAccountID");

                    b.HasIndex("BranchID");

                    b.HasIndex("CompID");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("RuleID");

                    b.ToTable("UERACC");
                });

            modelBuilder.Entity("CoreERPProj.Models.UsersPrivilege.Function", b =>
                {
                    b.Property<decimal>("FunctID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("FunctID"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FunctID");

                    b.ToTable("FUNCTI");
                });

            modelBuilder.Entity("CoreERPProj.Models.UsersPrivilege.Rule", b =>
                {
                    b.Property<decimal>("RuleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("RuleID"));

                    b.Property<decimal>("CompID")
                        .HasColumnType("decimal(20,0)");

                    b.Property<bool>("Enable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RuleID");

                    b.HasIndex("CompID");

                    b.ToTable("MARULE");
                });

            modelBuilder.Entity("CoreERPProj.Models.UsersPrivilege.RulePrivilege", b =>
                {
                    b.Property<decimal>("RulePrivID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("RulePrivID"));

                    b.Property<bool>("Enable")
                        .HasColumnType("bit");

                    b.Property<decimal>("FunctID")
                        .HasColumnType("decimal(20,0)");

                    b.Property<decimal>("RuleID")
                        .HasColumnType("decimal(20,0)");

                    b.HasKey("RulePrivID");

                    b.HasIndex("FunctID");

                    b.HasIndex("RuleID");

                    b.ToTable("RUPRIV");
                });

            modelBuilder.Entity("CoreERPProj.Models.UsersPrivilege.UsersPrivilege", b =>
                {
                    b.Property<decimal>("PrivilegeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(20,0)");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<decimal>("PrivilegeID"));

                    b.Property<decimal>("DepartmentID")
                        .HasColumnType("decimal(20,0)");

                    b.Property<bool>("Enable")
                        .HasColumnType("bit");

                    b.Property<decimal>("FunctID")
                        .HasColumnType("decimal(20,0)");

                    b.Property<decimal>("RulePrivID")
                        .HasColumnType("decimal(20,0)");

                    b.Property<decimal>("UserAccountID")
                        .HasColumnType("decimal(20,0)");

                    b.HasKey("PrivilegeID");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("FunctID");

                    b.HasIndex("RulePrivID");

                    b.HasIndex("UserAccountID");

                    b.ToTable("UPRIVI");
                });

            modelBuilder.Entity("CoreERPProj.Models.Branches.Branch", b =>
                {
                    b.HasOne("CoreERPProj.Models.Companies.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("CoreERPProj.Models.Branches.BranchInfor", b =>
                {
                    b.HasOne("CoreERPProj.Models.Branches.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("CoreERPProj.Models.BusinessPartner.Vendor", b =>
                {
                    b.HasOne("CoreERPProj.Models.Companies.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("CoreERPProj.Models.BusinessPartners.Customer", b =>
                {
                    b.HasOne("CoreERPProj.Models.Companies.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("CoreERPProj.Models.Companies.ExchangeRate", b =>
                {
                    b.HasOne("CoreERPProj.Models.Companies.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Currency");
                });

            modelBuilder.Entity("CoreERPProj.Models.UserAccounts.Department", b =>
                {
                    b.HasOne("CoreERPProj.Models.Companies.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("CoreERPProj.Models.UserAccounts.UserAccount", b =>
                {
                    b.HasOne("CoreERPProj.Models.Branches.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoreERPProj.Models.Companies.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoreERPProj.Models.UserAccounts.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoreERPProj.Models.UsersPrivilege.Rule", "Rule")
                        .WithMany()
                        .HasForeignKey("RuleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Company");

                    b.Navigation("Department");

                    b.Navigation("Rule");
                });

            modelBuilder.Entity("CoreERPProj.Models.UsersPrivilege.Rule", b =>
                {
                    b.HasOne("CoreERPProj.Models.Companies.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("CoreERPProj.Models.UsersPrivilege.RulePrivilege", b =>
                {
                    b.HasOne("CoreERPProj.Models.UsersPrivilege.Function", "Function")
                        .WithMany()
                        .HasForeignKey("FunctID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoreERPProj.Models.UsersPrivilege.Rule", "Rule")
                        .WithMany()
                        .HasForeignKey("RuleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Function");

                    b.Navigation("Rule");
                });

            modelBuilder.Entity("CoreERPProj.Models.UsersPrivilege.UsersPrivilege", b =>
                {
                    b.HasOne("CoreERPProj.Models.UserAccounts.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoreERPProj.Models.UsersPrivilege.Function", "Function")
                        .WithMany()
                        .HasForeignKey("FunctID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoreERPProj.Models.UsersPrivilege.RulePrivilege", "RulePrivilege")
                        .WithMany()
                        .HasForeignKey("RulePrivID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoreERPProj.Models.UserAccounts.UserAccount", "UserAccount")
                        .WithMany()
                        .HasForeignKey("UserAccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Function");

                    b.Navigation("RulePrivilege");

                    b.Navigation("UserAccount");
                });
#pragma warning restore 612, 618
        }
    }
}
