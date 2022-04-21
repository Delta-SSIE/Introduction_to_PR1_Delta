using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp72
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                // Цей рядок друкує Hello
                Console.WriteLine("Hallo");

                /* Багаторядковий 
                 коментар
                 */

                // ім'я змінної оголошення (name) ("Буде використано")
                // string name;

                // ініціалізація імені змінної (name) ("Я вставлю в неї значення в перший раз")
                // name = "Karel";

                //оголошення та ініціалізація одночасно
                //string name = "Vít";


                string name;

                Console.Write("What is your name: "); //запропонувати користувачеві ввести ім’я
                name = Console.ReadLine(); //чекає введення і повертає значення з клавіатури до змінної

                Console.WriteLine("Long live " + name + "!");
                Console.ReadKey(); // чекаємо натискання будь-якої клавіші
            }
        }
    }
}
