var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.MapControllers();






//// Routing

//app.MapGet("/shirts", () =>
//{
//    return "Reading all the shirts";
//});

//app.MapGet("/shirts/{id}", (int id) =>
//{
//    return $"Reading shirt with id {id}";
//});

//app.MapPost("/shirts", () =>
//{
//    return "Creating a new shirt";
//});

//app.MapPut("/shirts/{id}", (int id) =>
//{
//    return $"Updating shirt with id {id}";
//});

//app.MapDelete("/shirts/{id}", (int id) =>
//{
//    return $"Deleting shirt with id {id}";
//});

app.Run();


