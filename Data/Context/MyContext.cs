using Data.Models;
using Data.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Data.Context
{
    class MyContext : DbContext
    {
        private readonly IServiceProvider _serviceProvider;

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountRole> AccountRoles { get; set; }
        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }
        public DbSet<EmployeeDepartment> EmployeeDepartments { get; set; }
        public DbSet<EmployeePosition> EmployeePositions { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetLend> AssetLends { get; set; }
        public DbSet<AssetReturn> AssetReturns { get; set; }
        public DbSet<DamageAsset> DamageAssets { get; set; }
        public DbSet<DamageClassification> DamageClassifications { get; set; }
        public DbSet<DamageHistory> DamageHistories { get; set; }
        public DbSet<DamageType> DamageTypes { get; set; }
        public DbSet<NotebookRequest> NotebookRequests { get; set; }
        public DbSet<StatusApproval> StatusApprovals { get; set; }
        public DbSet<TypeAsset> TypeAssets { get; set; }
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
