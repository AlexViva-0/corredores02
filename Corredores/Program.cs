using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Corredores
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("¡Carrera de hilos!");

            // Crear cinco corredores (tú preparas 3 adicionales)
            Thread corredorA = new Thread(Correr);
            Thread corredorB = new Thread(Correr);
            Thread corredorC = new Thread(Correr);  // Nuevo
            Thread corredorD = new Thread(Correr);  // Nuevo
            Thread corredorE = new Thread(Correr);  // Nuevo

            // Iniciar todos los corredores
            corredorA.Start("Corredor A");
            corredorB.Start("Corredor B");
            corredorC.Start("Corredor C");  // Nuevo
            corredorD.Start("Corredor D");  // Nuevo
            corredorE.Start("Corredor E");  // Nuevo

            // Esperar a que todos terminen
            corredorA.Join();
            corredorB.Join();
            corredorC.Join();  // Nuevo
            corredorD.Join();  // Nuevo
            corredorE.Join();  // Nuevo

            Console.WriteLine("¡Carrera terminada!");
        }

        // (El método Correr se mantiene igual)
        static void Correr(object nombre)
        {
            Random rnd = new Random();
            for (int pasos = 1; pasos <= 10; pasos++)
            {
                Console.WriteLine($"{nombre} avanzó a la posición: {pasos}");
                Thread.Sleep(rnd.Next(100, 500));
            }
            Console.WriteLine($"🏁 {nombre} terminó la carrera!");
        }
    }
}