namespace ExceptionHandling
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();
            
            Console.WriteLine("Entre com dois número inteiros para realizarmos a operação: ");

            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by 0 is not allowed!");
            }
            catch(FormatException e)
            {
                Console.WriteLine("Error!" + e.Message);
            }
        }
    }
}
