public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        //This is where the bug happens
        int value = MyProperty + 1;
        if (value > 10) {
            Console.WriteLine("Value is greater than 10");
        }
        //In some cases MyProperty is not initialized leading to unexpected behavior
    }
}