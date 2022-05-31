using D151121ER_exam_prep.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D151121ER_exam_prep
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        //Hook- קטע קוד הרץ בעקבות אירוע שהתרחש במערכת

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer ("Server=LAPTOP-H6JI1LC8;Database=SchoolDB;Trusted_Connection=True;");
        }

        //מיגרציה- שם נרדף לבניית הבדלים בין הקוד לבסיס המידע


    }
}
