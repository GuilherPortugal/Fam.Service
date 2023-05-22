using Fam.Service.Models;
using Microsoft.EntityFrameworkCore;

namespace Fam.Service.Context
{
    public class FamContext : DbContext
    {
        public FamContext(DbContextOptions<FamContext> options) : base(options) { }
        public DbSet<LoginEntity> Login { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ClassEntity> Class { get; set; }
        public DbSet<SchedulesEntity> Schedules { get; set; }
        public DbSet<ClassScheduleEntity> ClassSchedules { get; set; }
        public DbSet<TeachersEntity> Teachers { get; set; }
        public DbSet<TeachersClassEntity> TeacherClass { get; set; }
        public DbSet<StudentsEntity> Students { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
