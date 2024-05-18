// See https://aka.ms/new-console-template for more information
class program
    {
        static void Main( string[] args)
        { 
            Cliente objcliente = new Cliente();
            const int UNO = 1, DOS = 2, TRES = 3, CUATRO = 4,  CINCO = 5;
            int ingrasarNum;
            bool salir = false;
            int cantInscripcion = 0;
            int cantInscripcionDia1 = 0;
            int cantInscripcionDia2 = 0;
            int cantInscripcionDia3 = 0;
            int cantInscripcionFullPass = 0;
            int total1 = 0;
            int total2 = 0;
            int total3 = 0;
            int total4 = 0;
            int suma1 = 0;
            int suma2 = 0;
            int suma3 = 0;
            int suma4 = 0;
            int encontrarDni = 0;

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
                        MostrarEstadisticas(cantInscripcion, cantInscripcionDia1, cantInscripcionDia2, cantInscripcionDia3, cantInscripcionFullPass, total1, total2, total3, total4, suma1, suma2, suma3, suma4);
                        break;
                    case TRES:
                        encontrarDni = BuscarDNI(encontrarDni);
                        /*int encontradoDni = ticketera.BuscarCliente(DNI);*/
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
                if(ingrasarNum == 1)
                {
                    cantInscripcion++;
                    if(objcliente.TipoEntrada == 45000)
                    {
                        cantInscripcionDia1++;
                        suma1 = cantInscripcionDia1 * 45000;
                    }
                    if(objcliente.TipoEntrada == 60000)
                    {
                        cantInscripcionDia2++;
                        
                        suma2 = cantInscripcionDia2 * 60000;
                    }
                    if(objcliente.TipoEntrada == 30000)
                    {
                        cantInscripcionDia3++;
                        suma3 = cantInscripcionDia3 * 30000;
                    }
                    if(objcliente.TipoEntrada == 100000)
                    {
                        cantInscripcionFullPass++;
                        suma4 = cantInscripcionFullPass * 100000;
                    }
                    total1 = cantInscripcionDia1 * 100 / cantInscripcion;
                    total2 = cantInscripcionDia1 * 100 / cantInscripcion;
                    total3 = cantInscripcionDia1 * 100 / cantInscripcion;
                    total4 = cantInscripcionDia1 * 100 / cantInscripcion;

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
            int multiplicacion = objcliente.Cantidad * objcliente.TipoEntrada;
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
            int multiplicacion;
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
                Console.WriteLine("Opción 1 - Día 1 , valor a abonar $45000");
                Console.WriteLine("Opción 2 - Día 2, valor a abonar $60000");
                Console.WriteLine("Opción 3 - Día 3, valor a abonar $30000");
                Console.WriteLine("Opción 4 - Full Pass, valor a abonar $100000");
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
        public static void MostrarEstadisticas(int cantInscripcion, int cantInscripcionDia1, int cantInscripcionDia2, int cantInscripcionDia3, int cantInscripcionFullPass, int total1, int total2, int total3, int total4, int suma1, int suma2, int suma3, int suma4)
        {
            int sumaTotal;
            if(cantInscripcion > 0)
            {
                Console.WriteLine("Total de personas inscriptas: " + cantInscripcion);
                Console.WriteLine("Total de personas en el dia 1: " + cantInscripcionDia1);
                Console.WriteLine("Total de personas en el dia 2: " + cantInscripcionDia2);
                Console.WriteLine("Total de personas en el dia 3: " + cantInscripcionDia3);
                Console.WriteLine("Total de personas en el dia FullPass: " + cantInscripcionFullPass);
                Console.WriteLine("Porcentaje del dia 1 respecto al total: " + total1);
                Console.WriteLine("Porcentaje del dia 1 respecto al tota2: " + total2);
                Console.WriteLine("Porcentaje del dia 1 respecto al tota3: " + total3);
                Console.WriteLine("Porcentaje del dia 1 respecto al tota4: " + total4);
                Console.WriteLine("Recaudación del dia 1: " + suma1);
                Console.WriteLine("Recaudación del dia 2: " + suma2);
                Console.WriteLine("Recaudación del dia 3: " + suma3);
                Console.WriteLine("Recaudación del dia 4: " + suma4);
                sumaTotal = suma1 + suma2 + suma3 + suma4;
                Console.WriteLine("La recaudación total es " + sumaTotal);
            }
            else {Console.WriteLine("No se inscribió nadie");}
        }
        static int BuscarDNI(int encontrarDni)
        {
            Console.WriteLine("Ingrese el DNI que quiere buscar");
            encontrarDni = int.Parse(Console.ReadLine());
            return encontrarDni;
        }
        /*static void MostrarDniEncontrado(bool seEncontro, List<Cliente>dicTicket, int encontrarDni)
        {

        }*/
    }
