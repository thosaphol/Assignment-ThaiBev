
// using Application1.Interfaces;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuestionApp.Application.Interfaces;
using QuestionApp.Infrastructure.Persistence;
using QuestionApp.Infrastructure.Persistence.Repositories;

namespace QuestionApp.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services,IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IQuestionRepository, QuestionRepository>();

        return services;
    }
}
