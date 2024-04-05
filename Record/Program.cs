namespace Record
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student std1 = new Student() { Name = "Kamil", Surname = "Qehremanov" };
            Student std2 = new Student() { Name = "Anar", Surname = "Amanli" };
            Student std3 = new Student();
            
            Console.WriteLine(std1);
            Console.WriteLine(std2);
            Console.WriteLine(std3);
            Console.WriteLine(std1 == std2);
            \


            Human human =new Human() {Name = "Kamil",Surname = "Qehremanov",Age = 20 };

        }
        internal record Student
        {
            public string Name { get; init; } = "YYY";
            public string Surname { get; init; } = "XXX";

        }
        internal record Human 
        {
           public string Name { get; init; }
           public string Surname { get; init; }
            public int Age { get; init; }
        }
    }
}
