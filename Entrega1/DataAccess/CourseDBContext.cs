using Microsoft.EntityFrameworkCore;
using Entrega1.Models.Data;

namespace Entrega1.DataAccess
{
    public class CourseDBContext : DbContext
    {
        public CourseDBContext(DbContextOptions<CourseDBContext> options) : base(options)
        {
        }
        public DbSet<Curso>? Users { get; set; }
    }
}
