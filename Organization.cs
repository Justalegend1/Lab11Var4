﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Var4
{
    public class Organization : IInit, ICloneable
    {
        protected string name;
        protected int number_of_employees;

        public Organization()
        {
            name = default;
            number_of_employees = 0;

        }
        public Organization(string Name1, int Number_of_employees)
        {
            name = Name1;
            number_of_employees = Number_of_employees;
        }
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public int Number_of_employees
        {
            get { return number_of_employees; }
            set
            {
                bool o = Int32.TryParse(Convert.ToString(value), out number_of_employees);
                while (!o)
                {
                    Console.WriteLine("Вы ввели не целое число, осуществите ввод заново");
                    o = Int32.TryParse(Console.ReadLine(), out number_of_employees);
                }
            }
        }
        public virtual void Show()
        {
            Console.WriteLine($"Кол-во сотрудников: {number_of_employees}, название организации: {name} ");
        }
        static Random rnd = new Random();
        public virtual object Init()
        {
            string[] name1 = new string[7] {"Техкомфорт", "Газпром", "Ваше право", "Рука Фемиды", "Кодекс чести", "Гармония здоровья", "Apple" };
            Organization k = new Organization(name1[rnd.Next(0, name1.Length - 1)], rnd.Next(1, 501));
            return k;
        }

        public virtual object Clone()
        {
            return new Organization { Name = this.Name, number_of_employees = this.number_of_employees };
        }

        public virtual object ClonePoverx()
        {
            return this.MemberwiseClone();
        }
        public override bool Equals(object obj)
        {
            if (obj is Organization)
                return this.Name == ((Organization)obj).Name && this.Number_of_employees == ((Organization)obj).Number_of_employees;
            else
                return false;
        }

    }
    //public void Show()
    //{
    //    Console.WriteLine($"Кол-во сотрудников: {number_of_employees}, название организации: {name} ");
    //}
    /*при компиляции происходит неопределенность, которыя вызвана одинаковым названием методов в разных классах и компилятор не знает, 
     * какой метод вызывать, поэтому без вирутального метода подобное работать не будет*/
}
