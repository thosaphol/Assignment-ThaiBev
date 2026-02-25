using System;
using Microsoft.EntityFrameworkCore;
using QuestionApp.Domain.Entities;
// using Domain1.Entities;
// using Microsoft.EntityFrameworkCore;

namespace QuestionApp.Infrastructure.Persistence;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Question> Questions => Set<Question>();

}
