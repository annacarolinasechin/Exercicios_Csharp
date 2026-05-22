namespace Ex_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.Write("Insira um número: ");

            while(!int.TryParse(Console.ReadLine(), out num) || num <= 0) {
                Console.Write("Número inválido! Insira somente valores positivos e tente novamente!");
            }

            if(num > 0)
            {
                Console.Write($"\nO valor inserido é POSITIVO ({num})!");
            }
            else
            {
                Console.Write($"\nO valor inserido é NEGATIVO ({num})");
            }

        }
    }
}
