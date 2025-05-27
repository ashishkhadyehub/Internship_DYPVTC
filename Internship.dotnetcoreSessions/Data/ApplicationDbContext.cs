using Internship.dotnetcoreSessions.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship.dotnetcoreSessions.Data
{

    //this class represents session with database
    public class ApplicationDbContext : DbContext
    {
        //ctor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

       

        public DbSet<Students> Students { get; set; }


    }
}
