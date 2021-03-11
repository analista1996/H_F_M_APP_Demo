﻿// <auto-generated />
using H_F_M_APPDATA.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace H_F_M_APPDATA.Migrations
{
    [DbContext(typeof(HFM_Context))]
    partial class HFM_ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("H_F_M_APPMODEL.Models.Permitions.Permition", b =>
                {
                    b.Property<int>("Permition_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Permition_Type")
                        .HasMaxLength(1)
                        .HasColumnType("int");

                    b.HasKey("Permition_Id");

                    b.ToTable("Permitions");
                });

            modelBuilder.Entity("H_F_M_APPMODEL.Models.Users.User", b =>
                {
                    b.Property<int>("User_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Activated")
                        .HasMaxLength(1)
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("PassWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Permition_Id")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("UserName")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("User_Id");

                    b.HasIndex("Permition_Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("H_F_M_APPMODEL.Models.Users.User", b =>
                {
                    b.HasOne("H_F_M_APPMODEL.Models.Permitions.Permition", "Permition")
                        .WithMany()
                        .HasForeignKey("Permition_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permition");
                });
#pragma warning restore 612, 618
        }
    }
}
