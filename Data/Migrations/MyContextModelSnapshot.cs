﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Data.Model.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreateDate");

                    b.Property<DateTimeOffset?>("DeleteDate");

                    b.Property<int?>("EmployeeId");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Password");

                    b.Property<int?>("RoleId");

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("RoleId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Data.Model.Attitude", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreateDate");

                    b.Property<DateTimeOffset?>("DeleteDate");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name");

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.ToTable("Attitudes");
                });

            modelBuilder.Entity("Data.Model.AttitudeTrainee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AttitudeId");

                    b.Property<DateTimeOffset>("CreateDate");

                    b.Property<DateTimeOffset?>("DeleteDate");

                    b.Property<bool>("IsDelete");

                    b.Property<int?>("TraineeId");

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.HasIndex("AttitudeId");

                    b.HasIndex("TraineeId");

                    b.ToTable("AttitudeTrainees");
                });

            modelBuilder.Entity("Data.Model.Batch", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreateDate");

                    b.Property<DateTimeOffset?>("DeleteDate");

                    b.Property<DateTimeOffset?>("FinishDate");

                    b.Property<bool>("IsDelete");

                    b.Property<DateTimeOffset>("JoinDate");

                    b.Property<string>("Name");

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Batchs");
                });

            modelBuilder.Entity("Data.Model.BatchClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BatchId");

                    b.Property<int?>("ClassId");

                    b.Property<DateTimeOffset>("CreateDate");

                    b.Property<DateTimeOffset?>("DeleteDate");

                    b.Property<bool>("IsDelete");

                    b.Property<int?>("TrainerId");

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("BatchId");

                    b.HasIndex("ClassId");

                    b.HasIndex("TrainerId");

                    b.ToTable("BatchClasses");
                });

            modelBuilder.Entity("Data.Model.Class", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreateDate");

                    b.Property<DateTimeOffset?>("DeleteDate");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name");

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("Data.Model.CourseComprehension", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClassId");

                    b.Property<DateTimeOffset>("CreateDate");

                    b.Property<DateTimeOffset?>("DeleteDate");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name");

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("ClassId");

                    b.ToTable("CourseComprehensions");
                });

            modelBuilder.Entity("Data.Model.CourseComprehensionTrainee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CourseComprehensionId");

                    b.Property<DateTimeOffset>("CreateDate");

                    b.Property<DateTimeOffset?>("DeleteDate");

                    b.Property<bool>("IsDelete");

                    b.Property<int?>("TraineeId");

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.HasIndex("CourseComprehensionId");

                    b.HasIndex("TraineeId");

                    b.ToTable("CourseComprehensionTrainees");
                });

            modelBuilder.Entity("Data.Model.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreateDate");

                    b.Property<DateTimeOffset?>("DeleteDate");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("LastName");

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Data.Model.Evaluation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreateDate");

                    b.Property<DateTimeOffset?>("DeleteDate");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name");

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.ToTable("Evaluations");
                });

            modelBuilder.Entity("Data.Model.FinalProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreateDate");

                    b.Property<DateTimeOffset?>("DeleteDate");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name");

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.ToTable("FinalProjects");
                });

            modelBuilder.Entity("Data.Model.FinalProjectTrainee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreateDate");

                    b.Property<DateTimeOffset?>("DeleteDate");

                    b.Property<int?>("FinalProjectId");

                    b.Property<bool>("IsDelete");

                    b.Property<int?>("TraineeId");

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.HasIndex("FinalProjectId");

                    b.HasIndex("TraineeId");

                    b.ToTable("FinalProjectTrainees");
                });

            modelBuilder.Entity("Data.Model.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreateDate");

                    b.Property<DateTimeOffset?>("DeleteDate");

                    b.Property<bool>("IsDelete");

                    b.Property<int>("MaxValue");

                    b.Property<string>("Name");

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("Data.Model.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreateDate");

                    b.Property<DateTimeOffset?>("DeleteDate");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name");

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Data.Model.Trainee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BatchClassId");

                    b.Property<DateTimeOffset>("CreateDate");

                    b.Property<DateTimeOffset?>("DeleteDate");

                    b.Property<int?>("GradeId");

                    b.Property<bool>("IsDelete");

                    b.Property<DateTimeOffset?>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("BatchClassId");

                    b.HasIndex("GradeId");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("Data.Model.Account", b =>
                {
                    b.HasOne("Data.Model.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.HasOne("Data.Model.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");
                });

            modelBuilder.Entity("Data.Model.AttitudeTrainee", b =>
                {
                    b.HasOne("Data.Model.Attitude", "Attitude")
                        .WithMany()
                        .HasForeignKey("AttitudeId");

                    b.HasOne("Data.Model.Trainee", "Trainee")
                        .WithMany()
                        .HasForeignKey("TraineeId");
                });

            modelBuilder.Entity("Data.Model.BatchClass", b =>
                {
                    b.HasOne("Data.Model.Batch", "Batch")
                        .WithMany()
                        .HasForeignKey("BatchId");

                    b.HasOne("Data.Model.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId");

                    b.HasOne("Data.Model.Employee", "Trainer")
                        .WithMany()
                        .HasForeignKey("TrainerId");
                });

            modelBuilder.Entity("Data.Model.CourseComprehension", b =>
                {
                    b.HasOne("Data.Model.Class", "Class")
                        .WithMany()
                        .HasForeignKey("ClassId");
                });

            modelBuilder.Entity("Data.Model.CourseComprehensionTrainee", b =>
                {
                    b.HasOne("Data.Model.CourseComprehension", "CourseComprehension")
                        .WithMany()
                        .HasForeignKey("CourseComprehensionId");

                    b.HasOne("Data.Model.Trainee", "Trainee")
                        .WithMany()
                        .HasForeignKey("TraineeId");
                });

            modelBuilder.Entity("Data.Model.FinalProjectTrainee", b =>
                {
                    b.HasOne("Data.Model.FinalProject", "FinalProject")
                        .WithMany()
                        .HasForeignKey("FinalProjectId");

                    b.HasOne("Data.Model.Trainee", "Trainee")
                        .WithMany()
                        .HasForeignKey("TraineeId");
                });

            modelBuilder.Entity("Data.Model.Trainee", b =>
                {
                    b.HasOne("Data.Model.BatchClass", "BatchClass")
                        .WithMany()
                        .HasForeignKey("BatchClassId");

                    b.HasOne("Data.Model.Grade", "Grade")
                        .WithMany()
                        .HasForeignKey("GradeId");
                });
#pragma warning restore 612, 618
        }
    }
}
