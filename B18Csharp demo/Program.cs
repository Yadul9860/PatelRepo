using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B18Csharp_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //  palindrome number
            //Console.WriteLine("please enter number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int rem = 0;
            //int result = 0;
            //while (num != 0)
            //{
            //    rem = num % 10;
            //    result = result * 10 + rem;
            //    num = num / 10;
            //}
            //Console.WriteLine(result);
            //Console.ReadLine();

            // Reverse duplicate

            string name = "yadulpatel";
            string name1= string.Empty;
            for(int i = 0; i< name.Length; i++)
            {
                if (!name1.Contains(name[i]))
                {
                    name1 += name[i];
                }
            }

            // rev
            string name2 = "yadulpatel";
            string name3 = string.Empty;
            for (int i = 0; i < name2.Length; i++)
            {
                if (!name3.Contains(name[i]))
                {
                    name3 += name2[i];
                }
            }
            Console.WriteLine(name3);
            Console.ReadLine();

        }
    }
}
