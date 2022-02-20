using System;

namespace CSharpDelegatesBasics
{
    // TODO: Add delegate declaration 
    public delegate string MyDelegate(int arg1, int arg2);

    class MyClass
    {
        // Delegates can be used with static class methods or instance methods
        public string InstanceMethod1(int arg1, int arg2)
        {
            return ((arg1 + arg2) * arg1).ToString();
        }

    }

    class Program
    {
        // Create functions to serve as delegate implementations 
        public static string func1(int a, int b)
        {
            return (a + b).ToString();
        }

        public static string func2(int a, int b)
        {
            return (a * b).ToString();
        }

        static void Main(string[] args)
        {
            MyDelegate f = func1;
            Console.WriteLine("The value of func1 is " + f(10, 20));
            f = func2;
            Console.WriteLine("The value of func2 is " + f(10, 20));

            // Use instance method of a class with a delegate
            MyClass mc = new MyClass();
            f = mc.InstanceMethod1;
            Console.WriteLine("The value of InstanceMethod is " + f(10, 20));
        }

    }
}