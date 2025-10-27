using ASPNetIdentityDemo;
using ASPNetWeb.IdentityRole.Demo.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASPNetIdentityDemo.Data;

public class WebUserDbContext : IdentityDbContext<WebUser>
{
    public WebUserDbContext(DbContextOptions<WebUserDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
