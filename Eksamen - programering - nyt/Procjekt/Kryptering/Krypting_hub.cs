using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

// made by Christoffer og Grove

namespace Eksamen_Procjekt___Chris.Procjekt.Kryptering
{
    internal class Crypting_hub
    {
        public void Crypting()
        {
            list R_num = new list();
            string Mail;
            int stored_num; // her er variablen der kommer til at indeholde, hvad for et tal kryptering kommer til at indeholde;
            Console.WriteLine("please enter a mail: ");
            Mail = Console.ReadLine();
            foreach (char c in Mail)
            {
                stored_num = R_num.random_num();
                int num_of_ACSII;
                num_of_ACSII = c;
                int extra_number;
                extra_number = R_num.extranumbers();
                int complete = num_of_ACSII + stored_num;
                Console.WriteLine(complete + $"{stored_num}" + $"{extra_number}");
            }
            Console.WriteLine("please copy paste it");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Hope you are ready to un crypt it..");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
