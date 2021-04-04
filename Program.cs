using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Diagnostics;


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
            #region task1
            Console.WriteLine("Выберите номер задания\n1-Первое задание\n2-Второе задание\n3-Третье задание");
            int Task = Check(Console.ReadLine());
            while ((Task < 1) || (Task > 3))
            {
                Console.WriteLine("Введите цифру 1 или 2");
                Task = Check(Console.ReadLine());
            }
            if (Task == 1)
            {
                Factory Fac = new Factory("Фабрика", 350, 20, "Лондон");
                Insurance_Company Ins = new Insurance_Company("Страховая компания", 270, 1990, 96);
                Library Lib = new Library("Библиотека", 50, 8, 700);
                Shipbuilding_company Ship = new Shipbuilding_company("Кораблестроительная компания", 200, 900000, 45);
                Organization Org = new Organization("Организация", 290);
                Console.WriteLine("Выберите следующее действие:\n1-добавление элемента в список\n2-удаление элемента из списка");
                int Select = Check(Console.ReadLine());
                while ((Select > 2) || (Select < 1))
                {
                    Console.WriteLine("Введите 1 или 2");
                    Select = Check(Console.ReadLine());
                }
                SortedList list = new SortedList();
                list.Add("Factory", Fac);
                list.Add("Insurance_Company", Ins);
                list.Add("Library", Lib);
                list.Add("Shipbuilding_Company", Ship);
                list.Add("Organization", Org);
                Console.WriteLine("Исходная коллекция");
                Show();
                List<Organization> list1 = new List<Organization>();
                list1.Add(Fac);
                list1.Add(Ins);
                list1.Add(Lib);
                list1.Add(Ship);
                list1.Add(Org);
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
                                Organization New_Org = new Organization("Организация1", 450);
                                list.Add("Organization1", New_Org);
                                list1.Add( New_Org);
                                break;
                            case 2:
                                Insurance_Company New_Ins = new Insurance_Company("Страховая компания1", 290, 1989, 89);
                                list.Add("Insurance_Company1", New_Ins);
                                list1.Add( New_Ins);
                                break;
                            case 3:
                                Library New_Lib = new Library("Библиотека1", 458, 7, 790);
                                list.Add("Library1", New_Lib);
                                list1.Add(New_Lib);
                                break;
                            case 4:
                                Factory New_Fac = new Factory("Фабрика1", 345, 45, "Сочи");
                                list.Add("Factory1", New_Fac);
                                list1.Add(New_Fac);
                                break;
                            case 5:
                                Shipbuilding_company New_Ship = new Shipbuilding_company("Копаблестроительная фирма1", 560, 45000000, 34);
                                list.Add("Shipbuilding_company", New_Ship);
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
                                list1.RemoveAt(0);
                                break;
                            case 2:
                                list.RemoveAt(1);
                                list1.RemoveAt(1);
                                break;
                            case 3:
                                list.RemoveAt(2);
                                list1.RemoveAt(2);
                                break;
                            case 4:
                                list.RemoveAt(3);
                                list1.RemoveAt(3);
                                break;
                            case 5:
                                list.RemoveAt(4);
                                list1.RemoveAt(4);
                                break;
                        }
                        Show();
                        break;

                }
                Console.ReadKey();
                void Show()
                {
                    ICollection val = list.Values;
                    foreach (Organization v in val)
                        v.Show();
                }
                Console.Clear();
                Console.WriteLine("Выберите запрос, который хотите осуществить\n1-Количество элементов определенного типа\n2-Печать элементов определенного типа\n3-Ключи элементов определенного типа");
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
                        ICollection Keys1 = list.Keys;
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
                        ICollection Keys = list.Values;
                        switch (Select_3_Subt2)
                        {
                            case 1:
                                int Count = 0;
                                foreach (Organization t1 in Keys)
                                    if (t1.GetType() == Fac.GetType())
                                    {
                                        t1.Show();
                                        Count++;
                                    }
                                if (Count == 0)
                                    Console.WriteLine("Нет элементов такого типа");
                                break;
                            case 2:
                                int Count1 = 0;
                                foreach (Organization t1 in Keys)
                                    if (t1.GetType() == Ins.GetType())
                                    {
                                        t1.Show();
                                        Count1++;
                                    }
                                if (Count1 == 0)
                                    Console.WriteLine("Нет элементов такого типа");
                                break;
                            case 3:
                                int Count2 = 0;
                                foreach (Organization t1 in Keys)
                                    if (t1.GetType() == Lib.GetType())
                                    {
                                        t1.Show();
                                        Count2++;
                                    }
                                if (Count2 == 0)
                                    Console.WriteLine("Нет элементов такого типа");
                                break;
                            case 4:
                                int Count3 = 0;
                                foreach (Organization t1 in Keys)
                                    if (t1.GetType() == Ship.GetType())
                                    {
                                        t1.Show();
                                        Count3++;
                                    }
                                if (Count3 == 0)
                                    Console.WriteLine("Нет элементов такого типа");
                                break;
                            case 5:
                                int Count4 = 0;
                                foreach (Organization t1 in Keys)
                                    if (t1.GetType() == Org.GetType())
                                    {
                                        t1.Show();
                                        Count4++;
                                    }
                                if (Count4 == 0)
                                    Console.WriteLine("Нет элементов такого типа");
                                break;
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Ключ какого типа вы хотите вывести?\n1-Factory\n2-Insurance_Company\n3-Library\n4-Shipbuilding_company\n5-Organization");
                        int Select_3_Subt3 = Check(Console.ReadLine());
                        while (Select_3_Subt3 < 1 || Select_3_Subt3 > 5)
                        {
                            Console.WriteLine("Введите цифру от 1 до 5");
                            Select_3_Subt3 = Check(Console.ReadLine());
                        }
                        ICollection Keys2 = list.Keys;
                        switch (Select_3_Subt3)
                        {
                            case 1:
                                int Counter = 0;
                                foreach (var t1 in Keys2)
                                    if (list[t1].GetType() == Fac.GetType())
                                    {
                                        Console.WriteLine($"Ключ элемента {t1}");
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
                                        Console.WriteLine($"Ключ элемента {t1}");
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
                                        Console.WriteLine($"Ключ элемента {t1}");
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
                                        Console.WriteLine($"Ключ элемента {t1}");
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
                                        Console.WriteLine($"Ключ элемента {t1}");
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
                ICollection keys1 = list.Values;
                foreach (Organization k in keys1)
                    k.Show();
                Console.WriteLine("Сортируем необобщенную коллекцию");
                Organization t;

                for (int o = 0; o < list1.Count; o++)
                    for (int o1 = o + 1; o1 < list1.Count; o1++)
                        if (list1[o].Number_of_employees > (list1[o1].Number_of_employees))
                        {
                            t = list1[o1];
                            list1[o1] = list1[o];
                            list1[o] = t;
                        }
                foreach (Organization t1 in list1)
                    t1.Show();
                //foreach (Organization k in keys1)
                //    k.Show();
                Organization[] Arr_For_Coll = new Organization[list.Count];
                Console.WriteLine("Какой элемент вы хотите найти?\n1-Factory\n2-Insurance_Company\n3-Library\n4-Shipbuilding_company\n5-Organization");
                int Select_3_Subt4 = Check(Console.ReadLine());
                while (Select_3_Subt4 < 1 || Select_3_Subt4 > 5)
                {
                    Console.WriteLine("Введите цифру от 1 до 5");
                    Select_3_Subt4 = Check(Console.ReadLine());
                }
                ICollection Keys3 = list.Keys;
                switch (Select_3_Subt4)
                {
                    case 1:
                        int Counter = 0;
                        foreach (var t1 in Keys3)
                            if (list[t1].GetType() == Fac.GetType())
                            {
                                Console.WriteLine($"Ключ элемента {t1}");
                                Counter++;
                            }
                        if (Counter == 0)
                            Console.WriteLine("Нет элементов такого типа");
                        break;
                    case 2:
                        int Counter1 = 0;
                        foreach (var t1 in Keys3)
                            if (list[t1].GetType() == Ins.GetType())
                            {
                                Console.WriteLine($"Ключ элемента {t1}");
                                Counter1++;
                            }
                        if (Counter1 == 0)
                            Console.WriteLine("Нет элементов такого типа");
                        break;
                    case 3:
                        int Counter2 = 0;
                        foreach (var t1 in Keys3)
                            if (list[t1].GetType() == Lib.GetType())
                            {
                                Console.WriteLine($"Ключ элемента {t1}");
                                Counter2++;
                            }
                        if (Counter2 == 0)
                            Console.WriteLine("Нет элементов такого типа");
                        break;
                    case 4:
                        int Counter3 = 0;
                        foreach (var t1 in Keys3)
                            if (list[t1].GetType() == Ship.GetType())
                            {
                                Console.WriteLine($"Ключ элемента {t1}");
                                Counter3++;
                            }
                        if (Counter3 == 0)
                            Console.WriteLine("Нет элементов такого типа");
                        break;
                    case 5:
                        int Counter4 = 0;
                        foreach (var t1 in Keys3)
                            if (list[t1].GetType() == Org.GetType())
                            {
                                Console.WriteLine($"Ключ элемента {t1}");
                                Counter4++;
                            }
                        if (Counter4 == 0)
                            Console.WriteLine("Нет элементов такого типа");
                        break;
                }
                Console.ReadKey();
            }
            #endregion task1
            #region task2
            else if (Task == 2)
            {
                Console.Clear();
                List<Organization> MyColl = new List<Organization>();
                Factory Fact = new Factory("Фабрика", 350, 20, "Москва");
                Insurance_Company Insu = new Insurance_Company("Страховая компания", 270, 1990, 96);
                Library Libr = new Library("Библиотека", 50, 6, 350);
                Shipbuilding_company Shipb = new Shipbuilding_company("Кораблестроительная компания", 200, 1000000000, 45);
                Organization Orga = new Organization("Организация", 320);
                Console.WriteLine("Задание 1");
                MyColl.Add(Fact);
                MyColl.Add(Insu);
                MyColl.Add(Libr);
                MyColl.Add(Shipb);
                MyColl.Add(Orga);
                void Show1()
                {
                    foreach (var v in MyColl)
                        v.Show();
                }
                Console.WriteLine("Выберите следующее действие:\n1-добавление элемента в список\n2-удаление элемента из списка");
                int Select = Check(Console.ReadLine());
                while ((Select > 2) || (Select < 1))
                {
                    Console.WriteLine("Введите 1 или 2");
                    Select = Check(Console.ReadLine());
                }
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
                                Organization New_Org = new Organization("Организация2", 450);
                                MyColl.Add(New_Org);
                                break;
                            case 2:
                                Insurance_Company New_Ins = new Insurance_Company("Страховая компания2", 290, 1989, 89);
                                MyColl.Add(New_Ins);
                                break;
                            case 3:
                                Library New_Lib = new Library("Библиотека2", 458, 7, 790);
                                MyColl.Add(New_Lib);
                                break;
                            case 4:
                                Factory New_Fac = new Factory("Фабрика2", 345, 45, "Сочи");
                                MyColl.Add(New_Fac);
                                break;
                            case 5:
                                Shipbuilding_company New_Ship = new Shipbuilding_company("Кораблестроительная фирма2", 560, 45000000, 34);
                                MyColl.Add(New_Ship);
                                break;
                        }
                        Show1();
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
                                MyColl.RemoveAt(0);
                                break;
                            case 2:
                                MyColl.RemoveAt(1);
                                break;
                            case 3:
                                MyColl.RemoveAt(2);
                                break;
                            case 4:
                                MyColl.RemoveAt(3);
                                break;
                            case 5:
                                MyColl.RemoveAt(4);
                                break;
                        }
                        Show1();
                        break;
                }
                Console.WriteLine("Выберите запрос, который хотите осуществить\n1-Количество элементов определенного типа\n2-Печать элементов определенного типа\n3-Индекс элементов определенного типа");
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
                        switch (Select_3_Subt1)
                        {
                            case 1:
                                int count = 0;
                                foreach (var t1 in MyColl)
                                    if (t1.GetType() == Fact.GetType())
                                        count++;
                                Console.WriteLine($"Количество элементов данного типа: {count}");
                                break;
                            case 2:
                                int count1 = 0;
                                foreach (var t1 in MyColl)
                                    if (t1.GetType() == Insu.GetType())
                                        count1++;
                                Console.WriteLine($"Количество элементов данного типа: {count1}");
                                break;
                            case 3:
                                int count2 = 0;
                                foreach (var t1 in MyColl)
                                    if (t1.GetType() == Libr.GetType())
                                        count2++;
                                Console.WriteLine($"Количество элементов данного типа: {count2}");
                                break;
                            case 4:
                                int count3 = 0;
                                foreach (var t1 in MyColl)
                                    if (t1.GetType() == Shipb.GetType())
                                        count3++;
                                Console.WriteLine($"Количество элементов данного типа: {count3}");
                                break;
                            case 5:
                                int count4 = 0;
                                foreach (var t1 in MyColl)
                                    if (t1.GetType() == Orga.GetType())
                                        count4++;
                                Console.WriteLine($"Количество элементов данного типа: {count4}");
                                break;
                        }
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Какой тип элементов вы хотите вывести?\n1-Factory\n2-Insurance_Company\n3-Library\n4-Shipbuilding_company\n5-Organization");
                        int Select_3_Subt6 = Check(Console.ReadLine());
                        while (Select_3_Subt6 < 1 || Select_3_Subt6 > 5)
                        {
                            Console.WriteLine("Введите цифру от 1 до 5");
                            Select_3_Subt6 = Check(Console.ReadLine());
                        }
                        switch (Select_3_Subt6)
                        {
                            case 1:
                                int Count = 0;
                                foreach (var t1 in MyColl)
                                    if (t1.GetType() == Fact.GetType())
                                    {
                                        t1.Show();
                                        Count++;
                                    }
                                if (Count == 0)
                                    Console.WriteLine("Нет элементов такого типа");
                                break;
                            case 2:
                                int Count1 = 0;
                                foreach (var t1 in MyColl)
                                    if (t1.GetType() == Insu.GetType())
                                    {
                                        t1.Show();
                                        Count1++;
                                    }
                                if (Count1 == 0)
                                    Console.WriteLine("Нет элементов такого типа");
                                break;
                            case 3:
                                int Count2 = 0;
                                foreach (var t1 in MyColl)
                                    if (t1.GetType() == Libr.GetType())
                                    {
                                        t1.Show();
                                        Count2++;
                                    }
                                if (Count2 == 0)
                                    Console.WriteLine("Нет элементов такого типа");
                                break;
                            case 4:
                                int Count3 = 0;
                                foreach (var t1 in MyColl)
                                    if (t1.GetType() == Shipb.GetType())
                                    {
                                        t1.Show();
                                        Count3++;
                                    }
                                if (Count3 == 0)
                                    Console.WriteLine("Нет элементов такого типа");
                                break;
                            case 5:
                                int Count4 = 0;
                                foreach (var t1 in MyColl)
                                    if (t1.GetType() == Orga.GetType())
                                    {
                                        t1.Show();
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
                            Select_3_Subt3 = Check(Console.ReadLine());
                        }
                        switch (Select_3_Subt3)
                        {
                            case 1:
                                int Counter = 0;
                                foreach (var t1 in MyColl)
                                    if (t1.GetType() == Fact.GetType())
                                    {
                                        Console.WriteLine($"Индекс элемента {MyColl.IndexOf(t1)}");
                                        Counter++;
                                    }
                                if (Counter == 0)
                                    Console.WriteLine("Нет элементов такого типа");
                                break;
                            case 2:
                                int Counter1 = 0;
                                foreach (var t1 in MyColl)
                                    if (t1.GetType() == Insu.GetType())
                                    {
                                        Console.WriteLine($"Индекс элемента {MyColl.IndexOf(t1)}");
                                        Counter1++;
                                    }
                                if (Counter1 == 0)
                                    Console.WriteLine("Нет элементов такого типа");
                                break;
                            case 3:
                                int Counter2 = 0;
                                foreach (var t1 in MyColl)
                                    if (t1.GetType() == Libr.GetType())
                                    {
                                        Console.WriteLine($"Индекс элемента {MyColl.IndexOf(t1)}");
                                        Counter2++;
                                    }
                                if (Counter2 == 0)
                                    Console.WriteLine("Нет элементов такого типа");
                                break;
                            case 4:
                                int Counter3 = 0;
                                foreach (var t1 in MyColl)
                                    if (t1.GetType() == Shipb.GetType())
                                    {
                                        Console.WriteLine($"Индекс элемента {MyColl.IndexOf(t1)}");
                                        Counter3++;
                                    }
                                if (Counter3 == 0)
                                    Console.WriteLine("Нет элементов такого типа");
                                break;
                            case 5:
                                int Counter4 = 0;
                                foreach (var t1 in MyColl)
                                    if (t1.GetType() == Orga.GetType())
                                    {
                                        Console.WriteLine($"Индекс элемента {MyColl.IndexOf(t1)}");
                                        Counter4++;
                                    }
                                if (Counter4 == 0)
                                    Console.WriteLine("Нет элементов такого типа");
                                break;
                        }
                        Console.ReadKey();
                        break;
                }
                Console.WriteLine("Перебор элементов");
                foreach (var lp in MyColl)
                    lp.Show();
                Console.Clear();
                Console.WriteLine("Сортируем коллекцию по значению кол-ва сотрудников");
                Organization t;
                for (int o = 0; o < MyColl.Count; o++)
                    for (int o1 = o + 1; o1 < MyColl.Count; o1++)
                        if (MyColl[o].Number_of_employees > MyColl[o1].Number_of_employees)
                        {
                            t = MyColl[o1];
                            MyColl[o1] = MyColl[o];
                            MyColl[o] = t;
                        }
                Show1();
                Console.ReadKey();
                Console.WriteLine("Какой тип элементов вы хотите вывести?\n1-Factory\n2-Insurance_Company\n3-Library\n4-Shipbuilding_company\n5-Organization");
                int Select_3_Subt2 = Check(Console.ReadLine());
                while (Select_3_Subt2 < 1 || Select_3_Subt2 > 5)
                {
                    Console.WriteLine("Введите цифру от 1 до 5");
                    Select_3_Subt2 = Check(Console.ReadLine());
                }
                switch (Select_3_Subt2)
                {
                    case 1:
                        int Count = 0;
                        foreach (var t1 in MyColl)
                            if (t1.GetType() == Fact.GetType())
                            {
                                t1.Show();
                                Count++;
                            }
                        if (Count == 0)
                            Console.WriteLine("Нет элементов такого типа");
                        break;
                    case 2:
                        int Count1 = 0;
                        foreach (var t1 in MyColl)
                            if (t1.GetType() == Insu.GetType())
                            {
                                t1.Show();
                                Count1++;
                            }
                        if (Count1 == 0)
                            Console.WriteLine("Нет элементов такого типа");
                        break;
                    case 3:
                        int Count2 = 0;
                        foreach (var t1 in MyColl)
                            if (t1.GetType() == Libr.GetType())
                            {
                                t1.Show();
                                Count2++;
                            }
                        if (Count2 == 0)
                            Console.WriteLine("Нет элементов такого типа");
                        break;
                    case 4:
                        int Count3 = 0;
                        foreach (var t1 in MyColl)
                            if (t1.GetType() == Shipb.GetType())
                            {
                                t1.Show();
                                Count3++;
                            }
                        if (Count3 == 0)
                            Console.WriteLine("Нет элементов такого типа");
                        break;
                    case 5:
                        int Count4 = 0;
                        foreach (var t1 in MyColl)
                            if (t1.GetType() == Orga.GetType())
                            {
                                t1.Show();
                                Count4++;
                            }
                        if (Count4 == 0)
                            Console.WriteLine("Нет элементов такого типа");
                        break;
                }
                Console.ReadKey();
                #endregion task2
            }
            #region Task3
            else if (Task == 3)
            {
                TestCollections Col1 = new TestCollections();
                Factory t;
                
                Console.WriteLine("Что вы хотите сделать?\n1-Добавить элемент\n2-Удалить элемент\n3-Измерить время");
                int Select_For_3 = Check(Console.ReadLine());
                {
                    while ((Select_For_3 < 1) || (Select_For_3 > 3))
                    {
                        Console.WriteLine("ВВедите цифру от 1 до 3");
                        Select_For_3 = Check(Console.ReadLine());
                    }
                }
                switch (Select_For_3)
                {
                    case 1:
                        Organization org = new Organization();
                        Factory fac = new Factory();
                        while (Col1.Sorted_Dictionary_Org.ContainsKey(org) || Col1.Sorted_Dictionary_String.ContainsKey(org.ToString()))
                            org = (Organization)org.Init();
                        fac = (Factory)fac.Init();
                        Col1.Org_Queue.Enqueue(fac);
                        Col1.Org_Queue_String.Enqueue(fac.ToString());
                        Col1.Sorted_Dictionary_Org.Add(org, fac);
                        Col1.Sorted_Dictionary_String.Add(org.ToString(), fac);
                        foreach (var k in Col1.Org_Queue)
                            k.Show();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Какой из тысячи элементов вы хотите удалить?");
                        int Delete = Check(Console.ReadLine());
                        while (Delete < 1 || Delete > 1000)
                        {
                            Console.WriteLine("Введите число от 1 до 1000");
                            Delete = Check(Console.ReadLine());
                        }
                        var keys = Col1.Sorted_Dictionary_Org.Keys;
                        Col1.Sorted_Dictionary_Org.Remove(Col1.SpecialList[Delete-1]);
                        Col1.Sorted_Dictionary_String.Remove((Col1.SpecialList[Delete - 1]).ToString());
                        Console.WriteLine("Просматриваем словарь");
                        foreach (var k in Col1.Sorted_Dictionary_Org.Keys)
                            Col1.Sorted_Dictionary_Org[k].Show();
                        Console.Clear();
                        Console.WriteLine("Для очереди возможно лишь удалить последний элемент, поэтому удаляем его");
                        Col1.Org_Queue.Dequeue();
                        Col1.Org_Queue_String.Dequeue();
                        foreach (var k in Col1.Org_Queue)
                            k.Show();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Первый элемент");
                        Stopwatch time = new Stopwatch();
                        time.Start();
                        Col1.Sorted_Dictionary_Org.ContainsKey(Col1.SpecialList[0]);
                        time.Stop();
                        Console.WriteLine($"Количетство тактов, затраченное на поиск элемента в Sorted_Dictionary_Org коллекции: {time.ElapsedTicks}");
                        Console.ReadKey();
                        time.Reset();
                        time.Start();
                        Col1.Sorted_Dictionary_String.ContainsKey(Col1.SpecialList[0].ToString());
                        time.Stop();
                        Console.WriteLine($"Количетство тактов, затраченное на поиск элемента в Sorted_Dictionary_String коллекции: {time.ElapsedTicks}");
                        Console.ReadKey();
                        time.Reset();
                        time.Start();
                        Col1.Org_Queue.Contains(Col1.SpecialListForQueue[0]);
                        time.Stop();
                        Console.WriteLine($"Количетство тактов, затраченное на поиск элемента в Org_Queue коллекции: {time.ElapsedTicks}");
                        Console.ReadKey();
                        time.Reset();
                        time.Start();
                        Col1.Org_Queue_String.Contains(Col1.SpecialListForQueue[0].ToString());
                        time.Stop();
                        Console.WriteLine($"Количетство тактов, затраченное на поиск элемента в Org_Queue_String коллекции: {time.ElapsedTicks}");
                        Console.ReadKey();
                        Console.WriteLine("Серединный элемент");
                        time.Reset();
                        time.Start();
                        Col1.Sorted_Dictionary_Org.ContainsKey(Col1.SpecialList[499]);
                        time.Stop();
                        Console.WriteLine($"Количетство тактов, затраченное на поиск элемента в Sorted_Dictionary_Org коллекции: {time.ElapsedTicks}");
                        Console.ReadKey();
                        time.Reset();
                        time.Start();
                        Col1.Sorted_Dictionary_String.ContainsKey(Col1.SpecialList[499].ToString());
                        time.Stop();
                        Console.WriteLine($"Количетство тактов, затраченное на поиск элемента в Sorted_Dictionary_String коллекции: {time.ElapsedTicks}");
                        Console.ReadKey();
                        time.Reset();
                        time.Start();
                        Col1.Org_Queue.Contains(Col1.SpecialListForQueue[499]);
                        time.Stop();
                        Console.WriteLine($"Количетство тактов, затраченное на поиск элемента в Org_Queue коллекции: {time.ElapsedTicks}");
                        Console.ReadKey();
                        time.Reset();
                        time.Start();
                        Col1.Org_Queue_String.Contains(Col1.SpecialListForQueue[499].ToString());
                        time.Stop();
                        Console.WriteLine($"Количетство тактов, затраченное на поиск элемента в Org_Queue_String коллекции: {time.ElapsedTicks}");
                        Console.ReadKey();
                        Console.WriteLine("Последний элемент");
                        time.Reset();
                        time.Start();
                        Col1.Sorted_Dictionary_Org.ContainsKey(Col1.SpecialList[Col1.SpecialList.Count-1]);
                        time.Stop();
                        Console.WriteLine($"Количетство тактов, затраченное на поиск элемента в Sorted_Dictionary_Org коллекции: {time.ElapsedTicks}");
                        Console.ReadKey();
                        time.Reset();
                        time.Start();
                        Col1.Sorted_Dictionary_String.ContainsKey(Col1.SpecialList[Col1.SpecialList.Count - 1].ToString());
                        time.Stop();
                        Console.WriteLine($"Количетство тактов, затраченное на поиск элемента в Sorted_Dictionary_String коллекции: {time.ElapsedTicks}");
                        Console.ReadKey();
                        time.Reset();
                        time.Start();
                        Col1.Org_Queue.Contains(Col1.SpecialListForQueue[Col1.SpecialListForQueue.Count-1]);
                        time.Stop();
                        Console.WriteLine($"Количетство тактов, затраченное на поиск элемента в Org_Queue коллекции: {time.ElapsedTicks}");
                        Console.ReadKey();
                        time.Reset();
                        time.Start();
                        Col1.Org_Queue_String.Contains(Col1.SpecialListForQueue[Col1.SpecialListForQueue.Count - 1].ToString());
                        time.Stop();
                        Console.WriteLine($"Количетство тактов, затраченное на поиск элемента в Org_Queue_String коллекции: {time.ElapsedTicks}");
                        Console.ReadKey();
                        break;
                }
            }
            #endregion
        }
    }
}
