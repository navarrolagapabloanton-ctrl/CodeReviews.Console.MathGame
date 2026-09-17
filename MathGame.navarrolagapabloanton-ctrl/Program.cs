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
 * opción. ✅
 * 
 * 5. Deberías registrar partidas anteriores en una Lista y debería
 * haber una opción en el menú para que el usuario visualice el
 * historial de partidas anteriores. ✅
 * 
 * 6. No necesitas registrar resultados en una base de datos. Una
 * vez cerrado el programa, los resultados se eliminarán. ✅
 * 
 * **********************************************************************
 * 
 * - Intenta implementar niveles de dificultad. ✅
 * - Añade un temporizador para registrar cuánto tarda el
 * usuario en terminar el juego. ✅
 * - Crea una opción de 'Partida Aleatoria' donde los jugadores
 * tendrán preguntas de operaciones aleatorias. ✅
 * - Para seguir el principio DRY, prueba a usar un sólo
 * método para todos los juegos. Además, revisa tu proyecto y
 * busca oportunidades para lograr la misma funcionalidad con
 * menos código, evitando la repetición siempre que sea posible.
 */

using System.Diagnostics;

namespace MathGame.navarrolagapabloanton_ctrl
{
    internal class Program
    {
        public static int points = 0;

        public static Stopwatch stopwatch = new Stopwatch();

        public static List<int> easyPoints = new List<int>();
        public static List<int> mediumPoints = new List<int>();
        public static List<int> hardPoints = new List<int>();
        public static List<int> extremePoints = new List<int>();
        public static List<int> randomPoints = new List<int>();

        public static void Main(string[] args)
        {
            while (true)
            {
                Menu();

                string? keyboard = Console.ReadLine();

                switch (keyboard?.ToLower())
                {
                    case "a":
                        EasyLevel();
                        break;

                    case "b":
                        MediumLevel();
                        break;

                    case "c":
                        HardLevel();
                        break;

                    case "d":
                        ExtremeLevel();
                        break;

                    case "e":
                        RandomLevel();
                        break;

                    case "f":
                        ViewPoints();
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
            stopwatch.Start();

            points = 0;

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

            stopwatch.Stop();

            Console.WriteLine($"\nYou have obtained {points} points in total.");
            Console.WriteLine($"Time: {stopwatch.Elapsed:mm\\:ss}");

            easyPoints.Add(points);

            stopwatch.Reset();

            points = 0;
        }

        public static void MediumLevel()
        {
            stopwatch.Start();

            points = 0;

            Console.Write("\n45 + 7 / 7 = ");

            if (InputSolution() == 45 + 7 / 7)
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            Console.Write("\n10 - 4 * 3 * 1 = ");

            if (InputSolution() == 10 - 4 * 3 * 1)
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            Console.Write("\n5 * 3 / 3 * 3 = ");

            if (InputSolution() == 5 * 3 / 3 * 3)
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            Console.Write("\n9 - 9 * 0 + 1 / 1 = ");

            if (InputSolution() == 9 - 9 * 0 + 1 / 1)
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            Console.Write("\n(100 - 27 + 15) * (10 / 2) * 0 = ");

            if (InputSolution() == (100 - 27 + 15) * (10 / 2) * 0)
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            stopwatch.Stop();

            Console.WriteLine($"\nYou have obtained {points} points in total.");
            Console.WriteLine($"Time: {stopwatch.Elapsed:mm\\:ss}");

            mediumPoints.Add(points);

            stopwatch.Reset();

            points = 0;
        }

        public static void HardLevel()
        {
            stopwatch.Start();

            points = 0;

            Console.Write("\n23 - 55 + 6 = ");

            if (InputSolution() == 23 - 55 + 6)
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            Console.Write("\n14 - -2 * 3 = ");

            if (InputSolution() == 14 - -2 * 3)
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            Console.Write("\n33 + -16  + 2 - 45 + (3 / 1) = ");

            if (InputSolution() == 33 + -16 + 2 - 45 + (3 / 1))
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            Console.Write("\n4 / 2 * (3 - 7) + (80 + (5 * 3) - 2) = ");

            if (InputSolution() == 4 / 2 * (3 - 7) + (80 + (5 * 3) - 2))
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            Console.Write("\n(10 + (-9 + 3) * 3) / 2 = ");

            if (InputSolution() == (10 + (-9 + 3) * 3) / 2)
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            stopwatch.Stop();

            Console.WriteLine($"\nYou have obtained {points} points in total.");
            Console.WriteLine($"Time: {stopwatch.Elapsed:mm\\:ss}");

            hardPoints.Add(points);

            stopwatch.Reset();

            points = 0;
        }

        public static void ExtremeLevel()
        {
            stopwatch.Start();

            points = 0;

            Console.Write("\n-74 + 86 - -90 * 0 / 1 = ");

            if (InputSolution() == -74 + 86 - -90 * 0 / 1)
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            Console.Write("\n((56 + -18) - (43 - 59) + 24 / 3 * 11) - 50 = ");

            if (InputSolution() == ((56 + -18) - (43 - 59) + 24 / 3 * 11) - 50)
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            Console.Write("\n(20 - 36) / 8 * - 3 - 24 * -2 = ");

            if (InputSolution() == (20 - 36) / 8 * -3 - 24 * -2)
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            Console.Write("\n-1 + -2 - 1 - -3 + -2 + 1 - (0 - 3) - -27 * 4 = ");

            if (InputSolution() == -1 + -2 - 1 - -3 + -2 + 1 - (0 - 3) - -27 * 4)
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            Console.Write("\n133 -269 + (8 * 11 / 11 * (8 + 87 * 2)) * (-6 + -5 - (1 - 10 + (4 * 20) + 3) / 1) = ");

            if (InputSolution() == 133 - 269 + (8 * 11 / 11 * (8 + 87 * 2)) * (-6 + -5 - (1 - 10 + (4 * 20) + 3) / 1))
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            stopwatch.Stop();

            Console.WriteLine($"\nYou have obtained {points} points in total.");
            Console.WriteLine($"Time: {stopwatch.Elapsed:mm\\:ss}");

            extremePoints.Add(points);

            stopwatch.Reset();

            points = 0;
        }

        public static void RandomLevel()
        {
            stopwatch.Start();

            points = 0;

            Random random = new Random();

            int numberA = random.Next(0, 100);
            int numberB = random.Next(0, 100);

            Console.Write($"\n{numberA} + {numberB} = ");

            if (InputSolution() == numberA + numberB)
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            numberA = random.Next(0, 100);
            numberB = random.Next(0, 100);

            Console.Write($"\n{numberA} - {numberB} = ");

            if (InputSolution() == numberA - numberB)
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            numberA = random.Next(0, 100);
            numberB = random.Next(0, 100);

            Console.Write($"\n{numberA} * {numberB} = ");

            if (InputSolution() == numberA * numberB)
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            numberA = random.Next(0, 100);
            numberB = random.Next(1, 100);

            while (numberA < numberB)
            {
                numberA = random.Next(0, 100);
            }

            while (numberA % numberB != 0)
            {
                numberB = random.Next(1, 10);
            }

            Console.Write($"\n{numberA} / {numberB} = ");

            if (InputSolution() == numberA / numberB)
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            numberA = random.Next(0, 100);
            numberB = random.Next(0, 100);

            Console.Write($"\n({numberA} + {numberB}) - {numberB} * {numberA} = ");

            if (InputSolution() == (numberA + numberB) - numberB * numberA)
            {
                Console.WriteLine("\nYou got it! You earn 1 point!");
                points++;
            }
            else
            {
                Console.WriteLine("\nYou're wrong! Incorrect!");
            }

            stopwatch.Stop();

            Console.WriteLine($"\nYou have obtained {points} points in total.");
            Console.WriteLine($"Time: {stopwatch.Elapsed:mm\\:ss}");

            randomPoints.Add(points);

            stopwatch.Reset();

            points = 0;
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

        public static void ViewPoints()
        {
            Console.WriteLine($"\nEasy mode:");

            foreach (int points in easyPoints)
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
        }
    }
}
