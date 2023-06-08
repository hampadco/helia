using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//add session
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo 
    { 
        Title = "Get  Data by consortium_id ", 
        Version = "v1",
        Description = " hampadco.com  "
    });
});
builder.Services.AddSession();
builder.Services.AddDistributedMemoryCache();


var app = builder.Build();
app.UseSession();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c => 
{ 
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API Title"); 
});

app.UseHttpsRedirection();




app.UseAuthorization();

app.MapControllers();

app.Run();
