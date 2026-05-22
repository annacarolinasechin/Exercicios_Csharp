namespace Ex_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, num3, media;

            Console.Write("Insira o primeiro número: ");

            while(!float.TryParse(Console.ReadLine(), out num1) || num1 <= 0)
            {
                Console.Write("Valor inválido! Insira somente valores positivos e tente novamente! ");
            }

            Console.Write("Insira o segundo número: ");

            while (!float.TryParse(Console.ReadLine(), out num2) || num2 <= 0)
            {
                Console.Write("Valor inválido! Insira somente valores positivos e tente novamente! ");
            }

            Console.Write("Insira o terceiro número: ");

            while (!float.TryParse(Console.ReadLine(), out num3) || num3 <= 0)
            {
                Console.Write("Valor inválido! Insira somente valores positivos e tente novamente! ");
            }

            media = (num1 + num2 + num3) / 3;

            Console.Write($"\nA MÉDIA dos valores inseridos resulta em: {media}");
        }
    }
}
