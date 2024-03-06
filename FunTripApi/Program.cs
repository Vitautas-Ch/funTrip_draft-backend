using DataAccessLayer.Interface;
using DataAccessLayer;
using ORM;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

AppDomain.CurrentDomain.SetData("DataDirectory", "FunTripApi");

// Add services to the container.

//
//using (ApplicationContext applicationContext = new ApplicationContext())
//{
//    applicationContext.Database.EnsureCreated();

//    using (IUnitOfWork unitOfWork = new UnitOfWork(applicationContext))
//    {
//        unitOfWork.RegionRepository.Create(new Region
//        {
//            Name = "Name",
//            MapLink = "MapLink",
//            Description = "Description",
//        });

//        unitOfWork.TypePlaceRepository.Create(new TypePlace
//        {
//            Type = "Type",
//        });

//        unitOfWork.Save();
//    };
//}


//using ApplicationContext applicationContext = new ApplicationContext();

//applicationContext.Database.EnsureCreated();

//applicationContext.Regions.Add(new Region
//{
//    Name = "Name",
//    MapLink = "MapLink",
//    Description = "Description",
//});

/*applicationContext.Cities.Add(new City
{
    Name = "Name",
    MapLink = "MapLink",
    Latitude = "Latitude",
    Longitude = "Longitude",
    Description = "Description",
});*/

//applicationContext.SaveChanges();


/*string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
string path = Path.GetDirectoryName(executable);
AppDomain.CurrentDomain.SetData("DataDirectory", path);*/
//

string path = Path.Combine(Directory.GetCurrentDirectory(), "App_Data");
//string connectionString = "Server=(localdb)\\MSSQLLocalDB;" +
//    "AttachDbFilename=[DataDirectory]\\FunTripDb.mdf;" +
//    "Integrated Security=True;Database=FunTripDb.mdf;";

string? connectionString = builder.Configuration.GetConnectionString("DefaulConnection");

if (connectionString != null)
{
    builder.Services.AddDbContext<DbContext, ApplicationContext>(
        options => options.UseSqlServer(
            connectionString.Replace("[DataDirectory]", path)));
}

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddControllers().AddJsonOptions(x => x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//
//{
//    context.Database.EnsureCreated();
//    using (IUnitOfWork unitOfWork = new UnitOfWork(context))
//    {
//        unitOfWork.RegionRepository.Create(new Region
//        {
//            Name = "Name",
//            MapLink = "MapLink",
//            Description = "Description",
//        });

//        unitOfWork.TypePlaceRepository.Create(new TypePlace
//        {
//            Type = "Type",
//        });

//        unitOfWork.Save();
//    };
//}
//

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using IServiceScope scope = app.Services.CreateScope();
using (ApplicationContext context = scope.ServiceProvider.GetRequiredService<ApplicationContext>())
{
    context.Database.EnsureCreated();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
