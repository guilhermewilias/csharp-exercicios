/*
Faça um programa que:
- Leia a cotação do dólar
- Leia um valor em dólares
- Converta esse valor para Real
- Mostre o resultado
*/

void dollar()
{
    Console.Write("Digite a cotação do dollar do dia --> ");
    double cotacaoDolar = Convert.ToDouble(Console.ReadLine());



    Console.Write("\nDigite um valor em dolar que você queira converter para reais --> ");
    double valorDolar = Convert.ToDouble(Console.ReadLine());

    double dollarEmReais = cotacaoDolar * valorDolar;

    Console.WriteLine($"\n\nO valor de ${valorDolar} convertidos em reais seriam R${dollarEmReais} ");
}

dollar();