﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using eexplosive2;

namespace eexplosive2.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20190930182919_ActuallyAddedTables")]
    partial class ActuallyAddedTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("EExplosive2.Models.Explosive", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Time");

                    b.Property<string>("inputString");

                    b.HasKey("id");

                    b.ToTable("Explosives");
                });

            modelBuilder.Entity("EExplosive2.Models.Mumbling", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Time");

                    b.Property<string>("inputString");

                    b.HasKey("id");

                    b.ToTable("Mumblings");
                });
#pragma warning restore 612, 618
        }
    }
}
