namespace Ex_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user, user_entrada;
            int senha, user_senha;

            int tentativas = 4;

            Console.Write("Defina seu login: @");
            user = Console.ReadLine();

            Console.Write("Defina sua senha: ");

            while (!int.TryParse(Console.ReadLine(), out senha) || senha <= 0)
            {
                Console.Write("Tentativa de senha errada. Insira somente valores positivos!");
            }

            while (tentativas > 0)
            {
                Console.Write("\nLogin: @");
                user_entrada = Console.ReadLine();

                Console.Write("Senha: ");

                while (!int.TryParse(Console.ReadLine(), out user_senha))
                {
                    Console.Write("Entrada inválida. Insira somente números inteiros: ");
                }

                if (user_entrada == user && user_senha == senha)
                {
                    Console.Write("\nAcesso permitido!");
                    break;
                }
                else
                {
                    tentativas--;
                    Console.Write($"\nAcesso Incorreto! Restam {tentativas} tentativas!");
                }

                if (tentativas == 0)
                {
                    Console.Write("\nAcesso bloqueado!");
                }

            }
        }
    }
}
