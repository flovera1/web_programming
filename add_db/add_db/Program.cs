using add_db.Data;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
// builder.Services.AddScoped(typeof(IAnonymousEurosongDataContext), typeof(AnonymousEurosongDataList));
// builder.Services.AddTransient(typeof(IAnonymousEurosongDataContext), typeof(AnonymousEurosongDataList));
	
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
  {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "AnonymousEurosong", Version = "v1" });
  });
builder.Services.AddSingleton(typeof(IAnonymousEurosongDataContext), typeof(AnonymousEurosongDatabase));


var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapControllers();
}

app.UseHttpsRedirection();
app.Run();


