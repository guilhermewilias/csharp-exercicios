/*

Faça um programa para pagamento de comissão de vendedores de peças, levando-se em consideração que sua
comissão será de 5% do total da venda e que você tem os seguintes dados:
- Identificação do vendedor
- Código da peça
- Preço unitário da peça
- Quantidade vendida 

*/

void programa()
{
    Console.WriteLine("Questionário informando os dados das vendas, abaixo :");

    Console.Write("\n\nInforme a identificação do vendedor --> ");
    string identificacaoVendedor = Console.ReadLine()!;


    Console.Write("\nInforme o código da peça --> ");
    double codigoPeca = int.Parse(Console.ReadLine()!);


    Console.Write("\nInforme o preço unitário da peça --> ");
    double precoPeca = double.Parse(Console.ReadLine()!);


    Console.Write("\nInforme a quantidade de peças vendidas --> ");
    int quantidadeVendida = int.Parse(Console.ReadLine()!);

    //Calculos :

    double totalVendido = precoPeca * quantidadeVendida;
    double comissaoVendedor = totalVendido * 0.05;


    Console.WriteLine("\n\n\nResumo da venda:");
    Console.WriteLine("Identificação do vendedor: " + identificacaoVendedor);
    Console.WriteLine("Código da peça: " + codigoPeca);
    Console.WriteLine("Preço unitário da peça: " + precoPeca.ToString("C"));
    Console.WriteLine("Quantidade vendida: " + quantidadeVendida);
    Console.WriteLine("Total da venda: " + totalVendido.ToString("C"));
    Console.WriteLine("Comissão do vendedor: " + comissaoVendedor.ToString("C"));



}

programa();