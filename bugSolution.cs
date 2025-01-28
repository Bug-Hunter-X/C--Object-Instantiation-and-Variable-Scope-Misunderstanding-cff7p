public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass(int value)
    {
        MyProperty = value;
    }

    public static void Main(string[] args)
    {
        MyClass instance = new MyClass(10);
        Console.WriteLine(instance.MyProperty); // Outputs 10

        MyClass instance2 = new MyClass(20);
        Console.WriteLine(instance2.MyProperty); // Outputs 20.  Corrected line.
    }
}