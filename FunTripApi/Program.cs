using DataAccessLayer.Interface;
using DataAccessLayer;
using ORM;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//
using (ApplicationContext applicationContext = new ApplicationContext())
{
    applicationContext.Database.EnsureCreated();

    using (IUnitOfWork unitOfWork = new UnitOfWork(applicationContext))
    {
        unitOfWork.RegionRepository.Create(new Region
        {
            Name = "Name",
            MapLink = "MapLink",
            Description = "Description",
        });

        unitOfWork.TypePlaceRepository.Create(new TypePlace
        {
            Type = "Type",
        });

        unitOfWork.Save();
    };
}



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

AppDomain.CurrentDomain.SetData("DataDirectory", "FunTripApi");
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
