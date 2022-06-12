using System;
using GBStudyLib;

//1. Домашняя работа 3
//а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
//в) Добавить диалог с использованием switch демонстрирующий работу класса.

//2.
//а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.

//3. *Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.
//Добавить свойства типа int для доступа к числителю и знаменателю;
//Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа; **Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0"); ***Добавить упрощение дробей.

//   Студент Ким Алексей 
namespace Homework3
{
    
    //struct Complex
    //{
    //    public double im;
    //    public double re;

        
    //    public Complex Minus(Complex x)
    //    {
    //        Complex y;
    //        y.im = x.im - im;
    //        y.re = x.re - re;
    //        return y;
    //    }
        
       

    //    public string ToString()
    //    {
    //        return $"{re} + {im} * i";
    //    }
        
    //}

    // b)
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Домашнее задание 3";
            Console.WriteLine("Здравствуйте, Юзер!/nДобро пожаловать в меню выбора программ!");
            Console.WriteLine("//////////////////////////////////////////////////////////////");
            Console.WriteLine("Пожалуйста введите номер программы!");
            Console.WriteLine("//////////////////////////////////////////////////////////////");
            Console.WriteLine("1:Демонстрация вычитание комплексных чисел");
            Console.WriteLine("2:Демонстрация умножения комплексных чисел");
            Console.WriteLine("3:Программа подсчета нечетных положительных чисел (tryParse");




            Console.WriteLine("//////////////////////////////////////////////////////////////");

            string menuSwitch = (Console.ReadLine());
            bool result = int.TryParse(menuSwitch, out var number);
            if (result == true) 
            {
                switch (number)
                {
                    case 1:
                        Opt1();
                        break;
                    case 2:
                        Opt2();
                        break;
                    case 3:
                        SumOdd();
                        break;

                }
            }
            
                 else
                    Console.WriteLine($"Ошибка! Пожалуйста введите числовое значение!");
            
            

            
        static void Opt1()
            {
                Complex complex1 = new Complex();
                complex1.re = 3;
                complex1.im = 5;

                Complex complex2 = new Complex();
                complex2.re = 2;
                complex2.im = 3;
                Complex result = complex1.Minus(complex2);
                Console.WriteLine($"({complex1.re} + {complex1.im}*i) - ({complex2.re} + {complex2.im}*i) = {result.ToString()}");
                
            }
            
        static void Opt2()
            {
                Complex complex1 = new Complex();
                complex1.re = 3;
                complex1.im = 5;
             
                Complex complex2 = new Complex();
                complex2.re = 2;
                complex2.im = 3;
                Complex _result = complex1.Multi(complex2);
                Console.WriteLine($"({complex1.re} + {complex1.im}*i) * ({complex2.re} + {complex2.im}*i) = {_result.ToString()}");
                
            }    
            
        }

        static void SumOdd()
        {
            Console.Title = "3:Метод подсчета суммы всех нечетных положительных чисел";

            
            
            int checknum;
            bool checkbool;
            int sum = 0;
            



            static bool NotOdd(int x)
            {
                return x % 2 != 0;
            }


            do
            {
                Console.WriteLine("Пожалуйста введите число, введите 0 если хотите подсчитать сумму нечетных положительных чисел");
                string input = Console.ReadLine();
                bool result = int.TryParse(input, out int number);
                if (result == true && NotOdd(number) && number > 0)
                {

                    sum = sum + number;
                }
                
                else if (result == false)
                {
                    Console.WriteLine($"Ошибка ввода! Введите числовое значение");
                }

                checknum = number;
                checkbool = result;


            }

            while (checknum != 0 && checkbool == true);


            Console.WriteLine($"Сумма нечетных положительных чисел = {sum}.");
           


        }

    }

}
