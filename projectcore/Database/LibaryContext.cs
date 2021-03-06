using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using projectcore.models;
using projectcore.models.views;

namespace projectcore.Database
{
   public class LibaryContext : DbContext
   {
        public DbSet<Admin> Admin { set; get; }
        public DbSet<Authors> Authors { set; get; }
        public DbSet<Book> Books { set; get; }
        public DbSet<Genres> Genres { set; get; }
        public DbSet<Issues_list> Issua_list { set; get; }
        public DbSet<Issues> Issues { set; get; }
        public DbSet<Publishers> Publishers { set; get; }
        public DbSet<Users> Users { set; get; } 
        public DbSet<AllBook> AllBook { set; get; } 
        //public DbSet<InfoBook> InfoBook { set; get; } 


        private const string connectionString = @"Data Source=DESKTOP-HF0SK0C;
                                                Initial Catalog=libary;
                                                User ID=cannv;
                                                Password=123123123;
                                                Persist Security Info=True
                                                ";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(connectionString);
        }
       

    }
}
