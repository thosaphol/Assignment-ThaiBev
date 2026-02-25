
// using Application1.Interfaces;

using Microsoft.Extensions.DependencyInjection;
using QuestionApp.Application1.Interfaces;
using QuestionApp.Infrastructure1.Persistence.Repositories;

namespace QuestionApp.Infrastructure1;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IQuestionRepository, QuestionRepository>();

        return services;
    }
}
