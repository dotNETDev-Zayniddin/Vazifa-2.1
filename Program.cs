using System;
using System.Runtime.InteropServices;
namespace Vazifa{
    class Program{
        static void Main(string[] args){
            System.Console.Write("Birinchi sonni kiriting: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ikkinchi sonni kiriting: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Amalni kiriting (+, -, *, /.): ");
            char amal = Convert.ToChar(Console.ReadLine());

            bool add = amal == '+';
            bool subtract = amal == '-';
            bool multiply = amal == '*';
            bool divide = amal == '/';

            int result = ((firstNumber+secondNumber)*Convert.ToInt32(add) + (firstNumber-secondNumber)*Convert.ToInt32(subtract)+(firstNumber*secondNumber)*Convert.ToInt32(multiply)+(firstNumber/secondNumber)*Convert.ToInt32(divide));
            Console.WriteLine($"Natija: {result}");



        }
    }
}