public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass(int initialValue)
    {
        MyProperty = initialValue;
    }

    public void MyMethod()
    {
        int value = MyProperty + 1;
        if (value > 10)
        {
            Console.WriteLine("Value is greater than 10");
        }
    }

    //Or
    public void MyMethod2()
    {
        // Initialize the property before using it
        MyProperty = 5; //Example Value
        int value = MyProperty + 1;
        if (value > 10)
        {
            Console.WriteLine("Value is greater than 10");
        }
    }
} 