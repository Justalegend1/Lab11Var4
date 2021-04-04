using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Var4
{
    public class TestCollections
    {
        public Queue<Factory> Org_Queue = new Queue<Factory>(1000);
        public Queue<string> Org_Queue_String = new Queue<string>(1000);
        public SortedDictionary<Organization, Factory> Sorted_Dictionary_Org = new SortedDictionary<Organization, Factory>();
        public SortedDictionary<string, Factory> Sorted_Dictionary_String = new SortedDictionary<string, Factory>();
        private static Factory fac = new Factory();
        private static Organization org = new Organization();
        public List<Organization> SpecialList = new List<Organization>();
        public List<Organization> SpecialListForQueue = new List<Organization>();
        public TestCollections()
        {
            for (int i = 0; i < 1000; i++)
            {
                while (Sorted_Dictionary_Org.ContainsKey(fac.BaseFactory)|| Sorted_Dictionary_String.ContainsKey(fac.ToString()))
                    fac = (Factory)fac.Init();
                SpecialList.Add(fac.BaseFactory);
                SpecialListForQueue.Add(fac);
                Org_Queue.Enqueue(fac);
                Org_Queue_String.Enqueue(fac.BaseFactory.ToString());
                Sorted_Dictionary_Org.Add(fac.BaseFactory, fac);
                Sorted_Dictionary_String.Add(fac.ToString(), fac);
                    
            }
            foreach (var k in Org_Queue)
                k.Show();
            Console.ReadKey();
        }

    }
}
