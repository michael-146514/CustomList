namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> MyList = new CustomList<string>();
            Console.WriteLine(MyList[2]);
        }
    }
}