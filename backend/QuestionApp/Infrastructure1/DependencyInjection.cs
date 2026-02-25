
// using Application1.Interfaces;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QuestionApp.Application1.Interfaces;
using QuestionApp.Infrastructure1.Persistence;
using QuestionApp.Infrastructure1.Persistence.Repositories;

namespace QuestionApp.Infrastructure1;

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
