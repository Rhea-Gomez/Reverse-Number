namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, remainder, reverse = 0, temp;
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());

            temp = num;
            while (temp > 0)
            {
                remainder = temp % 10;
                reverse = 10 * reverse + remainder;
                temp = temp / 10;
            }

            Console.WriteLine("Reverse of " + num + " is " + reverse);
        }
    }
}
