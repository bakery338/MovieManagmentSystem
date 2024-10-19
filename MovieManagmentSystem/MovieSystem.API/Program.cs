using MovieSystem.API.Configration;
using MovieSystem.Applaction.Configration;
using MovieSystem.Infrastructer.presistance.configeration;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region addservices regester 

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#endregion
//register custm services 
builder.Services.AddInfrastrucerService(builder.Configuration);
builder.Services.AddApplicationService(builder.Configuration);
builder.Services.AddApiService(builder.Configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
