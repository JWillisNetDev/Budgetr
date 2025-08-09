using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Budgetr.App.Server.Database;

public class BudgetrDbContext : IdentityDbContext<IdentityUser>
{
    public BudgetrDbContext(DbContextOptions<BudgetrDbContext> options) : base(options)
    {
        
    }
}
