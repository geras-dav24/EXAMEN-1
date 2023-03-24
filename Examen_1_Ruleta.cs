using System;
using System.Collections.Generic;

namespace Ruleta
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int dinero = 300;
            int numTiradas = 0;
            int numMasFrecuente = 0;
            int numMenosFrecuente = 0;
            int numRojo = 0;
            int numNegro = 0;
            int numPar = 0;
            int numImpar = 0;
            Dictionary<int, int> frecuencias = new Dictionary<int, int>();
            bool salir = false;
            Random rnd = new Random();

            while (dinero > 0 && !salir)
            {
              
                Console.WriteLine("\nTienes ${0} para jugar. ¿Qué deseas hacer?", dinero);
                Console.WriteLine("1. Apostar a un número específico (multiplica tu apuesta por 10).");
                Console.WriteLine("2. Apostar a que el número es de color rojo o negro (multiplica tu apuesta por 5).");
                Console.WriteLine("3. Apostar a que el número es par o impar (multiplica tu apuesta por 2).");
                Console.WriteLine("4. Revisar historial de giros.");
                Console.WriteLine("5. Revisar estadísticas.");
                Console.WriteLine("6. Salir del juego.");

                
                int opcion = LeerEntero("Opción: ");

                switch (opcion)
                {
                    case 1:
                        
                        int numElegido = LeerEntero("Ingresa el número en el que deseas apostar (0-36): ");

                        if (numElegido >= 0 && numElegido <= 36)
                        {
                            int apuesta = LeerApuesta(dinero);
                            int resultado = rnd.Next(37);
                            numTiradas++;

                      
                            if (frecuencias.ContainsKey(resultado))
                            {
                                frecuencias[resultado]++;
                            }
                            else
                            {
                                frecuencias[resultado] = 1;
                            }

                            if (resultado == numElegido)
                            {
                                dinero += apuesta * 10;
                                Console.WriteLine("¡Felicidades! El número {0} salió. Ganaste ${1}.", resultado, apuesta * 10);
                            }
                            else
                            {
                                dinero -= apuesta;
                                Console.WriteLine("Lo siento, el número {0} salió. Perdiste ${1}.", resultado, apuesta);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Número inválido.");
                        }
                        break;

                    case 2:
                        
                        string colorElegido = LeerColor();

                        if (colorElegido == "rojo" || colorElegido == "negro")
                        {
                            int apuesta = LeerApuesta(dinero);
                            int resultado = rnd.Next(37);
                            numTiradas++;

                            if (frecuencias.ContainsKey(resultado))
                            {
                                frecuencias[resultado]++;
                            }
                            else
                            {
                                frecuencias[resultado] = 1;
                            }

                           if ((resultado % 2 == 0 && resultado != 0 && colorElegido == "Valor del color"))
{
    
}
                        }
                }
            }
        }
    }
}

