using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    public class Student
    {
        private string name;
        private int no;
        private double physics;
        private double programming;
        private double history;

        public string GetName() { return name; }
        public int GetNo() { return no; }
        public double GetPhysics() { return physics; }
        public double GetProgramming() { return programming; }
        public double GetHistory() { return history; }

        public double GetAverage() { return ((history + physics + programming) / 3); }

        public void SetName(string nm) { this.name = nm; }
        public bool SetNo(int num)
        {
            if (num > 0)
            {
                no = num;
                return true;

            }
            else
            {
                no = 0;
                return false;
            }
        }

        public bool SetPhysics(double p)
        {
            if (p > 0 && p < 6)
            {
                physics = p;
                return true;
            }
            else
            {
                physics = 0;
                Console.WriteLine("You have entered an incorrect estimate, please try again!");
                Console.WriteLine("=========================================================");
                return false;
            }
        }

        public bool SetProgramming(double pr)
        {
            if (pr > 0 && pr < 6)
            {
                programming = pr;
                return true;
            }
            else
            {
                programming = 0;
                Console.WriteLine("You have entered an incorrect estimate, please try again!");
                Console.WriteLine("=========================================================");
                return false;
            }
        }

        public bool SetHistory(double h)
        {
            if (h > 0 && h < 6)
            {
                history = h;
                return true;
            }
            else
            {
                history = 0;
                Console.WriteLine("You have entered an incorrect estimate, please try again!");
                Console.WriteLine("=========================================================");
                return false;
               
            }
        }



        public bool Init(string nm, int num, double p, double pr, double h)
        {
            SetName(nm);
            return SetNo(num) && SetPhysics(p) && SetProgramming(pr) && SetHistory(h);
        }
        public void Read()
        {
            string nm;
            int num;
            double p;
            double pr;
            double h;
            Console.WriteLine("Name: ");
            nm = Convert.ToString(Console.ReadLine());
            do
            {
                Console.WriteLine("Number: ");
                num = Convert.ToInt32(Console.ReadLine()); // Int32 - звичайний int
                Console.WriteLine("Physics: ");
                p = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Programming: ");
                pr = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("History: ");
                h = Convert.ToDouble(Console.ReadLine());


            } while (!Init(nm, num, p, pr, h));
        }



        public void Display()
        {
            Console.WriteLine("======================");
            Console.WriteLine($"Name: { name}");
            Console.WriteLine($"Number: {no}");
            Console.WriteLine($"Physics: { physics}");
            Console.WriteLine($"Programming: {programming}");
            Console.WriteLine($"History: {history}");
            Console.WriteLine("======================");


        }
    }
}