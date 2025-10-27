namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // using class without Generics
            intBox intbox = new intBox();
            intbox.Value = 1;

            StringBox stringbox = new StringBox();
            stringbox.Value = "Test casual";

            Console.WriteLine(intbox.Value);
            Console.WriteLine(stringbox.Value);

            // using Class with Generics
            // Can describe type of Value during creating instance of Generic class
            Box<int> box1 = new Box<int>();
            box1.Value = 5;

            Box<string> box2 = new Box<string>();
            box2.Value = "Test Generics";

            Console.WriteLine(box1.Value);
            Console.WriteLine(box2.Value);
        }

        // Instead of writing class like below:
        class intBox { 
            public int Value;
        }

        class StringBox { 
            public string Value;
        }

        // Class with Generics
        // Don't have to describe type of Value
        class Box<T> {
            public T Value;
        }
    }
}
