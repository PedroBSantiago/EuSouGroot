Console.Clear();
bool groot = true;
string resposta;
 Console.WriteLine("--- Groot Chatbot ---");

while (groot)
{
    Console.Write($"Pergunta: ");
    resposta = Console.ReadLine()!;
    Console.WriteLine("Resposta: Eu sou Groot.");

    if (resposta == "Tchau")
    {

        break;
}
}

