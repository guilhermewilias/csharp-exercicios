// Exercicio 01 : 

/*Faça um programa para calcular o estoque médio de uma peça, sendo que:
ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2
*/

/*
Console.Write("Digite a quantidade minima da peça desejada --> ");
string quantidadeMinima = Console.ReadLine()!;
int quantidadeMinimaNumber = int.Parse(quantidadeMinima); //convertendo string para int

Console.Write("Digite a quantidade maxima da peça desejada --> ");
string quantidadeMaxima = Console.ReadLine()!;
int quantidadeMaximaNumber = int.Parse(quantidadeMaxima); //convertendo string para int 

Console.Write($"\n\nA quantidade minima de peças é {quantidadeMinimaNumber}");
Console.Write($"\nA quantidade máxima de peças é {quantidadeMaximaNumber}");


int somaPecas = (quantidadeMinimaNumber + quantidadeMaximaNumber);
int mediaPecas = (quantidadeMinimaNumber + quantidadeMaximaNumber) / 2;
// int mediaPecas = (quantidadeTotal / 2);

Console.Write($"\nA soma de peças desejadas é {somaPecas}");
Console.Write($"\n\nA media de peças desejadas é {mediaPecas}\n\n\n");
*/


using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;


Dictionary<string, List<int>> historicoPecas = new Dictionary<string, List<int>>();


void menu()
{
    Console.WriteLine("opção 01 -) Cadastrar uma quantidade miníma");
    Console.WriteLine("opção 02 -) Cadastrar uma quantidade máxima");
    Console.WriteLine("opção 03 -) Ver a média de quantidade");
    Console.WriteLine("opção 04 -) Sair do programa");

    Console.WriteLine("\nDIGITE A OPÇÃO QUE DESEJA : ");
    string opcaoSelecionadaMenu = Console.ReadLine()!;
    int opcaoSelecionadaMenuINT = int.Parse(opcaoSelecionadaMenu);

    switch (opcaoSelecionadaMenuINT)
    {
        case 1:
            case1();
            break;
        case 2: 
            case2(); 
            break;
        case 3:
            case3(); 
            break;
        case 4:
            sair();
            break;
    }

    void case1()
    {
        Console.Clear();

        Console.Write("Digite a quantidade mínima --> ");
        string quantidadeMinima = Console.ReadLine()!;
        int quantidadeMinimaINT = int.Parse(quantidadeMinima);

        historicoPecas["Quantidade Mínima"] = new List<int> { quantidadeMinimaINT };

        Console.Write($"\n\nA quantidade mínima com valor de {quantidadeMinimaINT} foi cadastrada com sucesso.");

        Console.WriteLine("\nVoltando ao menu em 3,2,1...\n\n");
        Thread.Sleep(3000);
        Console.Clear();
        menu();
    }

    void case2()
    {
        Console.Clear();

        Console.Write("Digite a quantidade máxima --> ");
        string quantidadeMaxima = Console.ReadLine()!;
        int quantidadeMaximaINT = int.Parse(quantidadeMaxima);

        historicoPecas["Quantidade Máxima"] = new List<int> { quantidadeMaximaINT };

        Console.Write($"\n\nA quantidade máxima com valor de {quantidadeMaximaINT} foi cadastrada com sucesso.");

        Console.WriteLine("\nVoltando ao menu em 3,2,1...\n\n");
        Thread.Sleep(3000);
        Console.Clear();
        menu();
    }

    void case3()
    {
        Console.Clear();

        if (historicoPecas.Count == 0)
        {
            Console.WriteLine("Nenhum valor foi cadastrado");
            return;
        }

        double media = historicoPecas.Average(entry => entry.Value.Average());

        Console.WriteLine($"a média de quantidades cadastradas é {media}");

        Console.WriteLine("\nDigite qualquer tecla para retornar ao menu principal\n\n");
        Console.ReadKey();
        Console.Clear();
        menu();
    }

    void sair()
    {
        Console.Clear();
        Console.WriteLine("Você selecionou a opção 4 : SAIR DO PROGRAMA ");
        Console.WriteLine("\n\nDigite qualquer tecla para fechar o programa");
        Console.ReadKey();
        Environment.Exit(0);
    }
}

menu();

