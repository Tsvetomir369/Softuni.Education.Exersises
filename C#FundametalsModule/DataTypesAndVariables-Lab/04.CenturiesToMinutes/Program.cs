using System;

namespace _04.CenturiesToMinutes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(centuries * 100);
            int days = (int)(years * 365.2422);
            uint hours = (uint)(24 * days);
            ulong minutes = (ulong)(60 * hours);
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
