using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SW_Project.Model;
namespace SW_Project.Models
{
    public class SW_Entity : DbContext
    {

        public SW_Entity(DbContextOptions<SW_Entity> options) : base(options)
     
        {


        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Attendence> Attendances { get; set; }
        public DbSet<AttendenceRecord> AttendenceRecords { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Exam> Exams { get; set; }

        public DbSet<EducationBot> EducationBot { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer("Data Source=WAFAA;Initial Catalog=SW;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EducationBot>()
            .HasKey(eb => eb.Id);

            modelBuilder.Entity<Attendence>()
             .HasOne(a => a.Student)
             .WithMany(s => s.Attendances)
             .HasForeignKey(a => a.studentId);


            modelBuilder.Entity<Parent>()
            .HasOne(p => p.student)
            .WithOne(s => s.parent)
            .HasForeignKey<Parent>(p => p.studentId);

            modelBuilder.Entity<Exam>()
            .HasMany(e => e.Students)
            .WithMany(s => s.Exams)
            .UsingEntity(j => j.ToTable("ExamStudents"));

            modelBuilder.Entity<EducationBot>()
           .HasOne(eb => eb.Teacher)
           .WithMany(t => t.EducationBots)
           .HasForeignKey(eb => eb.TeacherId);

            modelBuilder.Entity<EducationBot>()
            .HasOne(eb => eb.Exam)
            .WithMany()
            .HasForeignKey(eb => eb.ExamId);


            modelBuilder.Entity<EducationBot>()
           .HasOne(eb => eb.Student)
           .WithMany()
           .HasForeignKey(eb => eb.studentId);

            base.OnModelCreating(modelBuilder);

        }
    }
}