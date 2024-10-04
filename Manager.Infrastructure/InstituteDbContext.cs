using Manager.Infrastructure.Configurations;
using Manager.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Manager.Infrastructure;

public class InstituteDbContext(DbContextOptions<InstituteDbContext> options) : DbContext(options)
{
    public DbSet<Faculty> Faculties;
    public DbSet<Department> Departments;
    public DbSet<Group> Groups;
    public DbSet<Lecturer> Lecturers;
    public DbSet<Subject> Subjects;
    public DbSet<Student> Students;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ClassRoomConfiguration());
        modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
        modelBuilder.ApplyConfiguration(new FacultyConfiguration());
        modelBuilder.ApplyConfiguration(new GroupConfiguration());
        modelBuilder.ApplyConfiguration(new LecturerConfiguration());
        modelBuilder.ApplyConfiguration(new ScheduleConfiguration());
        modelBuilder.ApplyConfiguration(new StudentConfiguration());
        modelBuilder.ApplyConfiguration(new SubjectConfiguration());
    }
}