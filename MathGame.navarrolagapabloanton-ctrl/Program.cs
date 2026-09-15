/* 1. Necesitas crear un juego que consista en preguntar al jugador
 * cuál es el resultado de una pregunta de matemáticas (es decir,
 * 9x9 = ?), recoger la entrada y sumar un punto en caso de
 * respuesta correcta.
 * 
 * 2. Un juego necesita tener al menos 5 preguntas.
 * 
 * 3. Las divisiones deben resultar únicamente en ENTEROS y los
 * dividendos deben ir de 0 a 100. Ejemplo: Tu aplicación no debería 
 * presentar la división 7/2 al usuario, ya que no da lugar a un
 * entero.
 * 
 * 4. A los usuarios se les debe mostrar un menú para elegir una
 * operación.
 * 
 * 5. Deberías registrar partidas anteriores en una Lista y debería
 * haber una opción en el menú para que el usuario visualice el
 * historial de partidas anteriores.
 * 
 * 6. No necesitas registrar resultados en una base de datos. Una
 * vez cerrado el programa, los resultados se eliminarán.
 */

using System.Diagnostics.Metrics;

namespace MathGame.navarrolagapabloanton_ctrl
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            int points = 0;

            while(true)
            {
                Menu();

                string? keyboard = Console.ReadLine();

                switch(keyboard?.ToLower())
                {
                    case "a":
                        Console.Write("\n9 + 9 = ");

                        keyboard = Console.ReadLine();

                        int response;

                        while(!int.TryParse(keyboard, out response))
                        {
                            Console.WriteLine("\nError, enter an integer.");
                            keyboard = Console.ReadLine();
                        }

                        if (response == 9 + 9)
                        {
                            Console.WriteLine("\nYou got it! You earn 1 point!");
                            points++;
                        }
                        else
                        {
                            Console.WriteLine("\nYou're wrong! Incorrect!");
                        }

                        break;

                    case "exit":
                        Console.WriteLine($"\nYou earned {points} points.");
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

            Console.WriteLine("A). 9 + 9 = ?");
            Console.WriteLine("B). 20 - 3 = ?");
            Console.WriteLine("C). 91 * 4 = ?");
            Console.WriteLine("D). (10 + 1) * 2 = ?");
            Console.WriteLine("E). (77 / 7) - 3 * 2 = ?");

            Console.WriteLine("\nChoose one operation from A to E. Write EXIT to exit.");
        }
    }
}
