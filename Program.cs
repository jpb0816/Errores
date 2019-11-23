using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Errores
{
    class Program
    {
        public static object Util { get; private set; }

        static void Main(string[] args)
        {
            var estudiantes = new List<Estudiante>();
            var agregar = true;
            while (agregar)
            {
                try
                {
                    var e = new Estudiante();
                    var Ncontrol = e.Matricula;
                    int matricula1 = 0;
                    //se crea un bool para evaluar una condicion true o false
                    //en el que se evalua una variable int 
                    Console.WriteLine("Ingrese matricula: ");
                    bool result = int.TryParse(Console.ReadLine(), out matricula1);
                    Console.WriteLine("Ingrese nombre del alumno: ");
                    e.Nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese carrera: ");
                    e.Carrera = Console.ReadLine();
                    Console.WriteLine("Ingrese semestre: ");
                    e.Semestre = Convert.ToInt32(Console.ReadLine());

                    estudiantes.Add(e);

                   

                    //Se evaluara si se escribe datos string en una variable int y se desplegara un mensaje
                    if (result == false)
                    {
                        Console.WriteLine("Ingrese un numero ");
                    }

                    Console.WriteLine("Desea agregar otro usuario?:  y/n ");
                    if (Console.ReadLine() == "n")
                    {
                        agregar = false;
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine("Error agregando usuario , intente nuevamente \n");
                }
                
               
            }

            Console.ReadKey();
        }
    }
}
