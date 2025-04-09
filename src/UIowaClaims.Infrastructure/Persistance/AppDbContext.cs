using Microsoft.EntityFrameworkCore;
using UIowaClaims.Core.Models;

namespace UIowaClaims.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<ReimbursementForm> ReimbursementForms { get; set; }
        public DbSet<UploadedFile> UploadedFiles { get; set; }
        public DbSet<ReimbursementWithFile> ReimbursementWithFiles { get; set; }
    }
}
