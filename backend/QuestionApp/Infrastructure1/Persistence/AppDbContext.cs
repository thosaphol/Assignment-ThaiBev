using System;
using Microsoft.EntityFrameworkCore;
using QuestionApp.Domain1.Entities;
// using Domain1.Entities;
// using Microsoft.EntityFrameworkCore;

namespace QuestionApp.Infrastructure1.Persistence;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Question> Questions => Set<Question>();

}
