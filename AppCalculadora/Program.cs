using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadora
{
    internal class Program
    {
        // Variables del programa 
     static  float num1 = 0;
     static float num2 = 0;
     static float result = 0;
     static int opcion = 0;


        /// <summary>
        /// Metodo encargado de ejecutar los metodos del programa
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // se utiliza el metodo
            MostrarMenu();

            // se finaliza el menu
            Console.WriteLine("Presione una tecla para finalizar");
            Console.ReadKey();
            Environment.Exit(0);
        }
        static void MostrarMenu()
        {
            // se contruyen las opciones
            string opciones = "Aplicacion Calculadora\n";
            opciones += "1. Ingresar numeros.\n";
            opciones += "2. Operacion Sumar.\n";
            opciones += "3. Operacion Restar.\n";
            opciones += "4. Operacion Multiplicar .\n";
            opciones += "5. Operacion Dividir.\n";
            opciones += "6. Salir\n";
            opciones += "Digite una opcion: ";

            //loop un ciclo de repeticion
            Console.WriteLine("Presione Cualquier Tecla Para Comenzar");
            Console.ReadLine();

            do
            {
                // se muestra el menu
                Console.WriteLine(opciones);
                // se captura la opcion digitada 
                opcion = int.Parse(Console.ReadLine());

                // case para anilazar el proceso 
                switch (opcion)
                {
                    //proceso para solicitar los numeros
                    case 1: SolicitarNumeros();
                        break;
                        //proceso sumar 
                    case 2:
                        ProcesoSumar();
                        break;
                    //proceso restar 
                    case 3:
                        ProcesoRestar();
                        break;
                    //proceso multiplicar 
                    case 4:
                        ProcesoMultiplicar();
                        break;
                    //proceso dividir
                    case 5:
                        ProcesoDivision();
                        break;
                    //proceso dividir
                    case 6:
                       Console.WriteLine("Gracias por usar la calculadora"); 
                        break;
                    default: Console.WriteLine("Esa Opcion No Existe");
                        break;
                } // cierre de switch 

            // Se debe indicar la condicion
            // Se repite siempre y cuando la variable opcion almacena un numero diferente a 6
            } while (opcion != 6);

        } // cierre metodo 

        //Metodo encargado de pedir numeros
        static void SolicitarNumeros()
        {
            // Solicitar el primer numero
            Console.WriteLine("Digite el primer numero: ");
            num1 = float.Parse(Console.ReadLine());

            // solicitar segundo numero 
            Console.WriteLine("Digite el segundo numero: ");
            num2 = float.Parse(Console.ReadLine());
        }

        // metodo encargado de sumatoria
        static void ProcesoSumar()
        { 
        
            // se realiza la suma 
            result = num1 + num2;

            // se muestra el resultado 
            Console.WriteLine("El resultado de la suma es: " + result);

        }

        // metodo encargado de resta
        static void ProcesoRestar()
        {

            // se realiza la resta 
            result = num1 - num2;

            // se muestra el resultado 
            Console.WriteLine("El resultado de la resta es: " + result);

        }


        // metodo encargado de multiplicacion
        static void ProcesoMultiplicar()
        {

            // se realiza la resta 
            result = num1 * num2;

            // se muestra el resultado 
            Console.WriteLine("El resultado de la multiplicacion es: " + result);

        }

        // metodo encargado de division
        static void ProcesoDivision()
        {

            // se realiza la division 
            result = num1 / num2;

            // se muestra el resultado 
            Console.WriteLine("El resultado de la division es: " + result);
        }






    }  // cierre class
} // cierre namespace 
