using System;
using System.Collections.Generic;
using Database_First.Models;
using Microsoft.EntityFrameworkCore;

namespace Database_First.NewFolder;

public partial class AirportContext : DbContext
{
    public AirportContext()
    {
    }

    public AirportContext(DbContextOptions<AirportContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Airline> Airlines { get; set; }

    public virtual DbSet<Airport> Airports { get; set; }

    public virtual DbSet<AirportOfficier> AirportOfficiers { get; set; }

    public virtual DbSet<Baggage> Baggages { get; set; }

    public virtual DbSet<FlightDaily> FlightDailies { get; set; }

    public virtual DbSet<Gate> Gates { get; set; }

    public virtual DbSet<Passenger> Passengers { get; set; }

    public virtual DbSet<SecurityCheckpoint> SecurityCheckpoints { get; set; }

    public virtual DbSet<Terminal> Terminals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
         optionsBuilder.UseSqlServer("Data Source=DESKTOP-H7LDUQG\\MSSQLSERVER01;Initial Catalog=Airport;Integrated Security=True;Trust Server Certificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Airline>(entity =>
        {
            entity.HasKey(e => e.AirlineId).HasName("PK__Airline__A016BF80CC3306A5");

            entity.ToTable("Airline");

            entity.Property(e => e.AirlineId).HasColumnName("airline_id");
            entity.Property(e => e.AirlineEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("airline_email");
            entity.Property(e => e.AirlineName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("airline_name");
            entity.Property(e => e.AirlineNumber).HasColumnName("airline_number");
            entity.Property(e => e.AirporttId).HasColumnName("airportt_id");

            entity.HasOne(d => d.Airportt).WithMany(p => p.Airlines)
                .HasForeignKey(d => d.AirporttId)
                .HasConstraintName("FK__Airline__airport__4CA06362");
        });

        modelBuilder.Entity<Airport>(entity =>
        {
            entity.HasKey(e => e.AirportId).HasName("PK__Airports__C795D516D6F77D9E");

            entity.Property(e => e.AirportId).HasColumnName("airport_id");
            entity.Property(e => e.AirportLocation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("airport_location");
            entity.Property(e => e.AirportName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("airport_name");
        });

        modelBuilder.Entity<AirportOfficier>(entity =>
        {
            entity.HasKey(e => e.PersonalId).HasName("PK__AirportO__C16BAC158BB13776");

            entity.ToTable("AirportOfficier");

            entity.HasIndex(e => e.Number, "UQ__AirportO__FD291E4103D18908").IsUnique();

            entity.Property(e => e.PersonalId).HasColumnName("personal_id");
            entity.Property(e => e.CheckpointId).HasColumnName("checkpoint_id");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("department");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Number).HasColumnName("number");
            entity.Property(e => e.Position)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("position");

            entity.HasOne(d => d.Checkpoint).WithMany(p => p.AirportOfficiers)
                .HasForeignKey(d => d.CheckpointId)
                .HasConstraintName("FK__AirportOf__check__49C3F6B7");
        });

        modelBuilder.Entity<Baggage>(entity =>
        {
            entity.HasKey(e => e.BaggageId).HasName("PK__Baggage__A3ADEABD536CB1CB");

            entity.ToTable("Baggage");

            entity.HasIndex(e => e.TrackingNumber, "UQ__Baggage__B2C338B71EA4DDC3").IsUnique();

            entity.Property(e => e.BaggageId).HasColumnName("baggage_id");
            entity.Property(e => e.BaggageWeight)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("baggage_weight");
            entity.Property(e => e.PassengerId).HasColumnName("passenger_id");
            entity.Property(e => e.TrackingNumber).HasColumnName("tracking_number");

            entity.HasOne(d => d.Passenger).WithMany(p => p.Baggages)
                .HasForeignKey(d => d.PassengerId)
                .HasConstraintName("FK__Baggage__passeng__4222D4EF");
        });

        modelBuilder.Entity<FlightDaily>(entity =>
        {
            entity.HasKey(e => e.FlightId).HasName("PK__FlightDa__E3705765D379C970");

            entity.ToTable("FlightDaily");

            entity.Property(e => e.FlightId).HasColumnName("flight_id");
            entity.Property(e => e.AirlineId).HasColumnName("airline_id");
            entity.Property(e => e.DepartureCity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("departure_city");
            entity.Property(e => e.DepartureTime).HasColumnName("departure_time");
            entity.Property(e => e.FlightStatue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("flight_statue");

            entity.HasOne(d => d.Airline).WithMany(p => p.FlightDailies)
                .HasForeignKey(d => d.AirlineId)
                .HasConstraintName("FK__FlightDai__airli__571DF1D5");
        });

        modelBuilder.Entity<Gate>(entity =>
        {
            entity.HasKey(e => e.GateId).HasName("PK__Gate__8CB11922018EC898");

            entity.ToTable("Gate");

            entity.Property(e => e.GateId).HasColumnName("gate_id");
            entity.Property(e => e.AirlineId).HasColumnName("airline_id");
            entity.Property(e => e.AvailabilityStatue)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("availability_statue");
            entity.Property(e => e.GateNumber).HasColumnName("gate_number");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");

            entity.HasOne(d => d.Airline).WithMany(p => p.Gates)
                .HasForeignKey(d => d.AirlineId)
                .HasConstraintName("FK__Gate__airline_id__4F7CD00D");

            entity.HasOne(d => d.Terminal).WithMany(p => p.Gates)
                .HasForeignKey(d => d.TerminalId)
                .HasConstraintName("FK__Gate__terminal_i__5070F446");
        });

        modelBuilder.Entity<Passenger>(entity =>
        {
            entity.HasKey(e => e.PassengerNumber).HasName("PK__Passenge__201812682343D737");

            entity.ToTable("Passenger");

            entity.Property(e => e.PassengerNumber).HasColumnName("Passenger_number");
            entity.Property(e => e.ContactNumber).HasColumnName("contact_number");
            entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nationality");
            entity.Property(e => e.PassengerEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("passenger_email");
        });

        modelBuilder.Entity<SecurityCheckpoint>(entity =>
        {
            entity.HasKey(e => e.CheckpointId).HasName("PK__Security__0D7B874C96D8C5B9");

            entity.ToTable("SecurityCheckpoint");

            entity.Property(e => e.CheckpointId).HasColumnName("checkpoint_id");
            entity.Property(e => e.AirportId).HasColumnName("airport_id");
            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");

            entity.HasOne(d => d.Airport).WithMany(p => p.SecurityCheckpoints)
                .HasForeignKey(d => d.AirportId)
                .HasConstraintName("FK__SecurityC__airpo__45F365D3");

            entity.HasOne(d => d.Terminal).WithMany(p => p.SecurityCheckpoints)
                .HasForeignKey(d => d.TerminalId)
                .HasConstraintName("FK__SecurityC__termi__44FF419A");
        });

        modelBuilder.Entity<Terminal>(entity =>
        {
            entity.HasKey(e => e.TerminalId).HasName("PK__Terminal__A7A7EB4140158F00");

            entity.ToTable("Terminal");

            entity.Property(e => e.TerminalId).HasColumnName("terminal_id");
            entity.Property(e => e.TerminalCapacity).HasColumnName("terminal_capacity");
            entity.Property(e => e.TerminalLocation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminal_location");
            entity.Property(e => e.TerminalName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("terminal_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
