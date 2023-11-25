using System;

public class Calculator<T>
{
    public delegate T OperationDelegate(T x, T y);

    public OperationDelegate Add { get; set; }
    public OperationDelegate Subtract { get; set; }
    public OperationDelegate Multiply { get; set; }
    public OperationDelegate Divide { get; set; }

    public Calculator()
    {
        Add = (x, y) => (dynamic)x + y;
        Subtract = (x, y) => (dynamic)x - y;
        Multiply = (x, y) => (dynamic)x * y;
        Divide = (x, y) => (dynamic)x / y;
    }

    public T PerformOperation(T x, T y, OperationDelegate operation)
    {
        if (operation == null)
        {
            Console.WriteLine("Invalid operation");
            return default(T);
        }

        return operation(x, y);
    }
}