Console.Clear();
bool groot = true;
string resposta;
 Console.WriteLine("--- Groot Chatbot ---");

while (groot)
{

    Console.Write($"Pergunta: ");
    resposta = Console.ReadLine()!;


    if (resposta != "Tchau")
    {
        Console.WriteLine("Resposta: Eu sou Groot");

    }
    else if (resposta == "Tchau")
    {
        Console.WriteLine("Resposta: Eu sou Groot!");

        break;
   }
}

