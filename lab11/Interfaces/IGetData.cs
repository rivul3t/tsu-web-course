namespace lab11.Interfaces
{
    public interface IGetData
    {
        int firstNumber { get; }
        int secondNumber { get; }
        int Sum();
        int Sub();
        int Mult();
        int Div();
    }
}
