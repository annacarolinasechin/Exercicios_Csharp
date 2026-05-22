namespace Ex_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Insira um número: ");

            while(!int.TryParse(Console.ReadLine(), out num) || num <= 0)
            {
                Console.Write("Entrada Inválida. Insira somente numeros inteiros positivos e tente novamente! ");
            }

            if(num % 2 == 0)
            {
                Console.Write($"\nO valor inserido é: PAR ({num}).");
            }
            else
            {
                Console.Write($"\nO número inserido é: ÍMPAR ({num})");
            }
        }
    }
}
