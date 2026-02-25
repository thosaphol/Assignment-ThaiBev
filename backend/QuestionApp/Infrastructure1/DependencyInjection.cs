
using Application1.Interfaces;
using Infrastructure1.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure1;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IQuestionRepository, QuestionRepository>();

        return services;
    }
}
