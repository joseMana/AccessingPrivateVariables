using System;
using System.Reflection;

public class MyClass
{
    private int privateVariable = 42;

    private void PrivateMethod()
    {
        Console.WriteLine("Inside private method");
    }
}

class Program
{
    static void Main()
    {
        MyClass myObject = new MyClass();

        // Accessing private variable using reflection
        FieldInfo privateVariableInfo = typeof(MyClass).GetField("privateVariable", BindingFlags.NonPublic | BindingFlags.Instance);
        int value = (int)privateVariableInfo.GetValue(myObject);
        Console.WriteLine($"Private Variable Value: {value}");

        // Accessing private method using reflection
        MethodInfo privateMethodInfo = typeof(MyClass).GetMethod("PrivateMethod", BindingFlags.NonPublic | BindingFlags.Instance);
        privateMethodInfo.Invoke(myObject, null);

        Console.ReadLine();
    }
}
