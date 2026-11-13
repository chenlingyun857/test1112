

namespace netCore;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@$"请选择你要运行的模块（如输入1即运行单一职责原则模块，或者运行设计模式如a1即单例模式第一种写法：
        1：单一职责原则   2：接口隔离原则   3：依赖倒转原则   4：里氏替换原则   5：开闭原则   6：迪米特法则   7：合成复用原则
        a1-9：单例模式 b1-3：工厂模式 c：原型模式 d:建造者模式 e1-3：构造器模式 f：桥接模式 g：装饰者模式 h：组合模式
        i：外观模式 j：享元模式 k1-3：代理模式 l：模板方法模式 M：命令模式 n：访问者模式 o：迭代器模式 p：观察者模式 
        q：中介者模式 r：备忘录模式 s：解释器模式 t：状态模式 u：策略模式 v：职责链模式 放水电费是");
        string switchNum = Console.ReadLine().ToString();
        switch (switchNum.ToLower())
        {
            case "b1":
                Linq.data1.main.start();
                break;
            case "b2":
                Linq.data2.main.start();
                break;
            case "b3":
                Linq.recordData.main.start();
                break;
            case "c":
            case "c1":
                DI.data1.main.start();
                break;
            case "d":
                Linq.委托.main.start();
                break;
            default:
                Console.WriteLine("未找到指定类型！");
                break;
        }
    }
}
