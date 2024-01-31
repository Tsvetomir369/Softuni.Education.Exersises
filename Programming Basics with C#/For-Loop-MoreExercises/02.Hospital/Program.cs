using System;

namespace _02.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int doctors = 7;
            int treated = 0;
            int untreated = 0;
            int period = int.Parse(Console.ReadLine());
            for (int i = 1; i <= period; i++)
            {
                if (i % 3 == 0)
                {
                    if (untreated > treated)
                    {
                        doctors++;
                    }
                }
                int treatedPatients = 0;
                int untreatedPatients = 0;
                int cntPatients = int.Parse(Console.ReadLine());

                if (cntPatients < doctors)
                {
                    treatedPatients = cntPatients;
                    untreatedPatients = 0;
                }
                else
                {
                    treatedPatients = doctors;
                    untreatedPatients = cntPatients - treatedPatients;
                }
                treated += treatedPatients;
                untreated += untreatedPatients;
            }

            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");
        }
    }
}
