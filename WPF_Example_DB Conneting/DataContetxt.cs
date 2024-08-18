using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WPF_Example_DB_Conneting.Models;

namespace WPF_Example_DB_Conneting
{
    public class DataContetxt : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =(localhost); database=TESTDB; User ID=id; Password=pw; Integrated Security=True; Encrypt=False;");
        }

        public DbSet<TEST_Table> TEST_Table { get; set; }
    }
}