﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using goglobe_API.Data;

namespace goglobe_API.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("goglobe_API.Data.Entities.Agency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Agencies");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookingReference")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("TravelOfferId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("TravelOfferId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StarCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.Property", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Properties");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Property");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.TravelOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AgencyId")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<bool>("IsFeedingIncluded")
                        .HasColumnType("bit");

                    b.Property<int>("PersonCount")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AgencyId");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("HotelId");

                    b.ToTable("TravelOffers");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.TravelPhoto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PhotoId")
                        .HasColumnType("int");

                    b.Property<int>("TravelOfferId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PhotoId");

                    b.HasIndex("TravelOfferId");

                    b.ToTable("TravelPhotos");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.TravelProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<int>("TravelOfferId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PropertyId");

                    b.HasIndex("TravelOfferId");

                    b.ToTable("TravelProperties");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.ExludedProperty", b =>
                {
                    b.HasBaseType("goglobe_API.Data.Entities.Property");

                    b.HasDiscriminator().HasValue("ExludedProperty");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.IncludedProperty", b =>
                {
                    b.HasBaseType("goglobe_API.Data.Entities.Property");

                    b.HasDiscriminator().HasValue("IncludedProperty");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.Administrator", b =>
                {
                    b.HasBaseType("goglobe_API.Data.Entities.User");

                    b.HasDiscriminator().HasValue("Administrator");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.Client", b =>
                {
                    b.HasBaseType("goglobe_API.Data.Entities.User");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.HasDiscriminator().HasValue("Client");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.Booking", b =>
                {
                    b.HasOne("goglobe_API.Data.Entities.Client", "Client")
                        .WithMany("Bookings")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("goglobe_API.Data.Entities.TravelOffer", "TravelOffer")
                        .WithMany("Bookings")
                        .HasForeignKey("TravelOfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("TravelOffer");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.Room", b =>
                {
                    b.HasOne("goglobe_API.Data.Entities.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.TravelOffer", b =>
                {
                    b.HasOne("goglobe_API.Data.Entities.Agency", "Agency")
                        .WithMany()
                        .HasForeignKey("AgencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("goglobe_API.Data.Entities.City", "City")
                        .WithMany("TravelOffers")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("goglobe_API.Data.Entities.Country", "Country")
                        .WithMany("TravelOffers")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("goglobe_API.Data.Entities.Hotel", "Hotel")
                        .WithMany("TravelOffers")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Agency");

                    b.Navigation("City");

                    b.Navigation("Country");

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.TravelPhoto", b =>
                {
                    b.HasOne("goglobe_API.Data.Entities.Photo", "Photo")
                        .WithMany("TravelPhoto")
                        .HasForeignKey("PhotoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("goglobe_API.Data.Entities.TravelOffer", "TravelOffer")
                        .WithMany("TravelPhotos")
                        .HasForeignKey("TravelOfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Photo");

                    b.Navigation("TravelOffer");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.TravelProperty", b =>
                {
                    b.HasOne("goglobe_API.Data.Entities.Property", null)
                        .WithMany("TravelProperties")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("goglobe_API.Data.Entities.TravelOffer", "TravelOffer")
                        .WithMany("TravelProperties")
                        .HasForeignKey("TravelOfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TravelOffer");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.City", b =>
                {
                    b.Navigation("TravelOffers");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.Country", b =>
                {
                    b.Navigation("TravelOffers");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.Hotel", b =>
                {
                    b.Navigation("Rooms");

                    b.Navigation("TravelOffers");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.Photo", b =>
                {
                    b.Navigation("TravelPhoto");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.Property", b =>
                {
                    b.Navigation("TravelProperties");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.TravelOffer", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("TravelPhotos");

                    b.Navigation("TravelProperties");
                });

            modelBuilder.Entity("goglobe_API.Data.Entities.Client", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
