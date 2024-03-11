using add_db.Data;
using add_db;
using Microsoft.AspNetCore.Authentication;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Authorization;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
  {
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "AnonymousEurosong", Version = "v1" });
  });   
builder.Services.AddSingleton(typeof(IAnonymousEurosongDataContext), typeof(AnonymousEurosongDatabase));  
//adjust ConfigureServices-method
builder.Services.AddCors(s =>  s.AddPolicy("MyPolicy", builder => builder.AllowAnyOrigin()
                                    .AllowAnyMethod()
                                    .AllowAnyHeader()));


                               
//adjust Configure-method 
//place this BEFORE the mapping of the endpoints and before use of authorization


                                    
//adjust Configure-method 
//place this BEFORE the mapping of the endpoints and before use of authorization
//ConfigureServices
builder.Services
  .AddAuthentication()
  .AddScheme<AuthenticationSchemeOptions, 
  		BasicAuthenticationHandler>("BasicAuthenticationScheme", options => { });

builder.Services.AddAuthorization(options => {
    options.AddPolicy("BasicAuthentication", 
    		new AuthorizationPolicyBuilder("BasicAuthenticationScheme").RequireAuthenticatedUser().Build());
  });

var app = builder.Build();
app.UseCors("MyPolicy");
app.UseHttpsRedirection();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthorization();
app.MapControllers();
app.Run();


