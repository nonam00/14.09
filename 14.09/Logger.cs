namespace _14._09;

public class Logger
{
    private string path;
    private string equation = String.Empty;
    public Logger() => path = "TextFile1.txt";

    public Logger(string fileName) =>  path = fileName;

    public void Operation() //ввод чисел реализован прямо в методе, чтобы исключение отрабатывало сразу
    {
        try 
        { 
            double num1 = Convert.ToInt64(Console.ReadLine());
            double num2 = Convert.ToInt64(Console.ReadLine());
            
            if(num2==0)
                throw new DivideByZeroException("Попытка деления на 0");

            equation = $"{num1} / {num2} = ";
            equation += $"{num1 / num2}";
        }
        catch (Exception ex)
        {
            Except(ex);
        }
    }
    public override string ToString() => equation;

    public void Except(Exception ex) => equation += ex.Message;

    public void Logging()
    {
        using StreamWriter sw = new(path, true);
        sw.WriteLine(equation);
    }
}
