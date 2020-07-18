using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8.DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите среднегодовую температуру:");

            string inputT = Console.ReadLine();
            float T = float.Parse(inputT.Replace(".", ","));

            Console.WriteLine("Введите среднее количество солнечных дней в месяц:");

            string inputSND = Console.ReadLine();
            int SND = int.Parse(inputSND);

            Console.WriteLine("Введите общее количество дней в году с осадками:");

            string inputPD = Console.ReadLine();
            int PD = int.Parse(inputPD);

            Console.WriteLine("Введите общее количество дней в году со слабым ветром (менее 5 м/с):");

            string inputLW = Console.ReadLine();
            int LW = int.Parse(inputLW);

            Console.WriteLine("Введите общее количество дней с температурой выше среднегодовой температуры:");

            string inputHT = Console.ReadLine();
            int HT = int.Parse(inputHT);

            Console.WriteLine("Введите общее количество дней с температурой ниже среднегодовой температуры:");

            string inputBT = Console.ReadLine();
            int BT = int.Parse(inputBT);

            Console.WriteLine("Введите месяц с самым большим количеством осадков:");

            string inputHP = Console.ReadLine();
            int HP = int.Parse(inputHP);

            Console.WriteLine("Введите самый безветренный месяц (в котором кол-во дней со слабым ветром минимально):");

            string inputNW = Console.ReadLine();
            int NW = int.Parse(inputNW);

            Console.Clear();

            Console.WriteLine(T);
            Console.WriteLine(SND);
            Console.WriteLine(PD);
            Console.WriteLine(LW);
            Console.WriteLine(HT);
            Console.WriteLine(BT);
            Console.WriteLine(HP);
            Console.WriteLine(NW);
        }
    }
}
