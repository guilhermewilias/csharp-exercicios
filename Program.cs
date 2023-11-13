/* 
Escrever um programa que leia dois números inteiros e mostre todos os relacionamentos de ordem existentes entre eles. 

Os relacionamentos possíveis são: Igual, Não igual, Maior, Menor, Maior ou igual, Menor ou igual. 
*/


static void main()
{
    Console.Write("Escreva o primeiro número inteiro --> ");
    string primeiroNum = Console.ReadLine()!;    
    int primeiroNumINT = int.Parse(primeiroNum);    

    Console.Write("Escreva o segundo número inteiro --> ");
    string segundoNum = Console.ReadLine()!;
    int segundoNumINT = int.Parse(segundoNum);

    verificarRelacionamento(primeiroNumINT, segundoNumINT);

    static void verificarRelacionamento(int primeiroNumINT, int segundoNumINT)
    {
        if (primeiroNumINT == segundoNumINT)
        {
            Console.Write($"\n\nO primeiro número : {primeiroNumINT} é igual ao segundo : {segundoNumINT}");
        }else
        {
            Console.Write($"\n\nO segundo número : {primeiroNumINT} não é igual ao segundo número : {segundoNumINT}");
        }

        if (primeiroNumINT > segundoNumINT)
        {
            Console.Write($"\n\nO primeiro número : {primeiroNumINT} é maior que o segundo número : {segundoNumINT}");
        }
        else
        {
            Console.Write($"\n\nO primeiro número : {primeiroNumINT} é menor que o segundo número : {segundoNumINT}");
        }

        if (primeiroNumINT >= segundoNumINT)
        {
            Console.Write($"\n\nO primeiro número : {primeiroNumINT} é maior ou igual ao segundo número : {segundoNumINT}");
        }
        else
        {
            Console.Write($"\n\nO primeiro número : {primeiroNumINT} não é maior ou igual ao segundo número : {segundoNumINT}");
        }

        if (primeiroNumINT <= segundoNumINT)
        {
            Console.Write($"\n\nO primeiro número : {primeiroNumINT} é menor ou igual ao segundo número : {segundoNumINT}");
        }
        else
        {
            Console.Write($"\n\nO primeiro número : {primeiroNumINT} não é menor ou igual ao segundo número : {segundoNumINT}\n\n");
        }
        
    }
}

main();


