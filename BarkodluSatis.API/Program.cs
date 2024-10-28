var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region DB i�lemleri

//builder.Services.AddDbContext<>(x =>
//{
//    x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
//    {
//        option.MigrationsAssembly(Assembly.GetAssembly(typeof(MentorEducationDB)).GetName().Name);
//    });
//});
#endregion
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
