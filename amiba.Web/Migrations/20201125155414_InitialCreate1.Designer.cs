﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using amiba.Web.Areas.api.Data;

namespace amiba.Web.Migrations
{
    [DbContext(typeof(BudgetContext))]
    [Migration("20201125155414_InitialCreate1")]
    partial class InitialCreate1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("amiba.Web.Areas.api.Data.M_Amiba", b =>
                {
                    b.Property<int>("M_Amiba_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<Guid?>("M_Amiba_code")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("M_Amiba_effectdate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("M_Amiba_isvaitual")
                        .HasColumnType("bit");

                    b.Property<string>("M_Amiba_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("M_Amiba_number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("M_Amiba_id");

                    b.ToTable("M_Budget_Amiba");
                });

            modelBuilder.Entity("amiba.Web.Areas.api.Data.M_Project", b =>
                {
                    b.Property<int>("M_Project_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<Guid?>("M_Amiba_code")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("M_Project_CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("M_Project_IndustryCode")
                        .HasColumnType("int");

                    b.Property<int?>("M_Project_IndustryName")
                        .HasColumnType("int");

                    b.Property<int?>("M_Project_ProjectType")
                        .HasColumnType("int");

                    b.Property<Guid?>("M_Project_code")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("M_Project_isvirtual")
                        .HasColumnType("bit");

                    b.Property<string>("M_Project_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("M_Project_parent")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("M_Region_code")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("M_Subject_code")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("M_Project_id");

                    b.ToTable("M_Budget_Project");
                });

            modelBuilder.Entity("amiba.Web.Areas.api.Data.M_Region", b =>
                {
                    b.Property<int>("M_Region_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<Guid?>("M_Region_code")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("M_Region_createdate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("M_Region_isvirtual")
                        .HasColumnType("bit");

                    b.Property<string>("M_Region_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("M_Region_id");

                    b.ToTable("M_Budget_Region");
                });

            modelBuilder.Entity("amiba.Web.Areas.api.Data.M_Reserve_Detail", b =>
                {
                    b.Property<int>("M_Reserve_Detail_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal?>("M1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("M10")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("M11")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("M12")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("M2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("M3")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("M4")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("M5")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("M6")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("M7")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("M8")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("M9")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("M_Reserve_Detail_code")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("M_Reserve_Detail_createdat")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("M_Reserve_Main_code")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("M_Subject_code")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("M_Subject_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("M_Subject_number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("M_Reserve_Detail_id");

                    b.ToTable("M_Budget_ReserveDetail");
                });

            modelBuilder.Entity("amiba.Web.Areas.api.Data.M_Reserve_Main", b =>
                {
                    b.Property<int>("M_Reserve_Main_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<Guid?>("M_Amiba_code")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("M_Project_code")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("M_Reserve_Main_code")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("M_Reserve_Main_createdate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("M_Reserve_Main_day")
                        .HasColumnType("int");

                    b.Property<int?>("M_Reserve_Main_month")
                        .HasColumnType("int");

                    b.Property<DateTime?>("M_Reserve_Main_registerdate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("M_Reserve_Main_state")
                        .HasColumnType("int");

                    b.Property<int?>("M_Reserve_Main_year")
                        .HasColumnType("int");

                    b.Property<Guid?>("P_Business_Flow_Form_code")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("M_Reserve_Main_id");

                    b.ToTable("M_Budget_ReserveMain");
                });

            modelBuilder.Entity("amiba.Web.Areas.api.Data.M_Subject", b =>
                {
                    b.Property<int>("M_Subject_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<Guid?>("M_Subject_code")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("M_Subject_isReadOnly")
                        .HasColumnType("bit");

                    b.Property<bool?>("M_Subject_isShow")
                        .HasColumnType("bit");

                    b.Property<string>("M_Subject_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("M_Subject_number")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("isDelete")
                        .HasColumnType("bit");

                    b.HasKey("M_Subject_id");

                    b.ToTable("M_Budget_Subject");
                });

            modelBuilder.Entity("amiba.Web.Areas.api.Data.Orgination", b =>
                {
                    b.Property<int>("M_Organization_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool?>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<Guid?>("M_Amiba_code")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("M_Organization_code")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("M_Organization_effectdate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("M_Organization_isvaitual")
                        .HasColumnType("bit");

                    b.Property<string>("M_Organization_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("M_Organization_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("M_Organization_parent")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("M_Region_code")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("M_Organization_id");

                    b.ToTable("M_Budget_Orgination");
                });
#pragma warning restore 612, 618
        }
    }
}
