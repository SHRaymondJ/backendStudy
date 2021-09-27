using System;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎使用移动充值业务，请输入充值金额:");
            string x = Console.ReadLine();
            Console.WriteLine("充值成功，您的充值金额为：" + x + "元");
        }
    }
}
