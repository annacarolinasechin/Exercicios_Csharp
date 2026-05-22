namespace Ex_07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcao;
            bool menu = true;

            while (menu)
            {
                Console.WriteLine("\n1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Sair");

                Console.Write("\nInsira a opção desejada: ");
                while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 3)
                {
                    Console.Write("\nOpção inválida. Tente novamente: ");
                }

                if (opcao == 1)
                {
                    Console.WriteLine("\nOpção escolhida: Somar.");
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("\nOpção escolhida: Subtrair.");
                }
                else
                {
                    Console.WriteLine("\nOpção escolhida: Sair.");
                    menu = false;
                }
            }

        }
    }
}
