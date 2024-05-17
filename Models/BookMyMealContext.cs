using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BookMyMeal.Models
{
    public partial class BookMyMealContext : DbContext
    {
        public BookMyMealContext()
        {
        }

        public BookMyMealContext(DbContextOptions<BookMyMealContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Meal> Meals { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=BHUVAN; Database=BookMyMeal;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("employee");

                entity.HasIndex(e => e.Username, "IX_employee")
                    .IsUnique();

                entity.Property(e => e.EmpId)
                    .ValueGeneratedNever()
                    .HasColumnName("emp_id");

                entity.Property(e => e.DeptId).HasColumnName("dept_id");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Meal>(entity =>
            {
                entity.ToTable("meal");

                entity.HasIndex(e => e.MealId, "IX_meal");

                entity.Property(e => e.MealId)
                    .ValueGeneratedNever()
                    .HasColumnName("meal_id");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.MealDay)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("meal_day");

                entity.Property(e => e.MealName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("meal_name");

                entity.Property(e => e.MealPrice).HasColumnName("meal_price");

                entity.Property(e => e.MealType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("meal_type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
