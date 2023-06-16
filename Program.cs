// deixando claro apenas que eu percebi que existe um int e uma sub-rotina com o mesmo nome, fiz assim porque achei mais fácil pra mim.



Random random = new Random();
int numeroAleatorio = random.Next(1, 101);
int resposta = 1;   
int tentativas = 0;

mensagem("-- Quente ou frio --");
mensagem("Pressione ENTER para continuar");
Console.ReadLine();
mensagem("Gerando um número...");
Thread.Sleep(600);
mensagem("Aguarde o número ser gerado...");
Thread.Sleep(800);
mensagem("Número aleatório gerado...");
mensagem("Este número está presente no intervalo entre 1 e 100... ");
mensagem("Digite um número para tentar acertar o número aleatório... ");

while(resposta != numeroAleatorio)
    {
            resposta = int.Parse(Console.ReadLine()!);
            int distancia;
            distancia = Math.Abs(resposta - numeroAleatorio);
            tentativas++;

            if (resposta > 0 && resposta < 100)
            {
            if (tentativas > 7)
            {
                corzinha("A quantidade de tentativas foi alcançada...", ConsoleColor.Red);
                return;
            }
            
            else if (distancia <= 3 && distancia >= 1)
            {
                corzinha("Está PELANDO, o número escrito está bem próximo! ", ConsoleColor.DarkYellow);
                corzinha("Digite outro número...", ConsoleColor.DarkMagenta);
            }
            else if (distancia <= 10 && distancia > 3)
            {
                corzinha("Está QUENTE, continue tentando! ", ConsoleColor.Yellow);
                corzinha("Digite outro número...", ConsoleColor.DarkMagenta);
            }
            else if (distancia <= 30 && distancia > 10)
            {
                corzinha("Está FRIO, tente outro número! ", ConsoleColor.DarkBlue);
                distancia2();
                corzinha("Digite outro número...", ConsoleColor.DarkMagenta);
            }
            else if (distancia > 30)
            {
                corzinha("Está CONGELANDO, o número digitado está longe do que eu pensei! ", ConsoleColor.Blue);
                distancia2();
                corzinha("Digite outro número...", ConsoleColor.DarkMagenta);
            }
            }

            else
            {
                corzinha("Digite um valor entre 1 e 100 ", ConsoleColor.Red);
                return;
            }
    }
        
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Parabéns, você acertou o número aleatório! O número era ({numeroAleatorio}), a quantidade de tentativas foram ({tentativas}).");
Console.ResetColor();

void corzinha(string mensagem, ConsoleColor corMensagem)
{
Console.ForegroundColor = corMensagem;
Console.WriteLine(mensagem);
Console.ResetColor();
}

void distancia2()
{
    if (resposta - numeroAleatorio < 0)
    {
        Console.WriteLine("O número aleatório é maior que o número digitado.");
        Console.WriteLine("");
    }
    else 
    {
        Console.WriteLine("O número aleatório é menor que o número digitado.");
        Console.WriteLine("");
    }
}

void mensagem(string mensagem2)
{
    Console.WriteLine(mensagem2);
    Console.WriteLine("");
}