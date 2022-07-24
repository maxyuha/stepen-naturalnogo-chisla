using System;

namespace ConsolleApp
{
     class Program
     {
        static void Main(string[] args)
        {
            void Zadacha25()
            {//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
            
            Console.WriteLine("введите возводимое число");

            int number=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("введите степень");

            int number2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"число {number} в степени {number2} будет {Math.Pow(number,number2)}");
                
            }
            Zadacha25();
        }
        
        
     }
    
}