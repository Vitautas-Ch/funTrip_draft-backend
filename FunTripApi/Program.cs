using ORM;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//
using ApplicationContext applicationContext = new ApplicationContext();

applicationContext.Database.EnsureCreated();

applicationContext.Regions.Add(new Regions
{
    Name = "Name",
    MapLink = "MapLink",
    Description = "Description",
});

applicationContext.SaveChanges();

//

builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
