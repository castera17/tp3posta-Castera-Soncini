// See https://aka.ms/new-console-template for more information
class program
    {
        static void Main( string[] args)
        { 
            Cliente objcliente = new Cliente();
            const int UNO = 1, DOS = 2, TRES = 3, CUATRO = 4,  CINCO = 5;
            int ingrasarNum;
            bool salir = false;

            Console.WriteLine("1. Nueva inscripción");
            Console.WriteLine("2. Obtener estadísticas del evento");
            Console.WriteLine("3. Buscar cliente");
            Console.WriteLine("4. Cambiar entrada de un cliente");
            Console.WriteLine("5. Salir");

            while (!salir)
            {
            Console.WriteLine("Ingrese numero del 1 al 5");    
            ingrasarNum = int.Parse(Console.ReadLine());
                switch (ingrasarNum)
                {
                    case UNO:
                        objcliente = Inscripcion(objcliente);
                        int Nro = ticketera.AgregarCliente(objcliente);
                        Console.WriteLine("Compra finalizada, su numero de ticket es " + Nro);
                        break;
                    case DOS:
                        break;
                    case TRES:
                        break;
                    case CUATRO:
                        break;
                    case CINCO:
                        Console.WriteLine("Saliste");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Nuemro no valido");
                        break;
                }
                
            }

        }
        static public Cliente Inscripcion(Cliente cargarpersona)
        {
            Cliente objcliente = new Cliente();
            objcliente.Nombre = ValidarString("Ingresar nombre");
            objcliente.Apellido = ValidarString("Ingresar apellido");
            objcliente.DNI = ValidarInt("Ingresar dni");
            objcliente.TipoEntrada = ValidarTipoDeEntrada("ingrese el tipo de entrada");
            objcliente.Cantidad = ValidarInt("ingrese la cantidad");
            return objcliente;
        }
        static string ValidarString(string texto)
        {
            string dato;
            do
            {
                Console.WriteLine(texto);
                dato = Console.ReadLine();
                if(dato == string.Empty)
                {
                    Console.WriteLine("ERROR, ingresar otra vez");
                }
            }while (dato == string.Empty);
            return dato;
        }
        static int ValidarInt(string texto)
        {
            int dato;
            do
            {
                Console.WriteLine(texto);
                dato = int.Parse(Console.ReadLine());
                if(dato < 1)
                {
                    Console.WriteLine("ERROR, ingresar otra vez");
                }
            }while (dato < 1);
            return dato;
        }
        static int ValidarTipoDeEntrada(string texto)
        {
            int dato;
            const int Tipo_1 = 45000, Tipo_2 = 60000, Tipo_3 = 30000, FullPass = 100000;
            do
            {
                Console.WriteLine(texto);
                dato = int.Parse(Console.ReadLine());
                if(dato < 1 || dato > 4)
                {
                    Console.WriteLine("EEROR, ingresar otra vez");
                }
            }while(dato < 1 || dato > 4);
            if(dato == 1)
            {
                dato = Tipo_1;
            }
            if(dato == 2)
            {
                dato = Tipo_2;
            }
            if(dato == 3)
            {
                dato = Tipo_3;
            }
            if(dato == 4)
            {
                dato = FullPass;
            }
            return dato;
        }
       
    }
