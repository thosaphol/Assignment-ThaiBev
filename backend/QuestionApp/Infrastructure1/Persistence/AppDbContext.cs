using System;
using Domain1.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure1.Persistence;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Question> Questions => Set<Question>();

}
