using System;
using apifuncional.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace apifuncional.Data;

public class ApiDbContext : IdentityDbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {

    }
    public DbSet<Produto> Produtos { get; set; }

}
