﻿using ArmSclad.Infrastructure.Database.Model;
using Microsoft.EntityFrameworkCore;

namespace ArmSclad.Infrastructure.Database.Context
{
    public class MyDbContext : DbContext
    {
        // таблицы базы данных
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientStatus> ClientStatuses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeePosition> EmploeePositions { get; set; }
        public DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<OperationStatus> OperationStatuses { get; set; }
        public DbSet<OperationType> OperationTypes { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<StorageProduct> StorageProducts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //создание составных ключей
            modelBuilder.Entity<OrderProduct>().HasKey(p => new { p.OrderId, p.ProductId });
            modelBuilder.Entity<StorageProduct>().HasKey(s => new { s.StorageId, s.ProductId });

            modelBuilder.Entity<Client>().ToTable(tb => tb.HasTrigger("insert_client_trigger"));
            modelBuilder.Entity<Operation>().ToTable(tb => tb.HasTrigger("insert_operation_trigger"));

            base.OnModelCreating(modelBuilder);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //подключениe к базе данных

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-E86S7QI;Database=ArmStorage;Trusted_Connection=True;TrustServerCertificate=true;MultipleActiveResultSets=true;");
                optionsBuilder.EnableSensitiveDataLogging();
            }


            base.OnConfiguring(optionsBuilder);
        }

    }
}
