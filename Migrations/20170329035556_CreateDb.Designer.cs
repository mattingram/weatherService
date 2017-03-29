using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WeatherService;

namespace WeatherService.Migrations
{
    [DbContext(typeof(WeatherContext))]
    [Migration("20170329035556_CreateDb")]
    partial class CreateDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("WeatherService.WeatherData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Humid");

                    b.Property<double>("Press");

                    b.Property<double>("Temp");

                    b.Property<DateTime>("Time");

                    b.HasKey("Id");

                    b.ToTable("Weather");
                });
        }
    }
}
