using System;

namespace TareaLibro
{
    //Aplicacion de prueba de la jerarquía de Empleado
    internal class PruebaSistemaNomina
    {
        public static void Main(string[] args)
        {
            //Crea objetos de clases derivadas
            EmpleadoAsalariado empleadoAsalariado = 
                new EmpleadoAsalariado("Jhon", "Smith", "111-11-111", 800.00M);

            EmpleadoPorHoras empleadoPorHoras = 
                new EmpleadoPorHoras("Karen", "Price", "222-22-222", 16.75M, 40.0M);

            EmpleadoPorComision empleadoPorComision =
                new EmpleadoPorComision("Sue", "Jones", "333-33-333", 10000.00M, .06M);

            EmpleadoBaseMasComision empleadoBaseMasComision =
                new EmpleadoBaseMasComision("Bob", "Lewis", "44-44-444", 5000.00M,.04M, 300.00M);
            
            Console.WriteLine("Empleados procesados en forma individual\n");
            
            Console.WriteLine("{0}\n{1}: {2:C}\n", empleadoAsalariado, "Ingresos", empleadoAsalariado.Ingresos());
            Console.WriteLine("{0}\n{1}: {2:C}\n", empleadoPorHoras, "Ingresos", empleadoPorHoras.Ingresos());
            Console.WriteLine("{0}\n{1}: {2:C}\n", empleadoPorComision, "Ingresos", empleadoPorComision.Ingresos());
            Console.WriteLine("{0}\n{1}: {2:C}\n", empleadoBaseMasComision, "Ingresos", empleadoBaseMasComision.Ingresos());
            
            //Crea arreglo Empleado de cuatro elementos
            Empleado[] empleados = new Empleado[4];
            
            //Inicializa arreglo con objetos Empleado de tipos derivados
            empleados[0] = empleadoAsalariado;
            empleados[1] = empleadoPorHoras;
            empleados[2] = empleadoPorComision;
            empleados[3] = empleadoBaseMasComision;
            
            Console.WriteLine("Empleados en forma polifórmica:\n ");
            
            //Procesa en forma genérica cada elemento en el arreglo de empleados
            foreach (Empleado empleadoActual in empleados)
            {
                Console.WriteLine(empleadoActual); //Invoca a ToString
                
                //Determina si el elemento actual es un EmpleadoBaseMasComision
                if (empleadoActual is EmpleadoBaseMasComision)
                {
                    //Conversión desendente de referencia de Empleado a referencia de EmpleadoBaseMasComision
                    EmpleadoBaseMasComision empleado = (EmpleadoBaseMasComision) empleadoActual;

                    empleado.SalarioBase *= 1.10M;
                    Console.WriteLine("Nuevo salario base con incremento del 10%: {0:C}", empleado.SalarioBase);
                }//Fin del if
                
                Console.WriteLine("Ingresos {0:C}\n", empleadoActual.Ingresos());
            }//Fin del foreach
            
            //Obtiene el nombre del tipo de cada objeto en el arreglo de empleados
            for (int i = 0; i < empleados.Length; i++)
            {
                Console.WriteLine("Empleado {0} es un {1}", i, empleados[i].GetType());
            }
        }//Fin del main
    }//Fin de la clase PruebaSistemaNomina
}