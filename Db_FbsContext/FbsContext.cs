using System;
using Microsoft.EntityFrameworkCore;
using Fbs_webApi_v1.Models;



namespace Fbs_webApi_v1.Db_FbsContext
{
    public class FbsContext : DbContext
    {

        //public DbSet<Admin> admins { get; set; }   
        //public DbSet<Flight> flights { get; set; }
        //public DbSet<Reservation> reservations { get; set; }
        //public DbSet<ReservationPassenger> reservationPassengers { get; set; }

        //public DbSet<SeatAllocation> seatAllocations { get; set;}
        public FbsContext(DbContextOptions options) : base(options)
        { 
        
        }

        public DbSet<User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users");

            //seed data
            //modelBuilder.Entity<User>().HasData(
            string usersjson = System.IO.File.ReadAllText("users.json");
            List<User> userslist = System.Text.Json.JsonSerializer.Deserialize<List<User>>(usersjson);
                  
            foreach(User user in userslist)
            {
                modelBuilder.Entity<User>().HasData(user);
            }
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("YourConnectionStringHere");
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Reservation>()
        //        .HasKey(r => new { r.Flight_Id, r.User_Id });

        //    modelBuilder.Entity<Reservation>()
        //        .HasOne(b => b.Flight)
        //        .WithMany(f => f.User)
        //        .HasForeignKey(b => b.FlightId);

        //    modelBuilder.Entity<Booking>()
        //        .HasOne(b => b.Passenger)
        //        .WithMany(p => p.Bookings)
        //        .HasForeignKey(b => b.PassengerId);
        //}
    }
}
