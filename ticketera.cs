    
     static class ticketera
     {
      private static   Dictionary<int,Cliente> dicTicket = new Dictionary<int, Cliente>();
      public static int UltimoIDTicket = 0;
      public static int AgregarCliente(Cliente objcliente)
      {
        UltimoIDTicket++;
        dicTicket.Add(UltimoIDTicket,objcliente);
        return UltimoIDTicket;
      }
    
     }
     