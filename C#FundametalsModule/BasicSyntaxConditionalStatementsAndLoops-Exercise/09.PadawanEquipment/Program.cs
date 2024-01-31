using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            //The amount of money Ivan Cho has – floating - point number in range[0.00…1, 000.00]
            // The count of students – integer in range[0…100]
            // The price of lightsabers for a single sabre – floating - point number in range[0.00…100.00]
            // The price of robes for a single robe – floating - point number in range[0.00…100.00]
            // The price of belts for a single belt – floating - point number in range[0.00…100.00]
            double moneyHas = double.Parse(Console.ReadLine());
            int cntStudents = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            int lightSabersCnt = cntStudents + (int)Math.Ceiling(cntStudents * 0.1);
            double allSabersPrice = lightsaberPrice * lightSabersCnt;
            double allRobesPrice = robePrice * cntStudents;
            int beltsCnt = cntStudents - (cntStudents / 6);
            double allBeltsPrice = beltPrice * beltsCnt;

            double moneyEquipment = allSabersPrice + allRobesPrice + allBeltsPrice;

            if (moneyEquipment <= moneyHas)
            {
                Console.WriteLine($"The money is enough - it would cost {moneyEquipment:f2}lv.");
            }
            else
            {
                double moneyNeed = Math.Abs(moneyEquipment - moneyHas);
                Console.WriteLine($"John will need {moneyNeed:f2}lv more.");
            }
        }
    }
}
