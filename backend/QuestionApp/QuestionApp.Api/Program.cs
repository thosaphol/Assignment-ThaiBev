
using QuestionApp.Infrastructure;
using QuestionApp.Application;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
// builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// builder.Services.AddDbContext<AppDbContext>(options =>
//     options.UseSqlServer(
//         builder.Configuration.GetConnectionString("DefaultConnection")));
// builder.Services.AddScoped<IQuestionRepository, QuestionRepository>();
// builder.Services.AddScoped<QuestionService>();

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
    
}

app.UseCors(option =>
{
    option.AllowAnyHeader();
    option.AllowAnyMethod();
    option.AllowAnyOrigin();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
