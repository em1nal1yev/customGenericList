namespace customGenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>();
            intList.Add(2);
            intList.Add(1);
            //Console.WriteLine(intList.Find(s => s % 2 == 0));
            Console.WriteLine(intList.Remove(1));
            
            


            CustomList<string> stringList = new CustomList<string>();
            stringList.Add("Emin");
            stringList.Add("Salam");
            stringList.Add("Elvin");
            Console.WriteLine(stringList.Find(x => x.StartsWith("E")));
            Console.WriteLine(stringList.FindAll(x => x.StartsWith("E")));



        }
    }
}
