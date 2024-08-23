using HRMS.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace HRMS.DataAccess.Context
{
    public class HRMSContext(DbContextOptions<HRMSContext> options) : DbContext(options)
    {
        public DbSet<Candidate> Candidate { get; set; }
    }
}
