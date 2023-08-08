namespace CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CustomList<int> list1 = new CustomList<int>();
            //list1.Add(1);
            //list1.Add(2);
            //list1.Add(3);

            //CustomList<int> list2 = new CustomList<int>();
            //list2.Add(2);
            //list2.Add(3);
            //list2.Add(5);
            //list2.Add(3);

            //CustomList<int> result = list1 - list2;

            //Console.WriteLine(result);

            //list1.ToString();
            //Console.WriteLine(list1);

            CustomList<int> list1 = new CustomList<int> { 3, 3, 3 };
            CustomList<int> list2 = new CustomList<int> { 1, 2, 3 };

            // Act
            CustomList<int> result = list1 - list2;

            // Assert
            Console.WriteLine(result);
        }
    }
}