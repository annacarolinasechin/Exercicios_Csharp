namespace Ex_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;

            Console.Write("Insira sua idade: ");

            while(!int.TryParse(Console.ReadLine(), out idade) || idade <= 0)
            {
                Console.Write("\nIdade inválida. Insira somente números inteiros e tente novamente! ");
            }

            Console.WriteLine("\nIdade cadastrada com sucesso!");

            if(idade >= 18)
            {
                Console.Write($"\nVocê é maior de idade ({idade})!");
            }
            else
            {
                Console.Write($"\nVocê é menor de idade ({idade})!");
            }
        }
    }
}
