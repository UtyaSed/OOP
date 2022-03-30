using System;


namespace Lab_3._2
{
    class Program
    {

        enum Specialty { KN, IT, MathAndEconomic, PhysicsandAndIT, TrudoveNavchany };
        static string[] SpecialtyStr = { "Комп’ютерні науки", "Інформатика", "Математика та економіка", "Фізика та інформатика", "Трудове навчання" };

        struct Student
        {
            public string prizv;
            public int kurs;
            public Specialty specialty;
            public int Phisic;
            public int Math;
            public int IT;
            public float avg;

        }
        static void Create(Student[] p)
        {
            int specialty;

            for (int i = 0; i < p.Length; i++)
            {

                Console.WriteLine("Студент № {0}:", i + 1);
                Console.Write(" Прізвище: ");
                p[i].prizv = Console.ReadLine();
                Console.Write("  Курс: "); p[i].kurs = Convert.ToInt32(Console.ReadLine());
                Console.Write("  Спеціальність (0 - Комп’ютерні науки, 1 - Інформатика, 2 - Математика та економіка, 3 - Фізика та інформатика, 4 - Трудове навчання): ");
                specialty = Convert.ToInt32(Console.ReadLine());
                p[i].specialty = (Specialty)specialty;
                Console.Write("  Оцінка з Фізики: "); p[i].Phisic = Convert.ToInt32(Console.ReadLine());
                Console.Write("  Оцінка з Математики: "); p[i].Math = Convert.ToInt32(Console.ReadLine());
                Console.Write("  Оцінка з Інформатики: "); p[i].IT = Convert.ToInt32(Console.ReadLine());

            }
        }
        static void Print(Student[] p)
        {
            Console.WriteLine("=====================================================================================================================");
            Console.WriteLine("                                        Список студентів");
            Console.WriteLine("=====================================================================================================================");

            Console.WriteLine("|  № |   Прізвище   | Курс |      Спеціальність      | Оцінка з Фізики | Оцінка з Математики | Оцінка з Інформатики |");

            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine("|{0,3} | {1,-13}|  {2,2}  | {3,-23} |{4,8}         |{5,11}          |{5,11}           |", i + 1, p[i].prizv, p[i].kurs, SpecialtyStr[(int)p[i].specialty], p[i].Phisic, p[i].Math, p[i].IT);
            }
            Console.WriteLine("=====================================================================================================================");

        }
        static double PercentageOfPhysic5(Student[] p)
        {
            double P_of_S = 0;

            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].Phisic == 4 || p[i].Phisic == 5)
                    P_of_S += 1;
            }

            P_of_S = (P_of_S / p.Length) * 100;

            return P_of_S;
        }

        static void Print_Students_Prizv_Seredni_Bal(Student[] p)
        {
            Console.WriteLine("Прізвища і середній бал студента: ");
            for (int i = 0; i < p.Length; i++)
            {
                p[i].avg = 0;
            }
                for (int i = 0; i < p.Length; i++)
                {
                    p[i].avg += (p[i].IT + p[i].Math + p[i].Phisic) / 3;
                    Console.WriteLine($"|{i + 1}|{p[i].prizv,12}|{p[i].avg,10}");
            }
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int N;

            Console.Write("Введіть кількість студентів = ");
            N = Convert.ToInt32(Console.ReadLine());


            Student[] p = new Student[N];
            Create(p);
            Print(p);
            Console.WriteLine();
            Console.WriteLine($"Процент студентів, які отримали з фізики оцінки '5' або '4'. = {Math.Round(PercentageOfPhysic5(p), 2)} % ");
            Console.WriteLine();
            Print_Students_Prizv_Seredni_Bal(p);





            Console.ReadKey();

        }


    }
}