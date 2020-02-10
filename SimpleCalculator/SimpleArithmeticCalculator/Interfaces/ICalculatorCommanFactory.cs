using SimpleArithmeticCalculator.Enums;


namespace SimpleArithmeticCalculator.Interfaces
{
    public interface ICalculatorCommandFactory 
    {
         ICalculatorCommand CreateCommand(CommandType commandType);
    }
}
