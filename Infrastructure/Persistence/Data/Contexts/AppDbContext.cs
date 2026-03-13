using Domain.Entities.AcademyStructure;
using Domain.Entities.Audit;
using Domain.Entities.Classes;
using Domain.Entities.Enrollments;
using Domain.Entities.Identity;
using Domain.Entities.Levels;
using Domain.Entities.Members;
using Domain.Entities.Payments;
using Domain.Entities.Staff;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data.Contexts
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        #region DbSets
        public DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Pool> Pools { get; set; }
        public DbSet<PoolWorkingHour> PoolWorkingHours { get; set; }
        public DbSet<Lane> Lanes { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Supervisor> Supervisors { get; set; }
        public DbSet<Guardian> Guardians { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<AgeGroup> AgeGroups { get; set; }
        public DbSet<ClassTemplate> ClassTemplates { get; set; }
        public DbSet<TransactionMonthlyClass> TransactionMonthlyClasses { get; set; }
        public DbSet<TransactionMonthlyClassLane> TransactionMonthlyClassLanes { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<EnrollmentDiscount> EnrollmentDiscounts { get; set; }
        public DbSet<PaymentTransaction> PaymentTransactions { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Assessment> Assessments { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly(typeof(AssemblyReference).Assembly);

        }
    }
}