﻿using sesion2.Clases_;

namespace sesion2
{
    //Leer los datos de una persona y decir si es mayor o menor de edad.

    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            DateTime fechaNac;
            Persona persona=new Persona();

            Console.Write("dime tu nombre: ");
             nombre = (Console.ReadLine());
            Console.Write("En que fecha naciste: ");
                fechaNac = DateTime.Parse(Console.ReadLine());

            persona.Nombre = nombre;
            persona.FechaNac = fechaNac;
            Console.WriteLine(persona.EvaluarEdad());
        }
    }
}
