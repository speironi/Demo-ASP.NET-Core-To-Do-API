var builder = WebApplication.CreateBuilder(args);

// habilitación de controladores
builder.Services.AddControllers();

// Habilitar el generador de interfaz visual Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Activar la interfaz en modo desarrollo
app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthorization();
app.MapControllers();

app.Run();