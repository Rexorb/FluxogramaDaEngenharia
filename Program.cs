Console.WriteLine("Bem vindo ao Fluxograma da Engenharia");
Console.WriteLine("Pense em um objeto e diga se ele se move (S para Sim, N para Não):");
string respostaInicial = Console.ReadLine()?.ToUpper() ?? "N";

if (respostaInicial == "S")
{
    Console.WriteLine("Ele deveria se mover? (S para Sim, N para Não):");
    string respostaDeveria = Console.ReadLine()?.ToUpper() ?? "N";

    if (respostaDeveria == "S")
    {
        Console.WriteLine("Ótimo");
    }
    else
    {
        Console.WriteLine("Use Silver Tape");
    }
}
else if (respostaInicial == "N") 
{
    Console.WriteLine("Ele deveria se mover? (S para Sim, N para Não):");
    string respostaDeveria = Console.ReadLine()?.ToUpper() ?? "N";

    if (respostaDeveria == "S")
    {
        Console.WriteLine("Use WD-40");
    }
    else
    {
        Console.WriteLine("Ótimo");
    }
}
else
{
    Console.WriteLine("Resposta inválida. Considere S ou N.");
}
