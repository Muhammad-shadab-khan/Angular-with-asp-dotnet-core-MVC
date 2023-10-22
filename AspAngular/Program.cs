using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AspAngular.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AspAngularContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AspAngularContext") ?? throw new InvalidOperationException("Connection string 'AspAngularContext' not found.")));

// Add services to the container.




builder.Services.AddControllers();
builder.Services.AddCors(cors => cors.AddPolicy("MyPolicy", builder =>
{
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
}));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseCors("MyPolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
