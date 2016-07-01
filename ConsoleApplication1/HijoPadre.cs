using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class HijoPadre
    {
        static void Main(string[] args)
        {
            Padres Persona_1 = new Padres();
            Persona_1.Nombre = "Johanna";
            Persona_1.Apellido = "Forero";         

            Hijo hijo_1 = new Hijo();
            hijo_1.Nombre = "Danna";

            Hijo hijo_2 = new Hijo();
            hijo_2.Nombre = "Valerie";

            hijo_1.Mama = Persona_1;
            hijo_2.Mama = Persona_1;


            Console.WriteLine("La Mamá de Hijo_ 1 y Hijo_2 es " + hijo_1.Mama.Nombre);
            Console.WriteLine(hijo_1.Nombre + " y " + hijo_2.Nombre + " son hijas de " + Persona_1.Nombre);

            Padres Persona_2 = new Padres();
            Persona_2.Nombre = "Rosa";
            Persona_2.Apellido = "Huertas";

            Padres Persona_3 = new Padres();
            Persona_3.Nombre = "Paul";
            Persona_3.Apellido = "Angulo";

            Hijo hijo_3 = new Hijo();
            hijo_3.Nombre = "Leidy";
            hijo_3.Apellido = "Forero";

            Hijo hijo_4 = new Hijo();
            hijo_4.Nombre = "Johanna";
            hijo_4.Apellido = "Forero";

            Hijo hijo_5 = new Hijo();
            hijo_5.Nombre = "Nicolas";
            hijo_5.Apellido = "Angulo";

            Hijo hijo_6 = new Hijo();
            hijo_6.Nombre = "Kevin";
            hijo_6.Apellido = "Angulo";

            hijo_3.Mama = Persona_2;
            hijo_4.Mama = Persona_2;

            hijo_5.Mama = Persona_2;
            hijo_6.Papa = Persona_3;
            hijo_5.Mama = Persona_2;
            hijo_6.Papa = Persona_3;


            Console.WriteLine("La Mamá de " + hijo_3.Nombre + " y " + hijo_4.Nombre + " es " + Persona_2.Nombre);
            Console.WriteLine(hijo_3.Nombre + " y " + hijo_4.Nombre + " son hijas de " + Persona_2.Nombre);

            Console.WriteLine("los papas de " + hijo_5.Nombre + " y " + hijo_6.Nombre + " son " + Persona_2.Nombre + " y " + Persona_3.Nombre);
            Console.WriteLine(hijo_5.Nombre + " y " + hijo_6.Nombre + " son hijos de " + Persona_2.Nombre + " y " + Persona_3.Nombre);

            Console.Read();
        }
    }
}
