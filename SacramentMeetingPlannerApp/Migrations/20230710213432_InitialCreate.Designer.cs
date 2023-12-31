﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SacramentMeetingPlannerApp.Data;

#nullable disable

namespace SacramentMeetingPlannerApp.Migrations
{
    [DbContext(typeof(SacramentMeetingPlannerAppContext))]
    [Migration("20230710213432_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SacramentMeetingPlannerApp.Models.SacramentMeeting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClosingHymn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClosingPrayer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConductingLeader")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntermediateHymn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MeetingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OpeningHymn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningPrayer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SacramentHymn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpeakerSubjects")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SacramentMeeting");
                });
#pragma warning restore 612, 618
        }
    }
}
