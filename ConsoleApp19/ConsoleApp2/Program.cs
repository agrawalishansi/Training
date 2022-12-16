namespace ConsoleApp2
{
    public static class Program
    {
        
            public static int WordCount(this string str)
            {
                return str.Split(new char[] { ' ', '.', '?' },
                                 StringSplitOptions.RemoveEmptyEntries).Length;
               
            }
        
    }
}