﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using uniProject.Models;

#nullable disable

namespace uniProject.Migrations
{
    [DbContext(typeof(FormContext))]
    [Migration("20230615185817_InitialCreate2")]
    partial class InitialCreate2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0-preview.5.23280.1");

            modelBuilder.Entity("uniProject.Models.MainFormModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int?>("AgeExceptionCondition")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BirthCity")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("BirthDate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BirthProvince")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("CaptiveTime")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ChildCount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CodePost")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("ConfirmLocalCity")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("ContractWork")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ContractWorkName")
                        .HasColumnType("TEXT");

                    b.Property<string>("EducationEndTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("EducationLevel")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("EducationSchool")
                        .HasColumnType("TEXT");

                    b.Property<string>("EducationTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int?>("FamilyWarHeroMember")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("HomePhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("InjuredTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<bool?>("LeftHandPerson")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LocalCity")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("LocalProvince")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<bool>("MarriageStatus")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("MedicineWork")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MedicineWorkName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("MilitaryServiceEndTime")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("MilitaryServiceMonth")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MilitaryServiceStatus")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MonthOfMedicine")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MonthOfWork")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<int>("NationalId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PassPortCode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("TEXT");

                    b.Property<string>("Religion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<bool?>("SameLocalPlace")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Sex")
                        .HasMaxLength(50)
                        .HasColumnType("INTEGER");

                    b.Property<long?>("TrackingId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("WantedJobTitle")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("WarTime")
                        .HasColumnType("TEXT");

                    b.Property<int?>("YearOfMedicine")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("YearOfWork")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("NationalId")
                        .IsUnique();

                    b.HasIndex("PassPortCode")
                        .IsUnique();

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.ToTable("Forms");
                });

            modelBuilder.Entity("uniProject.Models.UserModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("NationalId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NationalId")
                        .IsUnique();

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
