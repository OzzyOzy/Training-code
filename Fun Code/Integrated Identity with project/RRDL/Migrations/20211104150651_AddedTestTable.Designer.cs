﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RRDL;

namespace RRDL.Migrations
{
    [DbContext(typeof(RRDatabaseContext))]
    [Migration("20211104150651_AddedTestTable")]
    partial class AddedTestTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RRModels.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("rest_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("rest_city");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("rest_name");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("rest_state");

                    b.HasKey("Id")
                        .HasName("PK__Restaura__9A2078C0B7A55AA5");

                    b.ToTable("Restaurant");
                });

            modelBuilder.Entity("RRModels.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("rev_id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Rating")
                        .HasColumnType("int")
                        .HasColumnName("rev_rating");

                    b.Property<int>("RestId")
                        .HasColumnType("int")
                        .HasColumnName("rest_id");

                    b.HasKey("Id")
                        .HasName("PK__Review__397465D62DF3E169");

                    b.HasIndex("RestId");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("RRModels.TestTable", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("TestTables");
                });

            modelBuilder.Entity("RRModels.Review", b =>
                {
                    b.HasOne("RRModels.Restaurant", "Restaurant")
                        .WithMany("Reviews")
                        .HasForeignKey("RestId")
                        .HasConstraintName("FK__Review__rest_id__01142BA1")
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RRModels.Restaurant", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
