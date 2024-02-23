using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace shoppingLibrary.Data

public class AppSecurityContext : IdentityDbContext<AppUser>
{
    public AppSecurityContext(DbContextOptions<AppSecurityContext> options) 
        : base(options) 
        { }
}