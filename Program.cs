namespace JogoDeAdivinhação;

class Program
{
    static void Main(string[] args)
    {
        string jogarNovamente;
        
        do
        {
            // Gera um número aleatório entre 1 e 20
            Random numAleatorio = new Random();
            int numSecreto = numAleatorio.Next(1, 21); // Armazena o número secreto
            int tentativas = 0; // Contador para o número de tentativas do jogador
            int tent = 0; // Variável que armazenará as tentativas do jogador
            string entrada; // Variável que armazenará a entrada que o jogador digitar

            Console.WriteLine("\nBem-vindo ao Jogo de Adivinhação! \nTente adivinhar o número secreto entre 1 e 20.\nDigite 'sair' a qualquer momento para encerrar.");//Instrunções para o jogo

            // Laço que garante que o jogador tenha pelo menos uma tentativa antes de verificar a condição de saída
            do
            {
                // Solicita que o jogador insira uma tentativa
                Console.Write("\nDigite sua tentativa: ");
                entrada = Console.ReadLine();

                // Verifica se o jogador digitou "sair" para encerrar o jogo
                if (entrada.Equals("sair", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Você saiu do jogo.");// informa ao jogador que ele decidiu sair
                    break; // Interrompe o laço se o jogador decidir sair
                }

                    // Verifica se a entrada é um número válido
                    if (int.TryParse(entrada, out tent)) // Converte a entrada para um número inteiro
                    {
                    tentativas++; // Conta as tentativas realizadas pelo jogador

                    // Compara a tentativa com o número secreto
                    if(tent < 1 || tent > 20){
                        Console.WriteLine("Número inválido! O número deve estar entre 1 e 20");// Informa se o número digitado não estiver entre 1 e 20
                    }
                    else if (tent < numSecreto)
                    {
                        Console.WriteLine("O número secreto é maior do que " + tent + "."); // Informa que o número secreto é maior
                    }
                    else if (tent > numSecreto)
                    {
                        Console.WriteLine("O número secreto é menor do que " + tent + "."); // Informa que o número secreto é menor
                    }
                    // Se a tentativa for igual ao número secreto, o jogador vence
                    else
                    {   if(tentativas == 1){
                        Console.WriteLine("Parabéns! O número secreto é " + numSecreto + ", você acertou com " + tentativas + " tentativa.");
                        }//Se o usuário acertar de primeira, a quantidade de tentativas fica no singular
                        else{
                        Console.WriteLine("Parabéns! O número secreto é " + numSecreto + ", você acertou com " + tentativas + " tentativas.");
                        }//Se o usuário NÃO acertar de primeira, a quantidade de tentativas fica no plural
                    }
                }
                else
                {
                    // Mensagem de erro quando a entrada não for um número válido
                    Console.WriteLine("Entrada inválida! Por favor, digite um número válido.");
                }

            // O laço continua até que o jogador acerte o número secreto
            } while (tent != numSecreto);

            // Após o término de uma partida, pergunta se jogador quer jogar novamente
            Console.Write("\nDeseja jogar novamente? (sim/não): ");
            jogarNovamente = Console.ReadLine(); // Armazena a resposta do jogador

        // O laço é executado novamente se o jogador escolher "sim"
        } while (jogarNovamente.Equals("sim", StringComparison.OrdinalIgnoreCase));

        // Mensagem de despedida ao jogador
        Console.WriteLine("Obrigado por jogar! Até a próxima.\n");
    }
}
