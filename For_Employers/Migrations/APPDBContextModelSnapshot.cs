﻿// <auto-generated />
using System;
using For_Employers.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace For_Employers.Migrations
{
    [DbContext(typeof(APPDBContext))]
    partial class APPDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("For_Employers.Model.Accounting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CompanyDStructureId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyDStructureId");

                    b.ToTable("Accounting");
                });

            modelBuilder.Entity("For_Employers.Model.CServiceDepartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CompanyDStructureId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyDStructureId");

                    b.ToTable("CServiceDepartment");
                });

            modelBuilder.Entity("For_Employers.Model.CompanyDStructure", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.ToTable("CompanyDStructure");
                });

            modelBuilder.Entity("For_Employers.Model.Employes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("AccountingId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<int?>("SubMenuid")
                        .HasColumnType("int");

                    b.Property<int?>("Submenu2id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountingId");

                    b.HasIndex("SubMenuid");

                    b.HasIndex("Submenu2id");

                    b.ToTable("Employes");
                });

            modelBuilder.Entity("For_Employers.Model.PDepartment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CompanyDStructureId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyDStructureId");

                    b.ToTable("PDepartment");
                });

            modelBuilder.Entity("For_Employers.Model.SubMenu", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CServiceDepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<int?>("PDepartmentId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("CServiceDepartmentId");

                    b.HasIndex("PDepartmentId");

                    b.ToTable("SubMenu");
                });

            modelBuilder.Entity("For_Employers.Model.Submenu2", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<int?>("SubMenuid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("SubMenuid");

                    b.ToTable("Submenu2");
                });

            modelBuilder.Entity("For_Employers.Model.Accounting", b =>
                {
                    b.HasOne("For_Employers.Model.CompanyDStructure", null)
                        .WithMany("Accounting")
                        .HasForeignKey("CompanyDStructureId");
                });

            modelBuilder.Entity("For_Employers.Model.CServiceDepartment", b =>
                {
                    b.HasOne("For_Employers.Model.CompanyDStructure", null)
                        .WithMany("CServiceDepartment")
                        .HasForeignKey("CompanyDStructureId");
                });

            modelBuilder.Entity("For_Employers.Model.Employes", b =>
                {
                    b.HasOne("For_Employers.Model.Accounting", null)
                        .WithMany("Sotrudnik")
                        .HasForeignKey("AccountingId");

                    b.HasOne("For_Employers.Model.SubMenu", null)
                        .WithMany("Sotrudnik")
                        .HasForeignKey("SubMenuid");

                    b.HasOne("For_Employers.Model.Submenu2", null)
                        .WithMany("Sotrudnik")
                        .HasForeignKey("Submenu2id");
                });

            modelBuilder.Entity("For_Employers.Model.PDepartment", b =>
                {
                    b.HasOne("For_Employers.Model.CompanyDStructure", null)
                        .WithMany("PDepartment")
                        .HasForeignKey("CompanyDStructureId");
                });

            modelBuilder.Entity("For_Employers.Model.SubMenu", b =>
                {
                    b.HasOne("For_Employers.Model.CServiceDepartment", null)
                        .WithMany("subMenus")
                        .HasForeignKey("CServiceDepartmentId");

                    b.HasOne("For_Employers.Model.PDepartment", null)
                        .WithMany("subMenus")
                        .HasForeignKey("PDepartmentId");
                });

            modelBuilder.Entity("For_Employers.Model.Submenu2", b =>
                {
                    b.HasOne("For_Employers.Model.SubMenu", null)
                        .WithMany("submenu2s")
                        .HasForeignKey("SubMenuid");
                });

            modelBuilder.Entity("For_Employers.Model.Accounting", b =>
                {
                    b.Navigation("Sotrudnik");
                });

            modelBuilder.Entity("For_Employers.Model.CServiceDepartment", b =>
                {
                    b.Navigation("subMenus");
                });

            modelBuilder.Entity("For_Employers.Model.CompanyDStructure", b =>
                {
                    b.Navigation("Accounting");

                    b.Navigation("CServiceDepartment");

                    b.Navigation("PDepartment");
                });

            modelBuilder.Entity("For_Employers.Model.PDepartment", b =>
                {
                    b.Navigation("subMenus");
                });

            modelBuilder.Entity("For_Employers.Model.SubMenu", b =>
                {
                    b.Navigation("Sotrudnik");

                    b.Navigation("submenu2s");
                });

            modelBuilder.Entity("For_Employers.Model.Submenu2", b =>
                {
                    b.Navigation("Sotrudnik");
                });
#pragma warning restore 612, 618
        }
    }
}
