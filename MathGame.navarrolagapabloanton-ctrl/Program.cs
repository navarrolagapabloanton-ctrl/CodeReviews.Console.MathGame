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

        public static List<int> additionPoints = new List<int>();
        public static List<int> subtractionPoints = new List<int>();
        public static List<int> multiplicationPoints = new List<int>();
        public static List<int> divisionPoints = new List<int>();
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
                        AdditionGame();
                        break;

                    case "b":
                        SubtractionGame();
                        break;

                    case "c":
                        MultiplicationGame();
                        break;

                    case "d":
                        DivisionGame();
                        break;

                    case "e":
                        RandomGame();
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

            Console.WriteLine("A). Addition operations.");
            Console.WriteLine("B). Subtraction operations.");
            Console.WriteLine("C). Multiplication operations.");
            Console.WriteLine("D). Division operations.");

            Console.WriteLine("\nE). Random operations.");

            Console.WriteLine("\nF). View your points.");

            Console.WriteLine("\n\nChoose one option from A to F. Write EXIT to exit..");
        }

        public static void AdditionGame()
        {
            stopwatch.Start();

            points = 0;

            for (int i = 0; i < 5; i++)
            {
                int numberA = RandomNum(0);
                int numberB = RandomNum(0);

                Console.Write($"\n{i + 1}. {numberA} + {numberB} = ");

                if (CheckingSum(numberA, numberB, InputSolution()))
                {
                    Console.WriteLine("\nGreat! You have obtained 1 point!");
                    points++;
                }
                else
                {
                    Console.WriteLine("\nYou're wrong! Incorrect solution.");
                }
            }

            stopwatch.Stop();

            Console.WriteLine($"\nYou have obtained {points} points in total.");
            Console.WriteLine($"Time: {stopwatch.Elapsed:mm\\:ss}");

            additionPoints.Add(points);

            stopwatch.Reset();

            points = 0;

        }

        public static void SubtractionGame()
        {
            stopwatch.Start();

            points = 0;

            for (int i = 0; i < 5; i++)
            {
                int numberA = RandomNum(0);
                int numberB = RandomNum(0);

                Console.Write($"\n{i + 1}. {numberA} - {numberB} = ");

                if (CheckingSubstraction(numberA, numberB, InputSolution()))
                {
                    Console.WriteLine("\nGreat! You have obtained 1 point!");
                    points++;
                }
                else
                {
                    Console.WriteLine("\nYou're wrong! Incorrect solution.");
                }
            }

            stopwatch.Stop();

            Console.WriteLine($"\nYou have obtained {points} points in total.");
            Console.WriteLine($"Time: {stopwatch.Elapsed:mm\\:ss}");

            subtractionPoints.Add(points);

            stopwatch.Reset();

            points = 0;
        }

        public static void MultiplicationGame()
        {
            stopwatch.Start();

            points = 0;

            for (int i = 0; i < 5; i++)
            {
                int numberA = RandomNum(0);
                int numberB = RandomNum(0);

                Console.Write($"\n{i + 1}. {numberA} * {numberB} = ");

                if (CheckingMultiplication(numberA, numberB, InputSolution()))
                {
                    Console.WriteLine("\nGreat! You have obtained 1 point!");
                    points++;
                }
                else
                {
                    Console.WriteLine("\nYou're wrong! Incorrect solution.");
                }
            }

            stopwatch.Stop();

            Console.WriteLine($"\nYou have obtained {points} points in total.");
            Console.WriteLine($"Time: {stopwatch.Elapsed:mm\\:ss}");

            multiplicationPoints.Add(points);

            stopwatch.Reset();

            points = 0;
        }

        public static void DivisionGame()
        {
            stopwatch.Start();

            points = 0;

            for (int i = 0; i < 5; i++)
            {
                int numberA = RandomNum(0);
                int numberB = RandomNum(0);

                while (numberA < numberB)
                {
                    numberA = RandomNum(0);
                }

                while (numberA % numberB != 0)
                {
                    numberB = RandomNum(0) + 1;
                }

                Console.Write($"\n{i + 1}. {numberA} / {numberB} = ");

                if (CheckingDivision(numberA, numberB, InputSolution()))
                {
                    Console.WriteLine("\nGreat! You have obtained 1 point!");
                    points++;
                }
                else
                {
                    Console.WriteLine("\nYou're wrong! Incorrect solution.");
                }
            }

            stopwatch.Stop();

            Console.WriteLine($"\nYou have obtained {points} points in total.");
            Console.WriteLine($"Time: {stopwatch.Elapsed:mm\\:ss}");

            divisionPoints.Add(points);

            stopwatch.Reset();

            points = 0;
        }

        public static void RandomGame()
        {
            stopwatch.Start();

            points = 0;

            stopwatch.Start();

            points = 0;

            for (int i = 0; i < 5; i++)
            {
                int numberA = RandomNum(0);
                int numberB = RandomNum(0);

                int randomOperation = RandomNum(0); // 0-25 (Addition), 25-50 (Substraction), 50-75 (Multiplication) and 75-100 (Division).

                if (randomOperation <= 25)
                {
                    Console.Write($"\n{i + 1}. {numberA} + {numberB} = ");

                    if (CheckingSum(numberA, numberB, InputSolution()))
                    {
                        Console.WriteLine("\nGreat! You have obtained 1 point!");
                        points++;
                    }
                    else
                    {
                        Console.WriteLine("\nYou're wrong! Incorrect solution.");
                    }
                }
                else if (randomOperation > 25 && randomOperation <= 50)
                {
                    Console.Write($"\n{i + 1}. {numberA} - {numberB} = ");

                    if (CheckingSubstraction(numberA, numberB, InputSolution()))
                    {
                        Console.WriteLine("\nGreat! You have obtained 1 point!");
                        points++;
                    }
                    else
                    {
                        Console.WriteLine("\nYou're wrong! Incorrect solution.");
                    }
                }
                else if (randomOperation > 50 && randomOperation <= 75)
                {
                    Console.Write($"\n{i + 1}. {numberA} * {numberB} = ");

                    if (CheckingMultiplication(numberA, numberB, InputSolution()))
                    {
                        Console.WriteLine("\nGreat! You have obtained 1 point!");
                        points++;
                    }
                    else
                    {
                        Console.WriteLine("\nYou're wrong! Incorrect solution.");
                    }
                }
                else
                {
                    while (numberA < numberB)
                    {
                        numberA = RandomNum(0);
                    }

                    while (numberA % numberB != 0)
                    {
                        numberB = RandomNum(0) + 1;
                    }

                    Console.Write($"\n{i + 1}. {numberA} / {numberB} = ");

                    if (CheckingDivision(numberA, numberB, InputSolution()))
                    {
                        Console.WriteLine("\nGreat! You have obtained 1 point!");
                        points++;
                    }
                    else
                    {
                        Console.WriteLine("\nYou're wrong! Incorrect solution.");
                    }
                }
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

        public static int RandomNum(int num)
        {
            Random random = new Random();

            return random.Next(0, 100);
        }

        public static bool CheckingSum(int num1, int num2, int result)
        {
            return num1 + num2 == result;
        }

        public static bool CheckingSubstraction(int num1, int num2, int result)
        {
            return num1 - num2 == result;
        }

        public static bool CheckingMultiplication(int num1, int num2, int result)
        {
            return num1 * num2 == result;
        }

        public static bool CheckingDivision(int num1, int num2, int result)
        {
            return num1 / num2 == result;
        }

        public static void ViewPoints()
        {
            Console.WriteLine($"\nAdditions option:");

            foreach (int points in additionPoints)
            {
                Console.Write($"{points} - ");
            }

            Console.WriteLine($"\nSubtractions option:");

            foreach (int points in subtractionPoints)
            {
                Console.Write($"{points} - ");
            }

            Console.WriteLine($"\nMultiplications options:");

            foreach (int points in multiplicationPoints)
            {
                Console.Write($"{points} - ");
            }

            Console.WriteLine($"\nDivisions option:");

            foreach (int points in divisionPoints)
            {
                Console.Write($"{points} - ");
            }

            Console.WriteLine($"\nRandom option:");

            foreach (int points in randomPoints)
            {
                Console.Write($"{points} - ");
            }
        }
    }
}
