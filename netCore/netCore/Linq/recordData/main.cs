using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netCore.Linq.recordData
{
    internal class main
    {
        public static void start()
        {
            Person p1 = new Person(1, "祢衡");
            Person p2 = new Person(1, "祢衡");
            Person p3 = new Person(2, "祢衡");
            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1 == p3);
            Console.WriteLine(p1.ToString());
        }
    }

    record Person(int id, string name);
    record Persons(int id, string name){
        public string nickName { get; set; }
    }

}
