using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace netCore.DI.data1
{
    internal class main
    {
        public static void start()
        {
            ServiceCollection sc = new ServiceCollection();
            sc.AddTransient<TestServiceImpl>();
            using(ServiceProvider sp = sc.BuildServiceProvider())
            {
                TestServiceImpl? t1 = sp.GetService<TestServiceImpl>();
                t1.name = "潘妮";
                t1.hi();


                TestServiceImpl? t2 = sp.GetService<TestServiceImpl>();
                Console.WriteLine(object.ReferenceEquals(t1, t2));
            }

            Console.WriteLine("===========");

            ServiceCollection sc2 = new ServiceCollection();
            //sc2.AddScoped<ITestSerivce, TestServiceImpl>();
            sc2.AddScoped(typeof(ITestSerivce), typeof(TestServiceImpl));
            using (ServiceProvider sp = sc2.BuildServiceProvider())
            {
                ITestSerivce? t1 = sp.GetService<ITestSerivce>();
                t1.name = "妮二狗";
                t1.hi();

                ITestSerivce? t2 = sp.GetService<ITestSerivce>();
                Console.WriteLine(object.ReferenceEquals(t1, t2));
            }
            String str = "a,b,c";
            Console.WriteLine(str.zunDuHaoXiao(2));
            
        }
    }

    public interface ITestSerivce
    {
        public string name { get; set; }

        public void hi();
    }

    public class TestServiceImpl : ITestSerivce
    {
        public string name { get; set; }
        public void hi()
        {
            Console.WriteLine(name + "你好");
        }
    }
}
