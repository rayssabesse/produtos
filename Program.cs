using System;

namespace produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayl = 10;
            string[] name = new string[arrayl];
            float[] price = new float[arrayl];
            string[] promotion = new string[arrayl];
            int i = 0;
            string answer = "s";
            string menu;
            bool a = true;



            while (a == true)
            {
                Console.WriteLine("Digite a senha: ");
                string password = Console.ReadLine();

                if (password == "123456")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("|======================================|");
                    Console.WriteLine("|      Escolha o que deseja fazer      |");
                    Console.WriteLine("|--------------------------------------|");
                    Console.WriteLine("|      1 - Cadastar Produtos           |");
                    Console.WriteLine("|      2 - Listar Produtos             |");
                    Console.WriteLine("|      3 - Mostrar Menu                |");
                    Console.WriteLine("|      0 - Sair                        |");
                    Console.WriteLine("|======================================|");
                    Console.ForegroundColor = ConsoleColor.White;
                    menu = Console.ReadLine();

                    switch (menu)
                    {
                        case "1":
                            do
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Qual o nome do produto?");
                                Console.ForegroundColor = ConsoleColor.White;
                                name[i] = Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Qual o preço do produto?");
                                Console.ForegroundColor = ConsoleColor.White;
                                price[i] = float.Parse(Console.ReadLine());

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("|======================================|");
                                Console.WriteLine("|     O produto está em promoção?      |");
                                Console.WriteLine("|--------------------------------------|");
                                Console.WriteLine("|     S - sim                          |");
                                Console.WriteLine("|     N - não                          |");
                                Console.WriteLine("|======================================|");
                                Console.ForegroundColor = ConsoleColor.White;
                                promotion[i] = Console.ReadLine();

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("|======================================|");
                                Console.WriteLine("|   Deseja cadastrar outro produto?    |");
                                Console.WriteLine("|--------------------------------------|");
                                Console.WriteLine("|   S - sim                            |");
                                Console.WriteLine("|   N - não                            |");
                                Console.WriteLine("|======================================|");
                                Console.ForegroundColor = ConsoleColor.White;
                                answer = Console.ReadLine();

                                i++;
                            } while (answer == "s");

                            break;

                        case "2":

                            for (var c = 0; c < arrayl; c++)
                            {
                                Console.WriteLine($"Nome do Produto: " + name[c]);
                                Console.WriteLine($"Preço do Produto: R$" + price[c]);
                                Console.WriteLine($"Está em promoção?: " + promotion[c] + "\n");
                            }
                            break;

                        case "3":
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("|======================================|");
                            Console.WriteLine("|      Escolha o que deseja fazer      |");
                            Console.WriteLine("|--------------------------------------|");
                            Console.WriteLine("|      1 - Cadastar Produtos           |");
                            Console.WriteLine("|      2 - Listar Produtos             |");
                            Console.WriteLine("|      3 - Mostrar Menu                |");
                            Console.WriteLine("|      0 - Sair                        |");
                            Console.WriteLine("|======================================|");
                            Console.ForegroundColor = ConsoleColor.White;
                            menu = Console.ReadLine();

                            break;

                        case "4":
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Obrigado por utilizar nosso sistema!");
                            Console.ForegroundColor = ConsoleColor.White;
                            a = false;
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Senha Incorreta. Tente Novamente.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

        }
    }
}
