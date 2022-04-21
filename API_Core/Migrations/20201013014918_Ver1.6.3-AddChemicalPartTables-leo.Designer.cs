﻿// <auto-generated />
using System;
using INK_API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace INK_API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201013014918_Ver1.6.3-AddChemicalPartTables-leo")]
    partial class Ver163AddChemicalPartTablesleo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("INK_API.Models.Building", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Buildings");
                });

            modelBuilder.Entity("INK_API.Models.BuildingGlue", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BuildingID")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("GlueID")
                        .HasColumnType("int");

                    b.Property<string>("GlueName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MixingInfoID")
                        .HasColumnType("int");

                    b.Property<string>("Qty")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("BuildingGlues");
                });

            modelBuilder.Entity("INK_API.Models.BuildingUser", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BuildingID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("BuildingUser");
                });

            modelBuilder.Entity("INK_API.Models.Chemical", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DaysToExpiration")
                        .HasColumnType("int");

                    b.Property<int>("ExpiredTime")
                        .HasColumnType("int");

                    b.Property<DateTime>("ManufacturingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MaterialNO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Modify")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Percentage")
                        .HasColumnType("int");

                    b.Property<int>("ProcessID")
                        .HasColumnType("int");

                    b.Property<int>("SupplierID")
                        .HasColumnType("int");

                    b.Property<double>("Unit")
                        .HasColumnType("float");

                    b.Property<string>("VOC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isShow")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("ProcessID");

                    b.HasIndex("SupplierID");

                    b.ToTable("Chemicals");
                });

            modelBuilder.Entity("INK_API.Models.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ScheduleID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("INK_API.Models.Glues", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PartID")
                        .HasColumnType("int");

                    b.Property<int>("ScheduleID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Glueses");
                });

            modelBuilder.Entity("INK_API.Models.Ink", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("DaysToExpiration")
                        .HasColumnType("int");

                    b.Property<int>("ExpiredTime")
                        .HasColumnType("int");

                    b.Property<DateTime>("ManufacturingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MaterialNO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProcessID")
                        .HasColumnType("int");

                    b.Property<int>("SupplierID")
                        .HasColumnType("int");

                    b.Property<double>("Unit")
                        .HasColumnType("float");

                    b.Property<string>("VOC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isShow")
                        .HasColumnType("bit");

                    b.Property<int>("percentage")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProcessID");

                    b.HasIndex("SupplierID");

                    b.ToTable("Inks");
                });

            modelBuilder.Entity("INK_API.Models.InkTblObject", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProcessID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProcessID");

                    b.ToTable("InkTblObjects");
                });

            modelBuilder.Entity("INK_API.Models.Part", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ObjectID")
                        .HasColumnType("int");

                    b.Property<int>("ScheduleID")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("INK_API.Models.PartInkChemical", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChemicalID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("GlueID")
                        .HasColumnType("int");

                    b.Property<int>("InkID")
                        .HasColumnType("int");

                    b.Property<int>("PartID")
                        .HasColumnType("int");

                    b.Property<int>("Percentage")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("PartInkChemicals");
                });

            modelBuilder.Entity("INK_API.Models.Process", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SupplierID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("SupplierID");

                    b.ToTable("Processes");
                });

            modelBuilder.Entity("INK_API.Models.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("INK_API.Models.RoleUser", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("RoleUsers");
                });

            modelBuilder.Entity("INK_API.Models.SchedulePart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PartID")
                        .HasColumnType("int");

                    b.Property<int>("ScheduleID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("ScheduleParts");
                });

            modelBuilder.Entity("INK_API.Models.Schedules", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApprovalBy")
                        .HasColumnType("int");

                    b.Property<bool>("ApprovalStatus")
                        .HasColumnType("bit");

                    b.Property<int>("ArtProcessID")
                        .HasColumnType("int");

                    b.Property<int>("ArticleNoID")
                        .HasColumnType("int");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EstablishDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("FinishedStatus")
                        .HasColumnType("bit");

                    b.Property<int>("InkTblObjectID")
                        .HasColumnType("int");

                    b.Property<int>("ModelNameID")
                        .HasColumnType("int");

                    b.Property<int>("ModelNoID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ObjectInkID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ProductionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Season")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("InkTblObjectID");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("INK_API.Models.SchedulesUpdate", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApprovalBy")
                        .HasColumnType("int");

                    b.Property<bool>("ApprovalStatus")
                        .HasColumnType("bit");

                    b.Property<string>("ArticleNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EstablishDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("FinishedStatus")
                        .HasColumnType("bit");

                    b.Property<string>("ModelName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Process")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProductionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Season")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Treatment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("SchedulesUpdates");
                });

            modelBuilder.Entity("INK_API.Models.Setting", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("INK_API.Models.Supplier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ModifiedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProcessID")
                        .HasColumnType("int");

                    b.Property<bool>("isShow")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.HasIndex("ProcessID");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("INK_API.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("INK_API.Models.UserDetail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("LineID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("INK_API.Models.Chemical", b =>
                {
                    b.HasOne("INK_API.Models.Process", "Processes")
                        .WithMany()
                        .HasForeignKey("ProcessID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("INK_API.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("INK_API.Models.Ink", b =>
                {
                    b.HasOne("INK_API.Models.Process", "Processes")
                        .WithMany()
                        .HasForeignKey("ProcessID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("INK_API.Models.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("INK_API.Models.InkTblObject", b =>
                {
                    b.HasOne("INK_API.Models.Process", "Process")
                        .WithMany()
                        .HasForeignKey("ProcessID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("INK_API.Models.Process", b =>
                {
                    b.HasOne("INK_API.Models.Supplier", null)
                        .WithMany("Processes")
                        .HasForeignKey("SupplierID");
                });

            modelBuilder.Entity("INK_API.Models.Schedules", b =>
                {
                    b.HasOne("INK_API.Models.InkTblObject", "InkTblObject")
                        .WithMany("Schedules")
                        .HasForeignKey("InkTblObjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("INK_API.Models.Supplier", b =>
                {
                    b.HasOne("INK_API.Models.Process", "Process")
                        .WithMany()
                        .HasForeignKey("ProcessID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
