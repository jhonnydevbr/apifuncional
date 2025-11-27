using System;
using apifuncional.Models;
using Microsoft.EntityFrameworkCore;

namespace apifuncional.Data;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {

    }
    public DbSet<Produto> Produtos { get; set; }

}
