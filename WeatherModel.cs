using System;
using Microsoft.EntityFrameworkCore;

namespace WeatherService
{
    public class WeatherContext : DbContext
    {
        public DbSet<WeatherData> Weather { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(string.Format("filename={0}/Weather.db", AppContext.BaseDirectory));
        }
    }

    public class WeatherData
    {
        public WeatherData()
        {
        }

        public int Id { get; set; }
        public DateTime Time { get; set; }
        public double Temp { get; set; }
        public double Humid { get; set; }
        public double Press { get; set; }
    }
}
