using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcTestApp.Models
{
    public class TestContext:DbContext
    {
        public TestContext()
        {
            
        }
        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Student> Students { get; set; }
    }
   
}
