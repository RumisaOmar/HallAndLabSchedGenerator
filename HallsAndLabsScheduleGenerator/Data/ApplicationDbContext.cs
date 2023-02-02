using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ShedualeGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace HallsAndLabsScheduleGenerator.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        }

        public virtual DbSet<Hall> Halls { get; set; }
        public virtual DbSet<Lab> Labs { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<ScheduleData> ScheduleDatas { get; set; }
        public virtual DbSet<Subject>  Subjects { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Teacher_Subject>  Teacher_Subjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
