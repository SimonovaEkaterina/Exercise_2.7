//Импорт сторонних пространств имен
using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            string fulName = "Сокин Николай Евгеньевич";
            byte age = 27;                                           //Возраст
            string e_mail = "Kolya.27@mail.ru";
            double scoreMath = 75.30;                                //Баллы по математике
            double scoreProg = 83.20;                                //Баллы по программированию
            double scorePhys = 79.30;                                //Баллы по Физике
            double sumScore = scoreMath + scoreProg + scorePhys;     //Сумма
            double sumAver = sumScore / 3;                           //Среднее арифметическое


            WriteLine("Задание_2.7_1: ");
            WriteLine($"ФИО: {fulName}\nВозраст: {age}\ne-mail: {e_mail}\nБаллы по Программированию: {scoreProg}\nБаллы по Математике: {scoreMath}\nБаллы по Физике: {scorePhys}");
            
            ReadLine();

            WriteLine("Задание_2.7_2");
            ReadLine();
            // WriteLine($"Сумма всех баллов: {sumScore}\nСреднее арифметическое: {sumAver}");
            WriteLine($"Сумма всех чисел: {sumScore}");
            ReadLine();
            WriteLine($"Среднее арифметическое: {sumAver}");
            ReadLine();

        }
    }
}
