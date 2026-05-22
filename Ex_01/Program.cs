namespace Ex_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
        float num1, num2, soma, sub;

            Console.Write("Insira um número: ");

            while (!float.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Valor inválido, tente novamente!");
            }

            Console.Write("Insira um número: ");

            while (!float.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Valor inválido, tente novamente!");
            }

            soma = num1 + num2;
            sub = num1 - num2;

            Console.WriteLine($"\nA soma dos valores resulta em: {soma}");
            Console.Write($"A subtração dos valores resulta em: {sub}");

            Console.ReadKey();
        }
    }
}
