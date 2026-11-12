namespace netCore.Linq.data2;

public class main
{
    public static void start()
    {
        List<Employee> list = new List<Employee>();
        list.Add(new Employee { Id = 1, Name = "jerry", Age = 28, Gender = true, Salary = 5000 });
        list.Add(new Employee { Id = 2, Name = "jim", Age = 33, Gender = true, Salary = 3000 });
        list.Add(new Employee { Id = 3, Name = "lily", Age = 35, Gender = false, Salary = 9000 });
        list.Add(new Employee { Id = 4, Name = "lucy", Age = 16, Gender = false, Salary = 2000 });
        list.Add(new Employee { Id = 5, Name = "kimi", Age = 25, Gender = true, Salary = 1000 });
        list.Add(new Employee { Id = 6, Name = "nancy", Age = 35, Gender = false, Salary = 8000 });
        list.Add(new Employee { Id = 7, Name = "zack", Age = 35, Gender = true, Salary = 8500 });
        list.Add(new Employee { Id = 8, Name = "jack", Age = 33, Gender = true, Salary = 8000 });

        Console.WriteLine("Where age > 30：");
        var res1 = list.Where(n => n.Age > 30).ToList();
        res1.ForEach(Console.WriteLine);
        Console.WriteLine("Count age > 30");
        var res2 = list.Count(n => n.Age > 30);
        Console.WriteLine(res2);
        Console.WriteLine("Any age > 30");
        var res3 = list.Any(n => n.Age > 30);
        Console.WriteLine(res3);
        Console.WriteLine("跳过2条取3条数据");
        var res4 = list.OrderBy(n => n.Age).Skip(2).Take(3).ToList();
        res4.ForEach(Console.WriteLine);
        Console.WriteLine("按照age分组");
        var res5 = list.GroupBy(n => n.Age);
        foreach (var item in res5)
        {
            Console.WriteLine(item.Key);
            Console.WriteLine("最大工资：" + item.Max(n => n.Salary));
            foreach (var items in item)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine("===========");
        }
        Console.WriteLine("Select");
        var res7 = list.Select(n => n.Age).ToList();
        res7.ForEach(Console.WriteLine);
        Console.WriteLine("var匿名类型使用Select");
        var res8 = list.Select(n => new { xingMing = n.Name, nianLing = n.Age, xingBieNan = n.Gender});
        foreach (var item in res8)
        {
            Console.WriteLine(item.xingMing);
            Console.WriteLine(item.nianLing);
            Console.WriteLine(item.xingBieNan);
        }
        Console.WriteLine("var匿名类型使用GroupBy");
        var res9 = list.GroupBy(e => e.Age).Select(
            n => new { age = n.Key, zuiDa = n.Max(f => f.Salary), zuiXiao = n.Min(f => f.Salary), 
                he = n.Sum(f => f.Salary), renShu = n.Count()});
        foreach (var item in res9)
        {
            Console.WriteLine($"{item.age}-{item.zuiDa}-{item.zuiXiao}-{item.he}-{item.renShu}");
        }
    }
    
    class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; } //姓名
        public int Age { get; set; } //年龄
        public bool Gender { get; set; } //性别
        public int Salary { get; set; } //月薪
        public override string ToString()
        {
            return $"Id={Id},Name={Name},Age={Age},Gender={Gender},Salary={Salary}";
        }
    }
}