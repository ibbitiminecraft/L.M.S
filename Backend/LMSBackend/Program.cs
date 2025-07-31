var builder = WebApplication.CreateBuilder(args);

// ✅ Register controller support
builder.Services.AddControllers(); 

// Swagger/OpenAPI services
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Swagger UI only in development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization(); // Optional but usually needed

// ✅ Map controller routes
app.MapControllers();

app.Run();