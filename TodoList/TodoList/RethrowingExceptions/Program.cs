
List<int> numbers = new List<int> { };

int hi = ExceptionsRethrowing.GetMaxValue(numbers);
    public static class ExceptionsRethrowing
{
    public static int GetMaxValue(List<int> numbers)
    {
        try
        {
            return numbers.Max();
        }
        catch (ArgumentNullException ex)
        {
            throw new ArgumentNullException("The numbers list cannot be null.", ex);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("The numbers list cannot be empty.");
            throw;
        }


    }
}



public class InvalidTransactionException : Exception
{
    public TransactionData TransactionData { get; }
    public InvalidTransactionException()
    {
       
    }
    public InvalidTransactionException(string message) : base(message)
    {
    }
    public InvalidTransactionException(string message, Exception innerException) :
    base(message, innerException)
    {
    }

    public InvalidTransactionException(string message, TransactionData dt) : base(message)
    {
        TransactionData = dt;   
    }
    public InvalidTransactionException(string message,TransactionData dt, Exception innerException) :
    base(message, innerException)
    {
        TransactionData = dt;   
    }

}
public class TransactionData
{
    public string Sender { get; init; }
    public string Receiver { get; init; }
    public decimal Amount { get; init; }
}
