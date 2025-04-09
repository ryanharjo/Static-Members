namespace Static_Harjo_Ryan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Output for Integer Methods
            Console.WriteLine("Integer Methods");
            // Call the Add method from the Calculate class for two integers and print the result
            Console.WriteLine("10 + 77 equals " + Calculate.Add(10, 77));
            // Call the Subtract method from the Calculate class for two integers and print the result
            Console.WriteLine("43 - 99 equals " + Calculate.Sub(43, 99));
            // Call the Multiply method from the Calculate class for two integers and print the result
            Console.WriteLine("101 * 4 equals " + Calculate.Mult(101, 4));
            // Call the Divide method from the Calculate class for two integers and print the result
            Console.WriteLine("35 / 5 equals " + Calculate.Div(35, 5));

            // Add a newline for separation
            // Output for Float Methods
            Console.WriteLine("\nFloat Methods");
            
            // Call the Add method from the Calculate class for two floats and print the result
            Console.WriteLine("10.44 + 77.87 equals " + Calculate.Add(10.44f, 77.87f));
            // Call the Subtract method from the Calculate class for two floats and print the result
            Console.WriteLine("43.07 - 99.33 equals " + Calculate.Sub(43.07f, 99.33f));
            // Call the Multiply method from the Calculate class for two floats and print the result
            Console.WriteLine("101.30 * 4.69 equals " + Calculate.Mult(101.30f, 4.69f));
            // Call the Divide method from the Calculate class for two floats and print the result
            Console.WriteLine("35.89 / 5.48 equals " + Calculate.Div(35.89f, 5.48f));
        }
    }
}
