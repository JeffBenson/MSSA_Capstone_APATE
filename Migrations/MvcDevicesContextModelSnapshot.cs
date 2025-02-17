﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcDevices.Data;

namespace Project_APATE.Migrations
{
    [DbContext(typeof(MvcDevicesContext))]
    partial class MvcDevicesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MvcDevices.Models.Devices", b =>
                {
                    b.Property<int>("AssetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AssetName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ConnectionStatus")
                        .HasColumnType("bit");

                    b.Property<string>("Hostname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrivateIP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrivilegeID")
                        .HasColumnType("int");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<string>("PublicIP")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AssetID");

                    b.ToTable("Devices");
                });
#pragma warning restore 612, 618
        }
    }
}
