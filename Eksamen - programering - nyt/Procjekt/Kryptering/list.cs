using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamen_Procjekt___Chris.Procjekt.Kryptering
{
    internal class list
    {
        public int random_num()
        {
            List<int> R_num = new List<int>();
            R_num.Add(108293745);
            R_num.Add(202485720);
            R_num.Add(392378059);
            R_num.Add(441374128);
            R_num.Add(502398475);
            R_num.Add(609237845);
            R_num.Add(002349780);
            R_num.Add(709237569);
            R_num.Add(892345235);
            R_num.Add(923456754);
            R_num.Add(104567654);
            R_num.Add(092783498);

            Random r = new Random();
            int indexval = r.Next(R_num.Count);
            //int indexval_total = indexval * 9;
            //  indexval = indexval_total;
            return R_num[indexval];
        }
        public int extranumbers()
        {
            List<int> extra = new List<int>();
            extra.Add(1);
            extra.Add(2);
            extra.Add(3);
            extra.Add(4);
            extra.Add(5);
            extra.Add(6);
            extra.Add(7);
            extra.Add(8);
            extra.Add(9);
            extra.Add(10);
            extra.Add(11);
            extra.Add(12);
            extra.Add(13);
            extra.Add(14);
            extra.Add(15);
            Random ex_r = new Random();
            int ex = ex_r.Next(extra.Count);
            return extra[ex];
        }


    }
}
