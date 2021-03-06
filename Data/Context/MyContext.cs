﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Data.Model;
using Microsoft.Extensions.Configuration;

namespace Data.Context
{
    public class MyContext : DbContext
    {
        private readonly IServiceProvider _serviceProvider;
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Attitude> Attitudes { get; set; }
        public DbSet<AttitudeTrainee> AttitudeTrainees { get; set; }
        public DbSet<Batch> Batchs { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<CourseComprehension> CourseComprehensions { get; set; }
        public DbSet<CourseComprehensionTrainee> CourseComprehensionTrainees { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FinalProject> FinalProjects { get; set; }
        public DbSet<FinalProjectTrainee> FinalProjectTrainees { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<BatchClass> BatchClasses { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }

        public MyContext() { }

        public MyContext(DbContextOptions<MyContext> options, IServiceProvider serviceProvider)
            : base(options)
        {
            _serviceProvider = serviceProvider;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
                var connectionString = configuration.GetConnectionString("Storage");
                optionsBuilder.UseMySql(connectionString);
            }
        }
    }
}