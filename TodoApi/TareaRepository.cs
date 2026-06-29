namespace DemoApi;

public static class TareaRepository
{
    public static List<Tarea> ListaTareas = new List<Tarea>
    {
        new Tarea { Id = 1, Titulo = "Asignar hojas de ruta - Transporte Troncal", Completada = false },
        new Tarea { Id = 2, Titulo = "Control de stock e inventario en Depósito Central", Completada = true }
    };

    public static List<Tarea> ObtenerTodas() => ListaTareas;

    public static void Agregar(Tarea nuevaTarea)
    {
        nuevaTarea.Id = ListaTareas.Count + 1;
        ListaTareas.Add(nuevaTarea);
    }
}