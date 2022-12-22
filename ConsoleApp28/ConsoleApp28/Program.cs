
using System;
namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {

            double? pi = 3.14;

            char? letter = 'a';

            int m2 = 10;

            int? m = m2;

            bool? flag = null;

            int?[] arr = new int?[10];

            int? a = 42;

            if (a is int valueOfA)

            {

                Console.WriteLine($"a is {valueOfA}");

            }

            else

            {

                Console.WriteLine("a does not have a value");

            }

            if (a.HasValue)

            {

                Console.WriteLine($"a is {a.Value}");

            }

            else

            {

                Console.WriteLine("a does not have a value");

            }

            int? f = 7;

            if (f != null)

            {

                Console.WriteLine($"f is {f.Value}");

            }

            else

            {

                Console.WriteLine("f does not have a value");

            }

            int? c = 28;

            int b = c ?? -1;

            Console.WriteLine($"b is {b}");

            int? e = null;

            int d = e ?? -1;

            Console.WriteLine($"d is {d}");

            //int? n = null;

            ////int m1 = n;   

            //// Doesn't compile

            //int n2 = (int)n;

            // Compiles, but throws an exception if n is null

            int? a2 = 10;

            int? b2 = null;

            int? c2 = 10;

            a++;

            // a is 11

            a2 = a2 * c2;

            // a is 110

            a2 = a2 + b2;

            // a is null

            int? a3 = 10;

            Console.WriteLine($"{a3} >= null is {a3 >= null}");

            Console.WriteLine($"{a3} < null is {a3 < null}");

            Console.WriteLine($"{a3} == null is {a3 == null}");

            // Output:

            // 10 >= null is False

            // 10 < null is False

            // 10 == null is False

            int? b3 = null;

            int? c3 = null;

            Console.WriteLine($"null >= null is {b3 >= c3}");

            Console.WriteLine($"null == null is {b3 == c3}");

            // Output:

            // null >= null is False

            // null == null is True

            int a4 = 41;

            object a4Boxed = a4;

            int? a4Nullable = (int?)a4Boxed;

            Console.WriteLine($"Value of a4Nullable: {a4Nullable}");

            object a4NullableBoxed = a4Nullable;

            if (a4NullableBoxed is int ValueOfa4)

            {

                Console.WriteLine($"a4NullableBoxed is boxed int: {ValueOfa4}");
            }

            Console.WriteLine($"int? is {(IsNullable(typeof(int?)) ? "nullable" : "non nullable")} value type");

            Console.WriteLine($"int is {(IsNullable(typeof(int)) ? "nullable" : "non- nullable")} value type");

            bool IsNullable(Type type) => Nullable.GetUnderlyingType(type) != null;

            // output

            // int? is nullable value type

            // int is non - nullable value type

            int? a5 = 17;

            Type typeOfa5 = a5.GetType();

            Console.WriteLine(typeOfa5.FullName);

            // output

            // system.int32

            int? a6 = 14;

            if (a6 is int)

            {

                Console.WriteLine("int? instance is compatible with int");

            }

            int b5 = 17;

            if (b5 is int?)
            {

                Console.WriteLine("int instance is compatible with int?");

            }

            // output

            // int? instance is compatible with int

            // int instance is compatible with int?






           
        }
    }
}