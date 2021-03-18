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
            ClassLibraryLab10.ClassLibraryLab10.Factory Fac = new ClassLibraryLab10.ClassLibraryLab10.Factory("Фабрика", 350, 20, "Лондон");
            ClassLibraryLab10.ClassLibraryLab10.Insurance_Company Ins = new ClassLibraryLab10.ClassLibraryLab10.Insurance_Company("Страховая компания", 270, 1990, 96);
            ClassLibraryLab10.ClassLibraryLab10.Library Lib = new ClassLibraryLab10.ClassLibraryLab10.Library("Библиотека", 50, 8, 700);
            ClassLibraryLab10.ClassLibraryLab10.Shipbuilding_company Ship = new ClassLibraryLab10.ClassLibraryLab10.Shipbuilding_company("Кораблестроительная компания", 200, 900000, 45);
            ClassLibraryLab10.ClassLibraryLab10.Organization Org = new ClassLibraryLab10.ClassLibraryLab10.Organization("Организация", 290);
            MyCollections<IInit, ClassLibraryLab10.ClassLibraryLab10.Factory, ClassLibraryLab10.ClassLibraryLab10.Insurance_Company, ClassLibraryLab10.ClassLibraryLab10.Library, ClassLibraryLab10.ClassLibraryLab10.Shipbuilding_company, ClassLibraryLab10.ClassLibraryLab10.Organization> New_Coll = new MyCollections<IInit, ClassLibraryLab10.ClassLibraryLab10.Factory, ClassLibraryLab10.ClassLibraryLab10.Insurance_Company, ClassLibraryLab10.ClassLibraryLab10.Library, ClassLibraryLab10.ClassLibraryLab10.Shipbuilding_company, ClassLibraryLab10.ClassLibraryLab10.Organization>(Fac, Ins, Lib, Ship, Org);
            Console.ReadKey();
            Console.WriteLine("Выберите следующее действие:\n1-добавление элемента в список\n2-удаление элемента из списка");
            int Select = Check(Console.ReadLine());

        }
    }
    public class MyCollections<T, T1,T2,T3,T4,T5> where T:class
    {
        
        List<object> list;
        public MyCollections(T1 x, T2 x1, T3 x2, T4 x3, T5 x4)
        {
            //size = s;
            //array = new Object[size];
            //array[0] = (Factory)x;
            //array[1] = x1;
            //array[2] = x2;
            //array[3] = x3;
            //array[4] = x4;
            list = new List<Object>();
            list.Add(x);
            list.Add(x1);
            list.Add(x2);
            list.Add(x3);
            list.Add(x4);
            
        }
        public void Show()
        {
            foreach (var v in list)
                Console.WriteLine();
        }    
    }
}
