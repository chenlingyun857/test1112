using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netCore.Linq.委托
{
    internal class main
    {
        public static void start()
        {
            weiTuo w = tests;
            Console.WriteLine(w.Invoke("这是测试参数", "描述1"));

            Action a = wucan;
            a.Invoke();

            Func<string, string, string> func = tests;
            Console.WriteLine(func.Invoke("这是Func带参数和返回值的", "描述1")); // 最后一个参数是返回值类型，前面的是参数类型
            
            // 无参数和返回值的lambda的委托
            Action a1 = delegate
            {
                Console.WriteLine("这是无参数和返回值的lambda的委托");
            };
            a1.Invoke();
            // 有参数无返回值的lambda的委托
            Action<string> a2 = delegate(string str)
            {
                Console.WriteLine(str);
            };
            a2.Invoke("有参数无返回值的lambda的委托");
            
            // 有参数和返回值的lambda的委托
            Func<int, int, string> f2 = (i, j) => { return "两个参数的和是：" + (i + j); };
            Func<int, int, string> f3 = (i, j) => "两个参数的和是：" + (i + j);
            Func<int, string> f4 = i => "两个参数的和是：" + i;

            Func<List<int>, int, List<int>> f5 = delegate (List<int> list, int num)
            {
                List<int> res = new List<int>();
                foreach (var item in list)
                {
                    if (item > num)
                    {
                        res.Add(item);
                    }
                }
                return res;
            };
			List<int> lists = f5.Invoke(new List<int> { 1, 2, 3 }, 2);
            
            Func<int, int, string> f1 = delegate(int i, int j)
            {
                return "两个参数的和是：" +  (i + j);
            };
            Console.WriteLine(f1.Invoke(21, 3));
            Console.WriteLine(f2.Invoke(22, 3));
            Console.WriteLine(f3.Invoke(23, 3));
            Console.WriteLine(f4.Invoke(23));
        }

        public static void wucan()
        {
            Console.WriteLine("这是Action无参数和返回值的委托");
            Console.WriteLine("这是Action无参数和返回值的委托");
        }
        public static string tests(string str, string desc)
        {
            return str + desc;
        }
    }
    delegate string weiTuo(string ss, string sss);
}
