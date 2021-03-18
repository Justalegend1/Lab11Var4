﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Var4
{
    public class Shipbuilding_company : Organization
    {
        int number_of_ships;
        double average_income;
        string[] employee = new string[7] { "Смирнова", "Попов", "Новикова", "Федоров", "Морозов", "Волкова", "Лебедев" };
        int[] stage = new int[7] { 7, 15, 13, 16, 2, 5, 4 };
        public Shipbuilding_company(string n, int a, double average, int ships) : base(n, a)
        {
            Average_income = average;
            Number_of_Ships = ships;

        }
        public Shipbuilding_company() : base()
        { }
        public double Average_income
        {
            get { return average_income; }
            set
            {
                bool o = (Double.TryParse(Convert.ToString(value), out average_income));
                while ((!o) | (average_income < 0))
                {
                    Console.WriteLine("Введите корректное значение дохода");
                    o = Double.TryParse(Console.ReadLine(), out average_income);
                }
            }
        }
        public int Number_of_Ships
        {
            get { return number_of_ships; }
            set
            {
                bool o = (Int32.TryParse(Convert.ToString(value), out number_of_ships));
                while ((!o) | (number_of_ships < 0))
                {
                    Console.WriteLine("Введите целое кол-во кораблей");
                    o = (Int32.TryParse(Console.ReadLine(), out number_of_ships));
                }
            }
        }
        public override void Show()
        {
            base.Show();
            if (number_of_ships >= 5)
                Console.WriteLine($"Средний доход фирмы: {average_income}, и на счету фирмы уже {number_of_ships} созданных кораблей");
            else
                Console.WriteLine($"Средний доход фирмы: {average_income}, и на счету фирмы уже {number_of_ships} созданных корабля");
        }
        //public void Show()
        //{
        //    if (number_of_ships >= 5)
        //        Console.WriteLine($"Средний доход фирмы: {average_income}, и на счету фирмы уже {number_of_ships} созданных кораблей");
        //    else
        //        Console.WriteLine($"Средний доход фирмы: {average_income}, и на счету фирмы уже {number_of_ships} созданных корабля");
        //}
        public void ShowStage(int po)
        {
            int count = 0;
            for (int y = 0; y < stage.Length; y++)
            {
                Console.WriteLine($"{employee[y]} - работает {stage[y]} лет ");
            }
            Console.WriteLine($"Эти люди работают в {name} не менее шести лет");
            for (int t = 0; t < stage.Length; t++)
            {
                if (stage[t] >= po)
                {
                    Console.WriteLine(employee[t]);
                    count++;
                }
            }
            if (count == 0)
                Console.WriteLine("Такого работника нет");
        }
        static Random rnd = new Random();
        public override object Init()
        {
            Organization o = (Organization)base.Init();
            Shipbuilding_company s = new Shipbuilding_company(o.Name, o.Number_of_employees, rnd.NextDouble() * 1000000, rnd.Next(0, 101));
            return s;
        }
        public override object Clone()
        {
            return new Shipbuilding_company { Name = this.Name, Number_of_employees = this.Number_of_employees, Average_income = this.Average_income, Number_of_Ships = this.Number_of_Ships };
        }
        public override object ClonePoverx()
        {
            return this.MemberwiseClone();
        }
        public override bool Equals(object obj)
        {
            if (obj is Shipbuilding_company)
                return base.Equals(obj) && this.Number_of_Ships == ((Shipbuilding_company)obj).Number_of_Ships && this.Average_income == ((Shipbuilding_company)obj).Average_income;
            else
                return false;
        }
    }
}