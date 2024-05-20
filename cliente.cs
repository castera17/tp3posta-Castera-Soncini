public class Cliente
{
     public string Nombre {get; set; }
     public string Apellido {get; set; }
     public int DNI {get; set; }
     public DateTime  FechaDeInscripcion {get; set; }
     public int TipoEntrada {get; set; }
     public int Cantidad {get; set; }

    public Cliente(){}

    public Cliente(string nombre, string apellido, int dni, DateTime fechanDeInscripcion, int tipoEntrada, int cantidad)
    {
        Nombre = nombre;
        Apellido = apellido;
        DNI = dni;
        FechaDeInscripcion = fechanDeInscripcion;
        TipoEntrada = tipoEntrada;
        Cantidad = cantidad;
    }
}