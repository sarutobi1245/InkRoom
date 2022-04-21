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
    [Migration("20200828072722_version1.0.5-addcreatedByBuildingGlueTable")]
    partial class version105addcreatedByBuildingGlueTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("INK_API.Models.ArtProcess", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArticleNoID")
                        .HasColumnType("int");

                    b.Property<int>("ProcessID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ArticleNoID");

                    b.HasIndex("ProcessID");

                    b.ToTable("ArtProcesses");
                });

            modelBuilder.Entity("INK_API.Models.ArticleNo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModelNoID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ModelNoID");

                    b.ToTable("ArticleNos");
                });

            modelBuilder.Entity("INK_API.Models.BPFCEstablish", b =>
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

                    b.Property<DateTime?>("BuildingDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("FinishedStatus")
                        .HasColumnType("bit");

                    b.Property<int>("ModelNameID")
                        .HasColumnType("int");

                    b.Property<int>("ModelNoID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Season")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ArtProcessID");

                    b.HasIndex("ArticleNoID");

                    b.HasIndex("ModelNameID");

                    b.HasIndex("ModelNoID");

                    b.ToTable("BPFCEstablishes");
                });

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

                    b.Property<string>("Qty")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("BuildingID");

                    b.HasIndex("GlueID");

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

            modelBuilder.Entity("INK_API.Models.Comment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BPFCEstablishID")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("INK_API.Models.Glue", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BPFCEstablishID")
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Consumption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("CreatedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExpiredTime")
                        .HasColumnType("int");

                    b.Property<int?>("KindID")
                        .HasColumnType("int");

                    b.Property<int?>("MaterialID")
                        .HasColumnType("int");

                    b.Property<int?>("MaterialNameID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PartID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BPFCEstablishID");

                    b.HasIndex("KindID");

                    b.HasIndex("MaterialID");

                    b.HasIndex("MaterialNameID");

                    b.HasIndex("PartID");

                    b.ToTable("Glues");
                });

            modelBuilder.Entity("INK_API.Models.GlueIngredient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Allow")
                        .HasColumnType("int");

                    b.Property<string>("CreatedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GlueID")
                        .HasColumnType("int");

                    b.Property<int>("IngredientID")
                        .HasColumnType("int");

                    b.Property<int>("Percentage")
                        .HasColumnType("int");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("GlueID");

                    b.HasIndex("IngredientID");

                    b.ToTable("GlueIngredient");
                });

            modelBuilder.Entity("INK_API.Models.Ingredient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<string>("CreatedDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExpiredTime")
                        .HasColumnType("int");

                    b.Property<DateTime>("ManufacturingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MaterialNO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SupplierID")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VOC")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("SupplierID");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("INK_API.Models.Kind", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Kinds");
                });

            modelBuilder.Entity("INK_API.Models.Line", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Line");
                });

            modelBuilder.Entity("INK_API.Models.MapModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ModelNameID")
                        .HasColumnType("int");

                    b.Property<int>("ModelNoID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("MapModel");
                });

            modelBuilder.Entity("INK_API.Models.Material", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("INK_API.Models.MaterialName", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("MaterialName");
                });

            modelBuilder.Entity("INK_API.Models.MixingInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChemicalA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChemicalB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChemicalC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChemicalD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChemicalE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpiredTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("GlueID")
                        .HasColumnType("int");

                    b.Property<int>("MixBy")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("GlueID");

                    b.ToTable("MixingInfos");
                });

            modelBuilder.Entity("INK_API.Models.ModelName", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("ModelNames");
                });

            modelBuilder.Entity("INK_API.Models.ModelNo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ModelNameID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ModelNameID");

                    b.ToTable("ModelNos");
                });

            modelBuilder.Entity("INK_API.Models.Part", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Parts");
                });

            modelBuilder.Entity("INK_API.Models.PartName", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PartName");
                });

            modelBuilder.Entity("INK_API.Models.PartName2", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("PartName2");
                });

            modelBuilder.Entity("INK_API.Models.Plan", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BPFCEstablishID")
                        .HasColumnType("int");

                    b.Property<int>("BuildingID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("HourlyOutput")
                        .HasColumnType("int");

                    b.Property<int>("WorkingHour")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("BPFCEstablishID");

                    b.HasIndex("BuildingID");

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("INK_API.Models.Process", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Processes");
                });

            modelBuilder.Entity("INK_API.Models.Supplier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

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

            modelBuilder.Entity("INK_API.Models.ArtProcess", b =>
                {
                    b.HasOne("INK_API.Models.ArticleNo", "ArticleNo")
                        .WithMany("ArtProcesses")
                        .HasForeignKey("ArticleNoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("INK_API.Models.Process", "Process")
                        .WithMany()
                        .HasForeignKey("ProcessID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("INK_API.Models.ArticleNo", b =>
                {
                    b.HasOne("INK_API.Models.ModelNo", "ModelNos")
                        .WithMany("ArticleNos")
                        .HasForeignKey("ModelNoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("INK_API.Models.BPFCEstablish", b =>
                {
                    b.HasOne("INK_API.Models.ArtProcess", "ArtProcess")
                        .WithMany("BPFCEstablishes")
                        .HasForeignKey("ArtProcessID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("INK_API.Models.ArticleNo", "ArticleNo")
                        .WithMany("BPFCEstablishes")
                        .HasForeignKey("ArticleNoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("INK_API.Models.ModelName", "ModelName")
                        .WithMany("BPFCEstablishes")
                        .HasForeignKey("ModelNameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("INK_API.Models.ModelNo", "ModelNo")
                        .WithMany("BPFCEstablishes")
                        .HasForeignKey("ModelNoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("INK_API.Models.BuildingGlue", b =>
                {
                    b.HasOne("INK_API.Models.Building", "Building")
                        .WithMany("BuildingGlues")
                        .HasForeignKey("BuildingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("INK_API.Models.Glue", "Glue")
                        .WithMany()
                        .HasForeignKey("GlueID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("INK_API.Models.Glue", b =>
                {
                    b.HasOne("INK_API.Models.BPFCEstablish", "BPFCEstablish")
                        .WithMany("Glues")
                        .HasForeignKey("BPFCEstablishID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("INK_API.Models.Kind", "Kind")
                        .WithMany("Glues")
                        .HasForeignKey("KindID");

                    b.HasOne("INK_API.Models.Material", "Material")
                        .WithMany("Glues")
                        .HasForeignKey("MaterialID");

                    b.HasOne("INK_API.Models.MaterialName", null)
                        .WithMany("Glues")
                        .HasForeignKey("MaterialNameID");

                    b.HasOne("INK_API.Models.Part", "Part")
                        .WithMany("Glues")
                        .HasForeignKey("PartID");
                });

            modelBuilder.Entity("INK_API.Models.GlueIngredient", b =>
                {
                    b.HasOne("INK_API.Models.Glue", "Glue")
                        .WithMany("GlueIngredients")
                        .HasForeignKey("GlueID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("INK_API.Models.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("INK_API.Models.Ingredient", b =>
                {
                    b.HasOne("INK_API.Models.Supplier", "Supplier")
                        .WithMany("Ingredients")
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("INK_API.Models.MixingInfo", b =>
                {
                    b.HasOne("INK_API.Models.Glue", "Glue")
                        .WithMany("MixingInfos")
                        .HasForeignKey("GlueID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("INK_API.Models.ModelNo", b =>
                {
                    b.HasOne("INK_API.Models.ModelName", "ModelName")
                        .WithMany("ModelNos")
                        .HasForeignKey("ModelNameID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("INK_API.Models.Plan", b =>
                {
                    b.HasOne("INK_API.Models.BPFCEstablish", "BPFCEstablish")
                        .WithMany("Plans")
                        .HasForeignKey("BPFCEstablishID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("INK_API.Models.Building", "Building")
                        .WithMany("Plans")
                        .HasForeignKey("BuildingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
