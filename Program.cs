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
            List<Organization> list = new List<Organization>();
            list.Add(Fac);
            list.Add(Ins);
            list.Add(Lib);
            list.Add(Ship);
            list.Add(Org);
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
                            list.Add(New_Org);
                            break;
                        case 2:
                            Insurance_Company New_Ins = new Insurance_Company();
                            New_Ins = (Insurance_Company)New_Ins.Init();
                            list.Add(New_Ins);
                            break;
                        case 3:
                            Library New_Lib = new Library();
                            New_Lib = (Library)New_Lib.Init();
                            list.Add(New_Lib);
                            break;
                        case 4:
                            Factory New_Fac = new Factory();
                            New_Fac = (Factory)New_Fac.Init();
                            list.Add(New_Fac);
                            break;
                        case 5:
                            Shipbuilding_company New_Ship = new Shipbuilding_company();
                            New_Ship = (Shipbuilding_company)New_Ship.Init();
                            list.Add(New_Ship);
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
                        switch (Select2)
                        {
                            case 1:
                                list.RemoveAt(1);
                                break;
                            case 2:
                                list.RemoveAt(2);
                                break;
                            case 3:
                                list.RemoveAt(3);
                                break;
                            case 4:
                                list.RemoveAt(4);
                                break;
                            case 5:
                                list.RemoveAt(5);
                                break;
                        }
                        Show();
                    }
                    break;
            
            }
            Console.ReadKey();
            void Show()
            {
                foreach (var v in list)
                    v.Show();
            }
        }
    }
}
