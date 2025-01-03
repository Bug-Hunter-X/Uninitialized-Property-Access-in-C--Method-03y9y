public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize MyProperty in the declaration

    public void MyMethod()
    {
        // Initialize MyProperty before using it
        MyProperty = 10; 
        int value = MyProperty * 2; // Now it's safe
        Console.WriteLine(value); // Output: 20
    }
} 
//Alternative Solution: Initialize in the constructor
public class ExampleClass
{
    public int MyProperty { get; set; }

    public ExampleClass()
    {
        MyProperty = 5; // Initialize in constructor
    }

    public void MyMethod()
    {
        int value = MyProperty * 2; // Now it's safe
        Console.WriteLine(value); // Output: 10
    }
} 