﻿// <auto-generated />
using FootBallLeague;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FootBallLeague.Migrations
{
    [DbContext(typeof(FootBallLeagueContextDB))]
    [Migration("20221125121257_Post1")]
    partial class Post1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FootBallLeague.Models.ScoreBoard", b =>
                {
                    b.Property<int>("MatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MatchId"), 1L, 1);

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamName1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamName2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WinningTeams")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MatchId");

                    b.ToTable("ScoreBoards");
                });
#pragma warning restore 612, 618
        }
    }
}
