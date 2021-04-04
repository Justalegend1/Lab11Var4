using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Var4
{
    public class SortByName : IComparer
    {
        int IComparer.Compare(object ob1, object ob2)
        {
            Organization o = (Organization)(ob1);
            Organization o1 = (Organization)(ob2);
            if ((o.Number_of_employees) > (o1.Number_of_employees)) { return 1; }
            else if (o.Number_of_employees < (o1.Number_of_employees)) { return -1; }
            else { return 0; }

        }
    }
}
