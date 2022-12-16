namespace ConsoleApp2
{

   
    public  class Class1
    {
        public void Func1()
        {
            Console.WriteLine("this is a first function..");
        }
        public void Func2()
        {
            Console.WriteLine("this is a second function");
        }
        public static void Main(string[] args)
        {
            string s = "Hello Extension Methods";
            int i = Program.WordCount(s);
            Console.WriteLine(i);


            int[] ints = { 10, 45, 15, 39, 21, 26 };

            var results = ints.OrderBy(g => g);
            foreach (var j in results)
            {
                Console.WriteLine(j + " ");
            }


            int num1 = 314234;
            int result = num1.GetDigits();
            Console.WriteLine("Digits:" + result);
            Class1 p = new Class1();
            p.Func1();
            p.Func2();
            p.Func3();
            Console.ReadLine();

        }
    }
}