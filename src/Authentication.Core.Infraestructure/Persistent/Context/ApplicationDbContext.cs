using Authentication.Core.Domain.Entities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Reflection;
using SystemIdentity = Authentication.Core.Domain.Entities.System;

namespace Authentication.Core.Infraestructure.Persistent.Context
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions, IConfiguration configuration) : DbContext(contextOptions)
    {
        private readonly IConfiguration _configuration = configuration;

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<RefreshToken> RefreshTokens { get; set; } = null!;
        public DbSet<Bitacora> Bitacora { get; set; } = null!;
        public DbSet<SystemIdentity> systems { get; set; } = null!;
        public DbSet<SystemUser> SystemUsers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
        public IDbConnection CreateConnection() => new SqlConnection(_configuration.GetConnectionString(""));
    }
}
