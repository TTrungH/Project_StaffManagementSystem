using Microsoft.EntityFrameworkCore;
using StaffManagementSystem.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Position> Positions { get; set; }
    public DbSet<Attendance> Attendances { get; set; }
    public DbSet<Payroll> Payrolls { get; set; }
    public DbSet<PerformanceReview> PerformanceReviews { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Adjustment> Adjustments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Department>()
     .HasMany(d => d.Employees) // Mối quan hệ 1:N từ Department đến Employees
     .WithOne(e => e.Department) // Mối quan hệ 1:1 từ Employee đến Department
     .HasForeignKey(e => e.DepartmentId)
      .OnDelete(DeleteBehavior.NoAction); ; // Khóa ngoại của Employees
    }
}
