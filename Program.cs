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
            #region task1
            Console.WriteLine("Выберите номер задания\n1-Первое задание\n2-Второе задание");
            int Task = Check(Console.ReadLine());
            while ((Task < 1) || (Task > 2))
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
                SortedList<string, Organization> list = new SortedList<string, Organization>();
                list.Add("Factory", Fac);
                list.Add("Insurance_Company", Ins);
                list.Add("Library", Lib);
                list.Add("Shipbuilding_Company", Ship);
                list.Add("Organization", Org);
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
                                Organization New_Org = new Organization("Организация1", 450);
                                list.Add("Organization1", New_Org);
                                break;
                            case 2:
                                Insurance_Company New_Ins = new Insurance_Company("Страховая компания1", 290, 1989, 89);
                                list.Add("Insurance_Company1", New_Ins);
                                break;
                            case 3:
                                Library New_Lib = new Library("Библиотека1", 458, 7, 790);
                                list.Add("Library1", New_Lib);
                                break;
                            case 4:
                                Factory New_Fac = new Factory("Фабрика1", 345, 45, "Сочи");
                                list.Add("Factory1", New_Fac);
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
                    ICollection<string> keys = list.Keys;
                    foreach (var v in keys)
                        list[v].Show();
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
                        ICollection<string> Keys1 = list.Keys;
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
                        ICollection<string> Keys = list.Keys;
                        switch (Select_3_Subt2)
                        {
                            case 1:
                                int Count = 0;
                                foreach (var t1 in Keys)
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
                        Console.WriteLine("Ключ какого типа вы хотите вывести?\n1-Factory\n2-Insurance_Company\n3-Library\n4-Shipbuilding_company\n5-Organization");
                        int Select_3_Subt3 = Check(Console.ReadLine());
                        while (Select_3_Subt3 < 1 || Select_3_Subt3 > 5)
                        {
                            Console.WriteLine("Введите цифру от 1 до 5");
                            Select_3_Subt3 = Check(Console.ReadLine());
                        }
                        ICollection<string> Keys2 = list.Keys;
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
                ICollection<string> keys1 = list.Keys;
                foreach (var k in keys1)
                    list[k].Show();
                ////Console.Clear();
                ////Console.WriteLine("Клонируем коллекцию");
                //SortedList<int, Organization> Clone_List = new SortedList<int, Organization>();
                ////for (int lo = 0; lo < list.Count; lo++)
                ////    Clone_List.Add(lo, (Organization)list[lo].Clone());
                ////foreach (var vi in keys1)
                ////    Clone_List[vi].Show();
                void PrintKeysAndValues(SortedList<string, Organization> myList)
                {
                    Console.WriteLine("\t-KEY-\t-VALUE-");
                    //for (int i = 0; i < myList.Count; i++)
                    //{
                    //    Console.WriteLine("\t{0}:\t{1}", myList.GetKey(i), myList.GetByIndex(i));
                    //}
                    //Console.WriteLine();
                    //Console.ReadKey();
                }
                Organization[] Arr_For_Coll = new Organization[list.Count];
                Console.WriteLine("Какой элемент вы хоитите найти?\n1-Factory\n2-Insurance_Company\n3-Library\n4-Shipbuilding_company\n5-Organization");
                int Select_3_Subt4 = Check(Console.ReadLine());
                while (Select_3_Subt4 < 1 || Select_3_Subt4 > 5)
                {
                    Console.WriteLine("Введите цифру от 1 до 5");
                    Select_3_Subt4 = Check(Console.ReadLine());
                }
                ICollection<string> Keys3 = list.Keys;
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
        }
    }
}
