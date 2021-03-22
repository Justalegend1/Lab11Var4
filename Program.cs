using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Lab11Var4
{
    public class Program
    {
        static void Main(string[] args)
        {
            int Check(string n)
            {
                int n1 = 0;
                bool o = Int32.TryParse(n, out n1);
                while (!o)
                {
                    Console.WriteLine("Мне кажется, ты что-то перепутал, осуществите ввод заново");
                    o = Int32.TryParse(Console.ReadLine(), out n1);
                }
                while (n1 < 0)
                {
                    Console.WriteLine("Введите положительное значение");
                    o = Int32.TryParse(Console.ReadLine(), out n1);
                }
                return Convert.ToInt32(n1);
            }
            Factory Fac = new Factory("Фабрика", 350, 20, "Лондон");
            Insurance_Company Ins = new Insurance_Company("Страховая компания", 270, 1990, 96);
            Library Lib = new Library("Библиотека", 50, 8, 700);
            Shipbuilding_company Ship = new Shipbuilding_company("Кораблестроительная компания", 200, 900000, 45);
            Organization Org = new Organization("Организация", 290);
            Console.WriteLine("Выберите следующее действие:\n1-добавление элемента в список\n2-удаление элемента из списка");
            int Select = Check(Console.ReadLine());
            while ((Select>2) || (Select<1))
            {
                Console.WriteLine("Введите 1 или 2");
                Select = Check(Console.ReadLine());
            }
            SortedList<int,Organization> list = new SortedList<int, Organization>();
            list.Add(1,Fac);
            list.Add(2,Ins);
            list.Add(3,Lib);
            list.Add(4,Ship);
            list.Add(5,Org);
            Console.WriteLine("Исходная коллекция");
            Show();
            switch (Select)
            {
                case 1:
                    Console.WriteLine("Выберите класс, который хотите добавить в коллекцию\n1-Organization\n2-Insurance_Company\n3-Library\n4-Factory\n5-Shipbuilding_company");
                    int Select1 = Check(Console.ReadLine());
                    while (Select1 > 5 || Select1 < 1)
                    {
                        Console.WriteLine("Введите цифру от 1 до 5");
                        Select1 = Check(Console.ReadLine());
                    }
                    switch (Select1)
                    {
                        case 1:
                            Organization New_Org = new Organization();
                            New_Org = (Organization)New_Org.Init();
                            list.Add(6,New_Org);
                            break;
                        case 2:
                            Insurance_Company New_Ins = new Insurance_Company();
                            New_Ins = (Insurance_Company)New_Ins.Init();
                            list.Add(6,New_Ins);
                            break;
                        case 3:
                            Library New_Lib = new Library();
                            New_Lib = (Library)New_Lib.Init();
                            New_Lib.Working_Hours = 8;
                            list.Add(6,New_Lib);
                            break;
                        case 4:
                            Factory New_Fac = new Factory();
                            New_Fac = (Factory)New_Fac.Init();
                            list.Add(6,New_Fac);
                            break;
                        case 5:
                            Shipbuilding_company New_Ship = new Shipbuilding_company();
                            New_Ship = (Shipbuilding_company)New_Ship.Init();
                            list.Add(6,New_Ship);
                            break;
                    }
                    Show();
                    break;
                case 2:
                    Console.WriteLine("Выберите элемент, который хотите удалить из коллекции\n1-Factory\n2-Insurance_Company\n3-Library\n4-Shipbuilding_company\n5-Organization");
                    int Select2 = Check(Console.ReadLine());
                    while (Select2 > 5 || Select2 < 1)
                    {
                        Console.WriteLine("Введите цифру от 1 до 5");
                        Select2 = Check(Console.ReadLine());
                    }
                        switch (Select2)
                        {
                            case 1:
                                list.RemoveAt(0);
                            break;
                            case 2:
                                list.RemoveAt(1);
                                break;
                            case 3:
                                list.RemoveAt(2);
                                break;
                            case 4:
                                list.RemoveAt(3);
                                break;
                            case 5:
                                list.RemoveAt(4);
                                break;
                        }
                        Show();
                    break;
            
            }
            Console.ReadKey();
            void Show()
            {
                ICollection<int> keys = list.Keys;
                foreach (var v in keys)
                    list[v].Show();
            }
            Console.Clear();
            Console.WriteLine("Выберите запрос, который хотите осуществить\n1-Количество элементов определенного типа\n2-Печать элементов определенного типа\n3-Индексы элементов определенного типа");
            int Select_3_Subt = Check(Console.ReadLine());
            while ((Select_3_Subt < 1) || (Select_3_Subt > 3))
            {
                Console.WriteLine("Введите цифру от 1 до 3");
                Select_3_Subt = Check(Console.ReadLine());
            }
            switch (Select_3_Subt)
            {
                case 1:
                    Console.WriteLine("Какой тип элементов вы хотите посчитать?\n1-Factory\n2-Insurance_Company\n3-Library\n4-Shipbuilding_company\n5-Organization");
                    int Select_3_Subt1 = Check(Console.ReadLine());
                    while (Select_3_Subt1 < 1 || Select_3_Subt1 > 5)
                    {
                        Console.WriteLine("Введите цифру от 1 до 5");
                        Select_3_Subt1 = Check(Console.ReadLine());
                    }
                    ICollection<int> Keys1 = list.Keys;
                    switch (Select_3_Subt1)
                    {
                        case 1:
                            int count = 0;
                            foreach (var t1 in Keys1)
                                if (list[t1].GetType() == Fac.GetType())
                                    count++;
                            Console.WriteLine($"Количество элементов данного типа: {count}");
                            break;
                        case 2:
                            int count1 = 0;
                            foreach (var t1 in Keys1)
                                if (list[t1].GetType() == Ins.GetType())
                                    count1++;
                            Console.WriteLine($"Количество элементов данного типа: {count1}");
                            break;
                        case 3:
                            int count2 = 0;
                            foreach (var t1 in Keys1)
                                if (list[t1].GetType() == Lib.GetType())
                                    count2++;
                            Console.WriteLine($"Количество элементов данного типа: {count2}");
                            break;
                        case 4:
                            int count3 = 0;
                            foreach (var t1 in Keys1)
                                if (list[t1].GetType() == Ship.GetType())
                                    count3++;
                            Console.WriteLine($"Количество элементов данного типа: {count3}");
                            break;
                        case 5:
                            int count4 = 0;
                            foreach (var t1 in Keys1)
                                if (list[t1].GetType() == Org.GetType())
                                    count4++;
                            Console.WriteLine($"Количество элементов данного типа: {count4}");
                            break;
                    }
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Какой тип элементов вы хотите вывести?\n1-Factory\n2-Insurance_Company\n3-Library\n4-Shipbuilding_company\n5-Organization");
                    int Select_3_Subt2 = Check(Console.ReadLine());
                    while (Select_3_Subt2 < 1 || Select_3_Subt2 > 5)
                    {
                        Console.WriteLine("Введите цифру от 1 до 5");
                        Select_3_Subt1 = Check(Console.ReadLine());
                    }
                    ICollection <int> Keys = list.Keys;
                    switch (Select_3_Subt2)
                    {
                        case 1:
                            int Count = 0;
                            foreach(var t1 in Keys)
                                if (list[t1].GetType() == Fac.GetType())
                                {
                                    list[t1].Show();
                                    Count++;
                                }
                            if (Count == 0)
                                Console.WriteLine("Нет элементов такого типа");
                            break;
                        case 2:
                            int Count1 = 0;
                            foreach (var t1 in Keys)
                                if (list[t1].GetType() == Ins.GetType())
                                {
                                    list[t1].Show();
                                    Count1++;
                                }
                            if (Count1 == 0)
                                Console.WriteLine("Нет элементов такого типа");
                            break;
                        case 3:
                            int Count2 = 0;
                            foreach (var t1 in Keys)
                                if (list[t1].GetType() == Lib.GetType())
                                {
                                    list[t1].Show();
                                    Count2++;
                                }
                            if (Count2 == 0)
                                Console.WriteLine("Нет элементов такого типа");
                            break;
                        case 4:
                            int Count3 = 0;
                            foreach (var t1 in Keys)
                                if (list[t1].GetType() == Ship.GetType())
                                {
                                    list[t1].Show();
                                    Count3++;
                                }
                            if (Count3 == 0)
                                Console.WriteLine("Нет элементов такого типа");
                            break;
                        case 5:
                            int Count4 = 0;
                            foreach (var t1 in Keys)
                                if (list[t1].GetType() == Org.GetType())
                                {
                                    list[t1].Show();
                                    Count4++;
                                }
                            if (Count4 == 0)
                                Console.WriteLine("Нет элементов такого типа");
                            break;
                    }
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Индекс какого типа вы хотите вывести?\n1-Factory\n2-Insurance_Company\n3-Library\n4-Shipbuilding_company\n5-Organization");
                    int Select_3_Subt3 = Check(Console.ReadLine());
                    while (Select_3_Subt3 < 1 || Select_3_Subt3 > 5)
                    {
                        Console.WriteLine("Введите цифру от 1 до 5");
                        Select_3_Subt1 = Check(Console.ReadLine());
                    }
                    ICollection<int> Keys2 = list.Keys;
                    switch (Select_3_Subt3)
                    {
                        case 1:
                            int Counter = 0;
                            foreach (var t1 in Keys2)
                                if (list[t1].GetType() == Fac.GetType())
                                {
                                    Console.WriteLine($"Индекс элемента {t1}");
                                    Counter++;
                                }
                            if (Counter == 0)
                                Console.WriteLine("Нет элементов такого типа");
                            break;
                        case 2:
                            int Counter1 = 0;
                            foreach (var t1 in Keys2)
                                if (list[t1].GetType() == Ins.GetType())
                                {
                                    Console.WriteLine($"Индекс элемента {t1}");
                                    Counter1++;
                                }
                            if (Counter1 == 0)
                                Console.WriteLine("Нет элементов такого типа");
                            break;
                        case 3:
                            int Counter2 = 0;
                            foreach (var t1 in Keys2)
                                if (list[t1].GetType() == Lib.GetType())
                                {
                                    Console.WriteLine($"Индекс элемента {t1}");
                                    Counter2++;
                                }
                            if (Counter2 == 0)
                                Console.WriteLine("Нет элементов такого типа");
                            break;
                        case 4:
                            int Counter3 = 0;
                            foreach (var t1 in Keys2)
                                if (list[t1].GetType() == Ship.GetType())
                                {
                                    Console.WriteLine($"Индекс элемента {t1}");
                                    Counter3++;
                                }
                            if (Counter3 == 0)
                                Console.WriteLine("Нет элементов такого типа");
                            break;
                        case 5:
                            int Counter4 = 0;
                            foreach (var t1 in Keys2)
                                if (list[t1].GetType() == Org.GetType())
                                {
                                    Console.WriteLine($"Индекс элемента {t1}");
                                    Counter4++;
                                }
                            if (Counter4 == 0)
                                Console.WriteLine("Нет элементов такого типа");
                            break;
                    }
                    Console.ReadKey();
                    break;
            }
            Console.Clear();
            Console.WriteLine("Перебор Элементов коллекции");
            ICollection <int> keys1 = list.Keys;
            foreach (var k in keys1)
                list[k].Show();
            Console.Clear();
            Console.WriteLine("Клонируем коллекцию");
            List<Organization> Clone_List = new List<Organization>();
            
            foreach (var l in Clone_List)
                l.Show();
            Console.ReadKey();
            
            
        }
    }
}
