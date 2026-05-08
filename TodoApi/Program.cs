var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Nuestra "Base de datos" temporal en memoria
var todos = new List<TodoItem>();

// RUTA 1: Obtener todas las tareas (GET)
app.MapGet("/todoitems", () => todos);

// RUTA 2: Crear una nueva tarea (POST)
app.MapPost("/todoitems", (TodoItem todo) => {
    todos.Add(todo);
    return Results.Created($"/todoitems/{todo.Id}", todo);
});

app.Run();

// Definición de nuestro objeto Tarea
public record TodoItem(int Id, string Name, bool IsComplete);