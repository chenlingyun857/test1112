namespace netCore.Linq.data1;

public class main
{
    public static void start()
    {
        int numData = 4;
        List<int> list = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 8, 7
        };
        var res1 = list.Where(i => i > numData).OrderDescending().ToList();
        res1.ForEach(Console.WriteLine);
        Console.WriteLine("=======");
        var res2 = MyWhere1(list, a => a > numData);
        res2.ForEach(Console.WriteLine);
        Console.WriteLine("=======");
        var res3 = MyWhere2(list, a => a > numData);
        foreach (var item in res3)
        {
            Console.WriteLine(item);
        }
        
        
    }

    static List<int> MyWhere1(List<int> list, Func<int, bool> func)
    {
        var res = new List<int>();
        foreach (var item in list)
        {
            if (func(item))
            {
                res.Add(item);
            }
        }

        return res;
    }
    static IEnumerable<int> MyWhere2(IEnumerable<int> list, Func<int, bool> func)
    {
        foreach (var item in list)
        {
            if (func(item))
            {
                yield return item;
            }
        }
    }
}