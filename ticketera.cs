static class ticketera
{
  private static Dictionary<int, Cliente> dicTicket = new Dictionary<int, Cliente>();
    public static int AgregarCliente(Cliente objcliente)
    {
      UltimoIDTicket++;
      dicTicket.Add(UltimoIDTicket, objcliente);
      return UltimoIDTicket;
    }
    public static Cliente BuscarCliente(int buscar)
    {
      Cliente objcliente = dicTicket[buscar];
      return objcliente;
    }
      private static int UltimoIDTicket = 0;
    public static int DevolverUltimoID()
    {
      return UltimoIDTicket;
    }
    public static bool CambiarEntrada(int buscar, int tipoEntrada, int cantidad)
    {
      bool sePudo=false;
      Cliente cliente=dicTicket[buscar];
      if (BuscarID.TotalAbono(tipoEntrada, cantidad)>BuscarID.TotalAbono(cliente.TipoEntrada, cliente.Cantidad))
      {
        sePudo = true;
        Sumar(tipoEntrada, BuscarID.TotalAbono(tipoEntrada, cantidad));
        Restar(cliente.TipoEntrada, BuscarID.TotalAbono(cliente.TipoEntrada, cliente.Cantidad));
        cliente.TipoEntrada = tipoEntrada;
        cliente.Cantidad = cantidad;
        dicTicket[buscar]=cliente;
      }
      return sePudo;
    }
    private static int AbonoTotal = 0;
    private static int Abono1 = 0;
    private static int Abono2 = 0;
    private static int Abono3 = 0;
    private static int Abono4 = 0;
  private static void Sumar(int tipoEntrada, int abono)
  {
        AbonoTotal += abono;
        switch (tipoEntrada)
        {
            case 1:
                Abono1 += abono;
            break;
            case 2:
                Abono2 += abono;
            break;
            case 3:
                Abono3 += abono;
            break;
            case 4:
                Abono4 += abono;
            break;
        }
    }
    private static void Restar(int tipoEntrada, int abono)
    {
        AbonoTotal -= abono;
        switch (tipoEntrada)
        {
            case 1:
                Abono1 -= abono;
            break;
            case 2:
                Abono2 -= abono;
            break;
            case 3:
                Abono3 -= abono;
            break;
            case 4:
                Abono4 -= abono;
            break;
        }
    }
}