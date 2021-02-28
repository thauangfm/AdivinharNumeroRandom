using System;

namespace AdivinharNúmero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Bem-vindo ao Programa ---");

            Random r = new Random(); // Define uma variável randomica

            int numeroCerto = r.Next(0, 100); // Define a variavel que ficará com algum valor entre 0 e 100

            int tentativas = 5; // Tentativas totais até que o jogo seja finalizado

            bool acabarJogo = false; // Define que o jogo não acabou, caso torne-se True, o jogo acaba

            do
            {
                Console.Write("Digite um número entre 0 e 100: ");
                int i = int.Parse(Console.ReadLine());

                if (tentativas == 1)
                {
                    acabarJogo = true;
                    Console.WriteLine("\nVocê perdeu... O número correto era: " + numeroCerto);
                    Console.Write("\nPressione Enter para finalizar o jogo ");
                    Console.ReadKey();
                }
                else if (i > numeroCerto)
                {
                    tentativas--;
                    Console.WriteLine("\nNúmero alto! Digite um número menor...");
                    switch (tentativas)
                    {
                        case 1:
                            Console.WriteLine($"Você possui {tentativas} tentativa restante!\n");
                            break;
                        default:
                            Console.WriteLine($"Você possui {tentativas} tentativas restantes!\n");
                            break;
                    }
                }
                else if (i < numeroCerto)
                {
                    tentativas--;
                    Console.WriteLine("\nNúmero baixo! Digite um número maior...");
                    switch (tentativas)
                    {
                        case 1:
                            Console.WriteLine($"Você possui {tentativas} tentativa restante!\n");
                            break;
                        default:
                            Console.WriteLine($"Você possui {tentativas} tentativas restantes!\n");
                            break;
                    }
                }
                else
                {
                    acabarJogo = true;
                    Console.WriteLine("\nParabéns, você ganhou! O número correto é: " + i);
                    Console.Write("\nPressione Enter para finalizar o jogo ");
                    Console.ReadKey();
                }
            } while (acabarJogo == false);
        }
    }
}