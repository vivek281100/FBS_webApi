using Fbs_webApi_v1.Db_FbsContext;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<FbsContext>(
    options => {
        options.UseSqlServer(connectionString: builder.Configuration.GetConnectionString("DefaultConnectionString"));
    });
//Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=FbsV1Demo;
//Integrated Security=True;Connect Timeout=30;Encrypt=False;
//Trust Server Certificate=False;Application Intent=ReadWrite;
//Multi Subnet Failover=False
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
