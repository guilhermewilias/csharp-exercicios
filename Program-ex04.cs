/*
Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição e multiplicação entre os 
valores lidos, baseando-se na utilização do conceito de propriedade distributiva. 

Dica: se forem lidas as variáveis A, B, C e D, devem ser somados e multiplicados os valores de A com B, A com C e A com D; depois B com C, B 
com D e por último C com D.

Note que para cada operação serão utilizadas seis combinações. Assim sendo, 
devem ser realizadas doze operações de processamento, sendo seis para as adições e seis para as 
multiplicações.
*/

/*
using System;

Console.Write("Digite o primeiro número -->  ");
double primeiroNumero = double.Parse(Console.ReadLine());


Console.Write("\nDigite o segundo número --> ");
double segundoNumero = double.Parse(Console.ReadLine());

Console.Write("\nDigite o terceiro número --> ");
double terceiroNumero = double.Parse(Console.ReadLine());

Console.Write("\nDigite o quarto número --> ");
double quartoNumero = double.Parse(Console.ReadLine());

Console.Write($"\n\nO primeiro numero digitado foi --> {primeiroNumero}");
Console.Write($"\nO segundo numero digitado foi --> {segundoNumero}");
Console.Write($"\nO terceiro numero digitado foi --> {terceiroNumero}");
Console.Write($"\nO quarto numero digitado foi --> {quartoNumero}\n\n\n\n");
*/
//Operações do primeiroNumero : 


using System.Net.Http.Headers;

Dictionary<string, List<double>> historicoNumeros = new Dictionary<string, List<double>>();

void instrucoes() //Menu de instruções
{
    Console.WriteLine("*****Siga as instruções*****");

    Console.WriteLine("\nTecle 1 - Cadastre o primeiro número");
    Console.WriteLine("Tecle 2 - Cadastre o segundo número");
    Console.WriteLine("Tecle 3 - Cadastre o terceiro número");
    Console.WriteLine("Tecle 4 - Cadastre o quarto número");

    Console.WriteLine("\n\n---------------------------------------");

    Console.WriteLine("\n\n\n*****Operações dos números*****");
    Console.WriteLine("\nTecle 5 - Visualizar operações do primeiro número");
    Console.WriteLine("Tecle 6 - Visualizar operações do segundo número");
    Console.WriteLine("Tecle 7 - Visualizar operações do terceiro número");
    Console.WriteLine("Tecle 8 - Visualizar operações do quarto número");
    Console.WriteLine("Tecle 9 - Visualizar historico de numeros registrados");

    Console.WriteLine("\n\nTecle a opção desejada : ");
    string opcaoUsuario = Console.ReadLine()!;
    int opcaoUsuarioNumber = int.Parse(opcaoUsuario)!;

    switch (opcaoUsuarioNumber) //Opções para o usuário selecionar
    {
        case 1:
            primeiroNumero();
            break;
        case 2:
            segundoNumero();
            break;
        case 3:
            terceiroNumero();
            break;
        case 4:
            quartoNumero();
            break;
        case 5:
            operacoesNumeroA();
            break;
        case 6:
            operacoesNumeroB();
            break;
        case 7:
            operacoesNumeroC();
            break;
        case 8:
            operacoesNumeroD();
            break;
        case 9:
            mostrarHistorioNumeros();
            break;
    }

    void primeiroNumero() //Função nº 1
    {
        Console.Clear();
        
        Console.WriteLine("Tecle aqui o primeiro número que você deseja cadastrar --> ");
        double numeroA = double.Parse(Console.ReadLine()!); //setando um double e fazendo o console ler a digitação do usuário
        Console.WriteLine($"O primeiro número que você cadastrou foi : {numeroA}");

        historicoNumeros["Primeiro número"] = new List<double> { numeroA }; //Adicionando o item "Primeiro número" a lista de dicionário. 

        //Retorno ao menu :
        Console.WriteLine("\n\nVoltando para as instruções em 3,2,1...");
        Thread.Sleep(2650);
        Console.Clear();
        instrucoes();
    }

    void segundoNumero()
    {
        Console.Clear() ;

        Console.WriteLine("Tecle aqui o segundo número que você deseja cadastrar --> ");
        double numeroB = double.Parse(Console.ReadLine()!);//setando um double e fazendo o console ler a digitação do usuário
        Console.WriteLine($"O segundo número que você cadastrou foi : {numeroB}");

        historicoNumeros["Segundo número"] = new List<double> { numeroB };//Adicionando o item "Segundo número" a lista de dicionário. 

        //Retorno ao menu
        Console.WriteLine("\n\nVoltando para as instruções em 3,2,1...");
        Thread.Sleep(2650);
        Console.Clear();
        instrucoes();
    }

    void terceiroNumero()
    {
        Console.Clear();

        Console.WriteLine("Tecle aqui o terceiro número que você deseja cadastrar --> ");
        double numeroC = double.Parse(Console.ReadLine()!);//setando um double e fazendo o console ler a digitação do usuário
        Console.WriteLine($"O terceiro número que você cadastrou foi : {numeroC}");

        historicoNumeros["Terceiro número"] = new List<double> { numeroC }; //Adicionando o item "Terceiro número" a lista de dicionário. 

        //Retorno ao menu
        Console.WriteLine("\n\nVoltando ao menu em 3,2,1...");
        Thread.Sleep(2650);
        Console.Clear();
        instrucoes();
    }

    void quartoNumero()
    {
        Console.Clear();

        Console.WriteLine("Tecle aqui o quarto número que você deseja cadastrar --> ");
        double numeroD = double.Parse(Console.ReadLine()!);//setando um double e fazendo o console ler a digitação do usuário
        Console.WriteLine($"O quarto número que você cadastrou foi : {numeroD}");

        historicoNumeros["Quarto número"] = new List<double> { numeroD }; //Adicionando o item "Quarto número" a lista de dicionário. 


        //Retorno ao menu
        Console.WriteLine("\n\nVoltando ao menu em 3,2,1...");
        Thread.Sleep(2650);
        Console.Clear();
        instrucoes();
    }

    void operacoesNumeroA()
    {
        Console.Clear();

        Console.WriteLine("Esta opção mostra todas as operações que foram feitas no numero A (primeiro número)");

        double somaNumeros = historicoNumeros.Sum(entry => entry.Value.Sum());
        double multiplicacaoNumeros = historicoNumeros.Average(entry => entry.Value.Average());

        Console.WriteLine(somaNumeros);
        Console.WriteLine(multiplicacaoNumeros);

        //Retorno ao menu
        Console.WriteLine("\n\nVoltando ao menu em 3,2,1...");
        Thread.Sleep(2650);
        Console.Clear();
        instrucoes();
    }

    void operacoesNumeroB()
    {
        Console.Clear();

        Console.WriteLine("Esta opção mostra todas as operações que foram feitas no numero B (segundo número)");

        double somaNumeros = historicoNumeros.Sum(entry => entry.Value.Sum());
        double multiplicacaoNumeros = historicoNumeros.Average(entry => entry.Value.Average());

        Console.WriteLine(somaNumeros);
        Console.WriteLine(multiplicacaoNumeros);

        //Retorno ao menu
        Console.WriteLine("\n\nVoltando ao menu em 3,2,1...");
        Thread.Sleep(2650);
        Console.Clear();
        instrucoes();

        
    }

    void operacoesNumeroC()
    {
        Console.Clear();

        Console.WriteLine("Esta opção mostra todas as operações que foram feitas no numero C (terceiro número)");

        double somaNumeros = historicoNumeros.Sum(entry => entry.Value.Sum());
        double multiplicacaoNumeros = historicoNumeros.Average(entry => entry.Value.Average());

        Console.WriteLine(somaNumeros);
        Console.WriteLine(multiplicacaoNumeros);


        //Retorno ao menu
        Console.WriteLine("\n\nVoltando ao menu em 3,2,1...");
        Thread.Sleep(2650);
        Console.Clear();
        instrucoes();
    }

    void operacoesNumeroD()
    {
        Console.Clear();

        Console.WriteLine("Esta opção mostra todas as operações que foram feitas no numero D (quarto número)");

        double somaNumeros = historicoNumeros.Sum(entry => entry.Value.Sum());
        double multiplicacaoNumeros = historicoNumeros.Average(entry => entry.Value.Average());

        Console.WriteLine(somaNumeros);
        Console.WriteLine(multiplicacaoNumeros);


        //Retorno ao menu
        Console.WriteLine("\n\nVoltando ao menu em 3,2,1...");
        Thread.Sleep(2650);
        Console.Clear();
        instrucoes();
    }

    void mostrarHistorioNumeros()
    {
        Console.Clear();

        Console.WriteLine($"O historico de todos os números digitados é : {historicoNumeros}");


        //Retorno ao menu
        Console.WriteLine("\n\nTecle qualquer letra para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        instrucoes();
    }

}

instrucoes();

/*
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    static Dictionary<string, double> historicoNumeros = new Dictionary<string, double>();

    static void Main()
    {
        Instrucoes();
    }

    static void Instrucoes() //Menu de instruções
    {
        Console.WriteLine("*****Siga as instruções*****");

        Console.WriteLine("\nTecle 1 - Cadastre o primeiro número");
        Console.WriteLine("Tecle 2 - Cadastre o segundo número");
        Console.WriteLine("Tecle 3 - Cadastre o terceiro número");
        Console.WriteLine("Tecle 4 - Cadastre o quarto número");

        Console.WriteLine("\n\n---------------------------------------");

        Console.WriteLine("\n\n\n*****Operações dos números*****");
        Console.WriteLine("Tecle 5 - Realizar operações de adição e multiplicação");
        Console.WriteLine("Tecle 6 - Visualizar histórico de números registrados");

        Console.WriteLine("\n\nTecle a opção desejada : ");
        string opcaoUsuario = Console.ReadLine();
        int opcaoUsuarioNumber = int.Parse(opcaoUsuario);

        switch (opcaoUsuarioNumber)
        {
            case 1:
                CadastrarNumero("Primeiro número");
                break;
            case 2:
                CadastrarNumero("Segundo número");
                break;
            case 3:
                CadastrarNumero("Terceiro número");
                break;
            case 4:
                CadastrarNumero("Quarto número");
                break;
            case 5:
                RealizarOperacoes();
                break;
            case 6:
                MostrarHistoricoNumeros();
                break;
        }
    }

    static void CadastrarNumero(string nomeNumero)
    {
        Console.Clear();
        Console.WriteLine($"Tecle aqui o {nomeNumero.ToLower()} que você deseja cadastrar --> ");
        double numero = double.Parse(Console.ReadLine());
        Console.WriteLine($"O {nomeNumero.ToLower()} que você cadastrou foi : {numero}");

        historicoNumeros[nomeNumero] = numero;

        Console.WriteLine("\n\nVoltando para as instruções em 3,2,1...");
        Thread.Sleep(2650);
        Console.Clear();
        Instrucoes();
    }

    static void RealizarOperacoes()
    {
        Console.Clear();

        Console.WriteLine("Realizando operações de adição e multiplicação...");

        List<string> nomesNumeros = historicoNumeros.Keys.ToList();

        for (int i = 0; i < nomesNumeros.Count - 1; i++)
        {
            for (int j = i + 1; j < nomesNumeros.Count; j++)
            {
                double numeroA = historicoNumeros[nomesNumeros[i]];
                double numeroB = historicoNumeros[nomesNumeros[j]];

                double soma = numeroA + numeroB;
                double multiplicacao = numeroA * numeroB;

                Console.WriteLine($"Adição entre {nomesNumeros[i]} e {nomesNumeros[j]}: {soma}");
                Console.WriteLine($"Multiplicação entre {nomesNumeros[i]} e {nomesNumeros[j]}: {multiplicacao}");
            }
        }

        // Retorno ao menu
        Console.WriteLine("\n\nVoltando ao menu em 3,2,1...");
        Thread.Sleep(2650);
        Console.Clear();
        Instrucoes();
    }

    static void MostrarHistoricoNumeros()
    {
        Console.Clear();

        Console.WriteLine("O histórico de todos os números digitados é :");

        foreach (var item in historicoNumeros)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }

        Console.WriteLine("\n\nTecle qualquer letra para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
        Instrucoes();
    }
}
*/