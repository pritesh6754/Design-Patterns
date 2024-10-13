namespace DemoDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 != s2)
            {
                Console.WriteLine("Not Sharing the same resource");

            }
            else
            {
                Console.WriteLine("Sharing the same resource");
            }
        }
    }
}