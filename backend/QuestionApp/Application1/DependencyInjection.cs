using System;
using Microsoft.Extensions.DependencyInjection;
using QuestionApp.Application1.Services;
// using QuestionApp.Application1;

namespace QuestionApp.Application1;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<QuestionService>();

        return services;
    }
}
