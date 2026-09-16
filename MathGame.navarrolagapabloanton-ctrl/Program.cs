/* 1. Necesitas crear un juego que consista en preguntar al jugador
 * cuál es el resultado de una pregunta de matemáticas (es decir,
 * 9x9 = ?), recoger la entrada y sumar un punto en caso de
 * respuesta correcta. ✅
 * 
 * 2. Un juego necesita tener al menos 5 preguntas. ✅
 * 
 * 3. Las divisiones deben resultar únicamente en ENTEROS y los
 * dividendos deben ir de 0 a 100. Ejemplo: Tu aplicación no debería 
 * presentar la división 7/2 al usuario, ya que no da lugar a un
 * entero. ✅
 * 
 * 4. A los usuarios se les debe mostrar un menú para elegir una
 * operación. ✅
 * 
 * 5. Deberías registrar partidas anteriores en una Lista y debería
 * haber una opción en el menú para que el usuario visualice el
 * historial de partidas anteriores.
 * 
 * 6. No necesitas registrar resultados en una base de datos. Una
 * vez cerrado el programa, los resultados se eliminarán. ✅
 * 
 * **********************************************************************
 * 
 * - Intenta implementar niveles de dificultad.
 * - Añade un temporizador para registrar cuánto tarda el
 * usuario en terminar el juego.
 * - Crea una opción de 'Partida Aleatoria' donde los jugadores
 * tendrán preguntas de operaciones aleatorias.
 * - Para seguir el principio DRY, prueba a usar un sólo
 * método para todos los juegos. Además, revisa tu proyecto y
 * busca oportunidades para lograr la misma funcionalidad con
 * menos código, evitando la repetición siempre que sea posible.
 */

using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace MathGame.navarrolagapabloanton_ctrl
{
    internal class Program
    {
        public static int points = 0;

        public static List<int> easyPoints = new List<int>();
        public static List<int> mediumPoints = new List<int>();
        public static List<int> hardPoints = new List<int>();
        public static List<int> extremePoints = new List<int>();
        public static List<int> randomPoints = new List<int>();

        public static void Main(string[] args)
        {
            while(true)
            {
                Menu();

                string? keyboard = Console.ReadLine();

                switch(keyboard?.ToLower())
                {
                    case "a":
                        EasyLevel();
                        break;

                    case "b":
                        Question2();
                        break;

                    case "c":
                        Question3();
                        break;

                    case "d":
                        Question4();
                        break;

                    case "e":
                        Question5();
                        break;

                    case "f":
                        Console.WriteLine($"\nEasy mode:");

                        foreach(int points in easyPoints)
                        {
                            Console.Write($"{points} - ");
                        }

                        Console.WriteLine($"\nMedium mode:");

                        foreach (int points in mediumPoints)
                        {
                            Console.Write($"{points} - ");
                        }

                        Console.WriteLine($"\nHard mode:");

                        foreach (int points in hardPoints)
                        {
                            Console.Write($"{points} - ");
                        }

                        Console.WriteLine($"\nExtreme mode:");

                        foreach (int points in extremePoints)
                        {
                            Console.Write($"{points} - ");
                        }

                        Console.WriteLine($"\nRandom mode:");

                        foreach (int points in randomPoints)
                        {
                            Console.Write($"{points} - ");
                        }

                        break;


                    case "exit":
                        Console.WriteLine($"\nExit...");
                        return;

                    default:
                        Console.WriteLine("\nIncorrect option;" +
                            " choose an option from A to E.");
                        break;
                }
            }
        }

        public static void Menu()
        {
            Console.WriteLine("\nMATH GAME\n");

            Console.WriteLine("A). Easy.");
            Console.WriteLine("B). Medium.");
            Console.WriteLine("C). Hard.");
            Console.WriteLine("D). Extreme.");

            Console.WriteLine("\nE). Random operations.");

            Console.WriteLine("\nF). View your points.");

            Console.WriteLine("\n\nChoose one option from A to F. Write EXIT to exit..");
        }

        public static void EasyLevel()
        {
            Console.Write("\n9 + 9 = ");

            if (InputSolution() == 9 + 9)
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            Console.Write("\n20 - 3 = ");

            if (InputSolution() == 20 - 3)
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            Console.Write("\n91 * 4 = ");

            if (InputSolution() == 91 * 4)
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            Console.Write("\n(10 + 1) * 2 = ");

            if (InputSolution() == (10 + 1) * 2)
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            Console.Write("\n(77 / 7) - 3 * 2 = ");

            if (InputSolution() == (77 / 7) - 3 * 2)
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            Console.WriteLine($"\nYou have obtained {points} points in total.");
            easyPoints.Add(points);

            points = 0;
        }

        public static void Question2()
        {

        }

        public static void Question3()
        {

        }

        public static void Question4()
        {

        }

        public static void Question5()
        {

        }

        public static int InputSolution()
        {
            string? keyboard = Console.ReadLine();

            int response;

            while (!int.TryParse(keyboard, out response))
            {
                Console.WriteLine("\nError, enter an integer.");
                keyboard = Console.ReadLine();
            }

            return response;
        }
    }
}
