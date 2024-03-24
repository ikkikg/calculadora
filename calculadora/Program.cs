namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("calculadora(+,-,*,/)");


            float num1, num2;
            string ope;

            Console.Write("digite o primeiro numero           : ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("digite o sinal da operação desejada: ");
            ope = Console.ReadLine();
            Console.Write("digite o segundo numero            : ");
            num2 = float.Parse(Console.ReadLine());



            if (ope == "+")
            {
                Console.WriteLine("o resultado da soma é              = {0} ", num1 + num2);
                Console.ReadLine();
            }
            else if (ope == "-")
            {
                Console.WriteLine("o resultado da subtração é         = {0} ", num1 - num2);
                Console.ReadLine();
            }
            else if (ope == "*")
            {
                Console.WriteLine("o resultado da multiplicação é     = {0} ", num1 * num2);
                Console.ReadLine();

            }
            else if (ope == "/")
            {
                Console.WriteLine("o resultado da divisão é           = {0} ", num1 / num2);
                Console.ReadLine();
            }
            else
                Console.WriteLine("operação invalida");
            Console.ReadLine();

        }
    }
}
