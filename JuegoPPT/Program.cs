using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
using System.Threading.Tasks;

namespace JuegoPiedraPapelTijera
{
    class Programa
    {
        static void Main(string[] args)
        {
            string opcionJugador, opcionPC;
            int randomInt;

            bool jugarDeNuevo = true;

            Console.Write("-----------------JUEGO DE PIEDRA PAPEL O TIJERA-----------------");

            while (jugarDeNuevo)
            {

                int puntajeJugador = 0;
                int puntajePC = 0;

                while (puntajeJugador < 3 && puntajePC < 3 )
                {

                    Console.Write("\nELIGE UNA OPCION PIEDRA, PAPEL O TIJERA:    ");
                    opcionJugador = Console.ReadLine();
                    opcionJugador = opcionJugador.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            opcionPC = "PIEDRA";
                            Console.WriteLine("EL SISTEMA ELIGIÓ PIEDRA");
                            if (opcionJugador == "PIEDRA")
                            {
                                Console.WriteLine("EMPATE\n");
                            }
                            else if (opcionJugador == "PAPEL")
                            {
                                Console.WriteLine("GANASTE!\n");
                                puntajeJugador++;
                            }
                            else if (opcionJugador == "TIJERA")
                            {
                                Console.WriteLine("EL SISTEMA GANÓ!\n");
                                puntajePC++;
                            }
                            break;
                        case 2:
                            opcionPC = "PAPEL";
                            Console.WriteLine("EL SISTEMA ELIGIÓ PAPEL");
                            if (opcionJugador == "PAPEL")
                            {
                                Console.WriteLine("EMPATE\n");
                            }
                            else if (opcionJugador == "PIEDRA")
                            {
                                Console.WriteLine("EL SISTEMA GANÓ!\n");
                                puntajePC++;
                            }
                            else if (opcionJugador == "TIJERA")
                            {
                                Console.WriteLine("GANASTE!\n");
                                puntajeJugador++;
                            }
                            break;
                        case 3:
                            opcionPC = "TIJERA";
                            Console.WriteLine("EL SISTEMA ELIGIÓ TIJERA");
                            if (opcionJugador == "TIJERA")
                            {
                                Console.WriteLine("EMPATE\n");
                            }
                            else if (opcionJugador == "PIEDRA")
                            {
                                Console.WriteLine("GANASTE!\n");
                                puntajeJugador++;
                            }
                            else if (opcionJugador == "PAPEL")
                            {
                                Console.WriteLine("EL SISTEMA GANÓ!\n\n");
                                puntajePC++;
                            }
                            break;
                        default:
                            Console.WriteLine("INGRESA UNA OPCIÓN VÁLIDA");
                            break;
                    }

                    Console.WriteLine("\n\nPUNTAJES |\tJUGADOR:\t{0}| \tSISTEMA:\t{1}|", puntajeJugador, puntajePC);

                }

                if (puntajeJugador == 3)
                {
                    Console.WriteLine("GANASTE!");
                }
                else if (puntajePC == 3)
                {
                    Console.WriteLine("EL SISTEMA GANÓ!");
                }
                else
                {

                }

                Console.WriteLine("DESEAR REINICIAR?(s/n)");
                string loop = Console.ReadLine();
                if (loop == "s")
                {
                    jugarDeNuevo = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    jugarDeNuevo = false;
                }
                else
                {

                }

            }
        }
    }
}