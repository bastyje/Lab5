namespace Lab5.Lib;

public interface ICalculator
{
    int Sum(int x, int y);
    int Substract(int x, int y);
    int Multiply(int x, int y);
    int Divide(int x, int y);
}

public class Calculator : ICalculator
{
    public int Sum(int x, int y)
    {
        return x + y;
    }

    public int Substract(int x, int y)
    {
        return x - y;
    }

    public int Multiply(int x, int y)
    {
        return x * y;
    }

    public int Divide(int x, int y)
    {
        if (y == 0) throw new ArgumentException("y must not be 0");
        return x / y;
    }
}
