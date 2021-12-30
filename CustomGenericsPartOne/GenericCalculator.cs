public class GenericCalculator<T>
{
    public T Add(T firstNumber,T secondNumber){
        /*
        Not possible to use '+' operand with firstNumber and secondNumber as the 
        function is not aware the type.

        Solution - use dynamic so that the type is taken during runtime.
        
        */
       dynamic num1= firstNumber;
        dynamic num2=secondNumber;
        return num1+num2;
    }
}