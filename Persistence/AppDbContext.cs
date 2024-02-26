using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using chatApp.Models;
using Microsoft.EntityFrameworkCore;

namespace chatApp.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions options) : base(options) {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Chat> Chats { get; set; }
    }
}