using SimpleArithmeticCalculator.Enums;


namespace SimpleArithmeticCalculator.Interfaces
{
    public interface ICalculatorCreate 
    {
         ICalculatorCommand CreateCommand(CommandType commandType);
    }
}
