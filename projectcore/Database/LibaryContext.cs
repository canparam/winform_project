using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using projectcore.models;

namespace projectcore.Database
{
   public class LibaryContext : DbContext
   {
        public DbSet<Admin> Admin { set; get; }
        public DbSet<Authors> Authors { set; get; }
        public DbSet<Book> Books { set; get; }
        public DbSet<Genres> Genres { set; get; }
        public DbSet<Issua_list> Issua_list { set; get; }
        public DbSet<Issues> Issues { set; get; }
        public DbSet<Publishers> Publishers { set; get; }
        public DbSet<Users> Users { set; get; } 


        private const string connectionString = @"Data Source=CAN\CANNV;
                                                Initial Catalog=libary;
                                                User ID=sa;
                                                Password=123123123;
                                                Persist Security Info=True;
                                                ";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
        

    }
}
