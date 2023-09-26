namespace _14._09;

public class Logger
{
    private string path;
    private string equation = String.Empty;

    public Logger() => path = "D:\\Райский\\14.09\\14.09\\TextFile1.txt";

    public Logger(string fileName) =>  path = fileName;

    public void Operation(int a, int b)
    {
        equation = $"{a} / {b} = ";

        try { equation += $"{a / b}"; }
        catch (Exception ex) { Except(ex); }
    }
    public override string ToString() => equation;

    public void Except(Exception ex) => equation += ex.Message;

    public void Logging()
    {
        using StreamWriter sw = new(path, true);
        sw.WriteLine(equation);
    }
}
