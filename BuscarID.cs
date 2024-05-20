public static class BuscarID
{
    public static string LeerDNI(string texto)
        {
            string leer;
            Console.WriteLine(texto);
            leer = Console.ReadLine();
            return leer;
        }
    public static int TotalAbono(int tipoEntrada, int cantidad)
    {
        int abono=0;
        switch (tipoEntrada){
            case 1:
                abono=45000*cantidad;
            break;
            case 2:
                abono=60000*cantidad;
            break;
            case 3:
                abono=30000*cantidad;
            break;
            case 4:
                abono=100000*cantidad;
            break;
        }
        return abono;
    }
}