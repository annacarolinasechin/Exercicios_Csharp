namespace Ex_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, soma, sub;

            Console.Write("Insira o primeiro número: ");

            while (!float.TryParse(Console.ReadLine(), out num1) || num1 <= 0)
            {
                Console.Write("Entrada inválida. Insira somente números positivos e tente novamente! ");
            }

            Console.Write("Insira o segundo número: ");

            while (!float.TryParse(Console.ReadLine(), out num2) || num2 <= 0)
            {
                Console.Write("Entrada inválida. Insira somente números positivos e tente novamente!");
            }

            soma = num1 + num2;
            sub = num1 - num2;

            Console.Write($"\nA soma dos valores resulta em: {soma}");
            Console.Write($"\nA subtração dos valores resulta em: {sub}");

        }
    }
}
