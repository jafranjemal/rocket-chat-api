using Microsoft.EntityFrameworkCore;
using roket_chat_api.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opt => {

    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));

});
 

var app = builder.Build();
app.MapControllers();
app.Run();
